using Holiday.Iotas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Holiday
{
    /// <summary>
    /// A Holiday client that uses the device's REST API.
    /// </summary>
    public class RestHolidayClient : IHolidayClient
    {
        private bool? deviceExists;
        private readonly object discoverLock = new object();
        private readonly Uri host;
        private readonly TimeSpan timeout = TimeSpan.FromSeconds(10);
        private readonly HttpClient httpClient = new HttpClient();
        private const string HolidayDevice = "moorescloud.holiday";

        private const string SetLightsPath = "/iotas/0.1/device/moorescloud.holiday/localhost/setlights";
        private const string GradientPath = "/iotas/0.1/device/moorescloud.holiday/localhost/gradient";
        private const string GetLedValuePath = "/iotas/0.1/device/moorescloud.holiday/localhost/led/{0}/value";

        /// <summary>
        /// Indicates how many times a globe can change per-second when displaying a gradient.
        /// </summary>
        public const int GradientStepsPerSecond = 50;

        /// <summary>
        /// Initializes a new instance of the <see cref="RestHolidayClient"/> class.
        /// </summary>
        /// <param name="host">The host.</param>
        /// <exception cref="System.ArgumentNullException">host</exception>
        public RestHolidayClient(Uri host)
        {
            if (host == null)
            {
                throw new ArgumentNullException("host");
            }

            this.host = host;
            this.httpClient.Timeout = this.timeout;
        }

        /// <summary>
        /// Sets the individual lights of the holiday device.
        /// </summary>
        /// <param name="lights">A collection of 50 hex colour values.</param>
        /// <exception cref="System.ArgumentOutOfRangeException"><paramref name="lights"/> must contain 50 colour values.</exception>
        public async Task SetLights(IEnumerable<Colour> lights)
        {
            if (lights == null || lights.Count() != HolidayExtensions.NumberOfLights)
            {
                throw new ArgumentOutOfRangeException("lights", "lights must contain 50 colour values.");
            }

            this.VerifyDeviceExists();

            var response = this.Request(SetLightsPath, "PUT", new { lights = lights.Select(c => c.ToString()).ToArray() });

            await response;
        }

        /// <summary>
        /// Performs a gradient – an even transition – across all of the globes on a string together, moving in concert from one colour to another colour.
        /// </summary>
        /// <param name="begin">The colour to start with</param>
        /// <param name="end">The colour to end with</param>
        /// <param name="duration">The duration of the transition.</param>
        public async Task Gradient(Colour begin, Colour end, TimeSpan duration)
        {
            this.VerifyDeviceExists();

            int steps = (int)(duration.TotalSeconds * GradientStepsPerSecond);

            var response = this.Request(GradientPath, "PUT", new { begin = new[] { (int)begin.R, (int)begin.G, (int)begin.B }, end = new[] { (int)end.R, (int)end.G, (int)end.B }, steps = steps });

            await response;
        }

        /// <summary>
        /// Gets the <see cref="Colour" /> of an individual lamp on the holiday device.
        /// </summary>
        /// <param name="lampPosition">The lamp position (0 - 49).</param>
        /// <returns>
        /// The <see cref="Colour" /> of the lamp.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">The lamp position must be in the range 0-49.</exception>
        public async Task<Colour> GetLampColour(int lampPosition)
        {
            if (lampPosition < 0 || lampPosition > 49)
            {
                throw new ArgumentOutOfRangeException("lampPosition", "The lamp position must be in the range 0-49.");
            }

            this.VerifyDeviceExists();

            var response = this.Request(string.Format(GetLedValuePath, lampPosition), "GET", null);

            await response;

            return await response.Result.Content.ReadAsStringAsync().ContinueWith(t => ConvertLampResultToColour(JsonConvert.DeserializeObject(t.Result)));
        }

        /// <summary>
        /// Sets the <see cref="Colour" /> of an individual lamp on the holiday device.
        /// </summary>
        /// <param name="lampPosition">The lamp position (0 - 49).</param>
        /// <param name="colour">The <see cref="Colour" /> that the lamp should be set to.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentOutOfRangeException">The lamp position must be in the range 0-49.</exception>
        public async Task SetLampColour(int lampPosition, Colour colour)
        {
            if (lampPosition < 0 || lampPosition > 49)
            {
                throw new ArgumentOutOfRangeException("lampPosition", "The lamp position must be in the range 0-49.");
            }

            this.VerifyDeviceExists();

            var response = this.Request(string.Format(GetLedValuePath, lampPosition), "PUT", new { value = new[] { (int)colour.R, (int)colour.G, (int)colour.B } });

            await response;
        }

        /// <summary>
        /// Initiates an HTTP request.
        /// </summary>
        /// <param name="path">The path to request.</param>
        /// <param name="method">The request method.</param>
        /// <param name="body">The request body.</param>
        /// <returns></returns>
        private async Task<HttpResponseMessage> Request(string path, string method, object body)
        {
            string json = null;
            var requestUrl = new Uri(this.host, path);

            if (body != null)
            {
                json = JsonConvert.SerializeObject(body);
            }

            if (method == "PUT")
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                return await this.httpClient.PutAsync(requestUrl, content).ConfigureAwait(false);
            }

            return await this.httpClient.GetAsync(requestUrl).ConfigureAwait(false);
        }

        /// <summary>
        /// Verifies that a Holiday device at the configured host exists.
        /// </summary>
        /// <exception cref="ArgumentException">There is no Holiday device at the specified host.</exception>
        /// <remarks>Note that because this method uses locking it can't be async. Ideally the responses would be awaitable so 
        /// that on first load the executing thread will be given back control while the device is verified. The locking could be removed 
        /// to bring in this functionality if it becomes more important and thread safety functionality can be implemented another way perhaps.
        /// The locking described here http://www.hanselman.com/blog/ComparingTwoTechniquesInNETAsynchronousCoordinationPrimitives.aspx looks good, but I'm not sure it's needed here.</remarks>
        private void VerifyDeviceExists()
        {
            if (!this.deviceExists.HasValue)
            {
                lock (discoverLock)
                {
                    if (!this.deviceExists.HasValue)
                    {
                        const string iotasPath = "/iotas";
                        var discoveryResponse = this.Request(iotasPath, "GET", null);

                        try
                        {
                            var device = JsonConvert.DeserializeObject<DeviceDescriptor>(discoveryResponse.Result.Content.ReadAsStringAsync().Result);
                            
                            this.deviceExists = (device.LocalDevice == HolidayDevice);
                        
                        }
                        catch
                        {
                            this.deviceExists = false;
                        }
                    }
                }
            }

            if (!this.deviceExists.Value)
            {
                throw new ArgumentException("There is no Holiday device at the specified host.", "host");
            }
        }

        private Colour ConvertLampResultToColour(dynamic lampResult)
        {
            return new Colour((byte)lampResult["value"][0], (byte)lampResult["value"][1], (byte)lampResult["value"][2]);
        }
    }
}