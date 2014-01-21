using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Holiday.Iotas
{
    /// <summary>
    /// Represents the state of an IoTAS (Internet of Things Access Server) device.
    /// </summary>
    public class DeviceDescriptor
    {
        /// <summary>
        /// Gets or sets a collection of available device APIs.
        /// </summary>
        [JsonProperty("apis")]
        public object[] Apis { get; set; }

        /// <summary>
        /// Gets or sets the IP address of the device.
        /// </summary>
        [JsonProperty("ip")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the local device.
        /// </summary>
        [JsonProperty("local_device")]
        public string LocalDevice { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the host name.
        /// </summary>
        [JsonProperty("host_name")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets the local name.
        /// </summary>
        [JsonProperty("local_name")]
        public string LocalName { get; set; }
    }
}