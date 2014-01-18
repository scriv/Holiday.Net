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
        private readonly Uri host;

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

            const string setLightsPath = "/iotas/0.1/device/moorescloud.holiday/localhost/setlights";
            var fullUrl = new Uri(this.host, setLightsPath);

            var response = this.Request(fullUrl.ToString(), "PUT", new { lights = lights.Select(c => c.ToString()) });

            return response;
        }

        /// <summary>
        /// Initiates an HTTP request.
        /// </summary>
        /// <param name="url">The URL to request.</param>
        /// <param name="method">The request method.</param>
        /// <param name="body">The request body.</param>
        /// <returns></returns>
        private async Task<HttpResponseMessage> Request(string url, string method, object body)
        {
            using (var client = new HttpClient())
            {
                string json = null;

                if (body != null)
                {
                    json = JsonConvert.SerializeObject(body);
                }

                if (method == "PUT")
                {
                    return await client.PutAsync(url, new StringContent(json, Encoding.UTF8, "application/json"));
                }

                return await client.GetAsync(url);
            }
        }
    }
}