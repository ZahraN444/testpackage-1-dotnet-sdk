// <copyright file="V1HubsCurrentApiKeysRequest.cs" company="APIMatic">
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
    /// V1HubsCurrentApiKeysRequest.
    /// </summary>
    public class V1HubsCurrentApiKeysRequest
    {
        private List<string> ips;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ips", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="V1HubsCurrentApiKeysRequest"/> class.
        /// </summary>
        public V1HubsCurrentApiKeysRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1HubsCurrentApiKeysRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="ips">ips.</param>
        public V1HubsCurrentApiKeysRequest(
            string name = null,
            Models.Permissions permissions = null,
            Models.Capabilities8 capabilities = null,
            List<string> ips = null)
        {
            this.Name = name;
            this.Permissions = permissions;
            this.Capabilities = capabilities;
            if (ips != null)
            {
                this.Ips = ips;
            }

        }

        /// <summary>
        /// A name given to the API Key.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Permissions information for an API Key
        /// </summary>
        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Permissions Permissions { get; set; }

        /// <summary>
        /// An object defining the capabilities of the given API key.
        /// </summary>
        [JsonProperty("capabilities", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Capabilities8 Capabilities { get; set; }

        /// <summary>
        /// An array of approved IPs from which this API Key can be used.
        /// </summary>
        [JsonProperty("ips")]
        public List<string> Ips
        {
            get
            {
                return this.ips;
            }

            set
            {
                this.shouldSerialize["ips"] = true;
                this.ips = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1HubsCurrentApiKeysRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIps()
        {
            this.shouldSerialize["ips"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIps()
        {
            return this.shouldSerialize["ips"];
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
            return obj is V1HubsCurrentApiKeysRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Permissions == null && other.Permissions == null) || (this.Permissions?.Equals(other.Permissions) == true)) &&
                ((this.Capabilities == null && other.Capabilities == null) || (this.Capabilities?.Equals(other.Capabilities) == true)) &&
                ((this.Ips == null && other.Ips == null) || (this.Ips?.Equals(other.Ips) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Permissions = {(this.Permissions == null ? "null" : this.Permissions.ToString())}");
            toStringOutput.Add($"this.Capabilities = {(this.Capabilities == null ? "null" : this.Capabilities.ToString())}");
            toStringOutput.Add($"this.Ips = {(this.Ips == null ? "null" : $"[{string.Join(", ", this.Ips)} ]")}");
        }
    }
}