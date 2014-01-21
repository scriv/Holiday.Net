using Holiday.Iotas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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
        public Task SetLights(IEnumerable<Colour> lights)
        {
            if (lights == null || lights.Count() != HolidayExtensions.NumberOfLights)
            {
                throw new ArgumentOutOfRangeException("lights", "lights must contain 50 colour values.");
            }

            this.VerifyDeviceExists();

            const string setLightsPath = "/iotas/0.1/device/moorescloud.holiday/localhost/setlights";
            var response = this.Request(setLightsPath, "PUT", new { lights = lights.Select(c => c.ToString()).ToArray() });

            return response;
        }

        /// <summary>
        /// Initiates an HTTP request.
        /// </summary>
        /// <param name="path">The path to request.</param>
        /// <param name="method">The request method.</param>
        /// <param name="body">The request body.</param>
        /// <returns></returns>
        private Task<HttpResponseMessage> Request(string path, string method, object body)
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
                return this.httpClient.PutAsync(requestUrl, content);
            }

            return this.httpClient.GetAsync(requestUrl);
        }

        /// <summary>
        /// Verifies that a Holiday device at the configured host exists.
        /// </summary>
        /// <exception cref="ArgumentException">There is no Holiday device at the specified host.</exception>
        /// <remarks>Note that because this method uses locking it can't be async. Ideally the responses would be awaitable so 
        /// that on first load the executing thread will be given back control while the device is verified. The locking could be removed 
        /// to bring in this functionality if it becomes more important and thread safety functionality can be implemented another way perhaps.
        /// The locking described here http://www.hanselman.com/blog/ComparingTwoTechniquesInNETAsynchronousCoordinationPrimitives.aspx looks ideal, but I'm not sure it's needed here.</remarks>
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

                            this.deviceExists = true;
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
    }
}