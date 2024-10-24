// <copyright file="ServerProvider.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using CyclePlatformAPI.Standard;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// ServerProvider.
    /// </summary>
    public class ServerProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerProvider"/> class.
        /// </summary>
        public ServerProvider()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerProvider"/> class.
        /// </summary>
        /// <param name="vendor">vendor.</param>
        /// <param name="model">model.</param>
        /// <param name="location">location.</param>
        /// <param name="server">server.</param>
        /// <param name="initIps">init_ips.</param>
        /// <param name="macAddr">mac_addr.</param>
        /// <param name="extra">extra.</param>
        /// <param name="provisionOptions">provision_options.</param>
        public ServerProvider(
            string vendor,
            string model,
            string location,
            string server,
            List<string> initIps = null,
            string macAddr = null,
            object extra = null,
            Models.ProvisionOptions provisionOptions = null)
        {
            this.Vendor = vendor;
            this.Model = model;
            this.Location = location;
            this.Server = server;
            this.InitIps = initIps;
            this.MacAddr = macAddr;
            this.Extra = extra;
            this.ProvisionOptions = provisionOptions;
        }

        /// <summary>
        /// The vendor for the provider this server is deployed from.
        /// </summary>
        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// The model of the server that is deployed.
        /// </summary>
        [JsonProperty("model")]
        public string Model { get; set; }

        /// <summary>
        /// A location where the server is deployed.
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// A provider specific identifier for the server.
        /// </summary>
        [JsonProperty("server")]
        public string Server { get; set; }

        /// <summary>
        /// The IP's assigned to this server during provisioning.
        /// </summary>
        [JsonProperty("init_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InitIps { get; set; }

        /// <summary>
        /// The mac address for the server.
        /// </summary>
        [JsonProperty("mac_addr", NullValueHandling = NullValueHandling.Ignore)]
        public string MacAddr { get; set; }

        /// <summary>
        /// Gets or sets Extra.
        /// </summary>
        [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
        public object Extra { get; set; }

        /// <summary>
        /// Gets or sets ProvisionOptions.
        /// </summary>
        [JsonProperty("provision_options", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProvisionOptions ProvisionOptions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerProvider : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ServerProvider other &&                ((this.Vendor == null && other.Vendor == null) || (this.Vendor?.Equals(other.Vendor) == true)) &&
                ((this.Model == null && other.Model == null) || (this.Model?.Equals(other.Model) == true)) &&
                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true)) &&
                ((this.Server == null && other.Server == null) || (this.Server?.Equals(other.Server) == true)) &&
                ((this.InitIps == null && other.InitIps == null) || (this.InitIps?.Equals(other.InitIps) == true)) &&
                ((this.MacAddr == null && other.MacAddr == null) || (this.MacAddr?.Equals(other.MacAddr) == true)) &&
                ((this.Extra == null && other.Extra == null) || (this.Extra?.Equals(other.Extra) == true)) &&
                ((this.ProvisionOptions == null && other.ProvisionOptions == null) || (this.ProvisionOptions?.Equals(other.ProvisionOptions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Vendor = {(this.Vendor == null ? "null" : this.Vendor)}");
            toStringOutput.Add($"this.Model = {(this.Model == null ? "null" : this.Model)}");
            toStringOutput.Add($"this.Location = {(this.Location == null ? "null" : this.Location)}");
            toStringOutput.Add($"this.Server = {(this.Server == null ? "null" : this.Server)}");
            toStringOutput.Add($"this.InitIps = {(this.InitIps == null ? "null" : $"[{string.Join(", ", this.InitIps)} ]")}");
            toStringOutput.Add($"this.MacAddr = {(this.MacAddr == null ? "null" : this.MacAddr)}");
            toStringOutput.Add($"Extra = {(this.Extra == null ? "null" : this.Extra.ToString())}");
            toStringOutput.Add($"this.ProvisionOptions = {(this.ProvisionOptions == null ? "null" : this.ProvisionOptions.ToString())}");
        }
    }
}