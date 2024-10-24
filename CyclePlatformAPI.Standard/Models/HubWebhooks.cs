// <copyright file="HubWebhooks.cs" company="APIMatic">
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
    /// HubWebhooks.
    /// </summary>
    public class HubWebhooks
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubWebhooks"/> class.
        /// </summary>
        public HubWebhooks()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HubWebhooks"/> class.
        /// </summary>
        /// <param name="serverDeployed">server_deployed.</param>
        /// <param name="serverDeleted">server_deleted.</param>
        public HubWebhooks(
            string serverDeployed = null,
            string serverDeleted = null)
        {
            this.ServerDeployed = serverDeployed;
            this.ServerDeleted = serverDeleted;
        }

        /// <summary>
        /// A webhook that is called any time a server is deployed to this hub. The payload will be a `Server` object.
        /// </summary>
        [JsonProperty("server_deployed", NullValueHandling = NullValueHandling.Include)]
        public string ServerDeployed { get; set; }

        /// <summary>
        /// A webhook that is called any time a server in this hub is deleted. The payload will be a `Server` object.
        /// </summary>
        [JsonProperty("server_deleted", NullValueHandling = NullValueHandling.Include)]
        public string ServerDeleted { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HubWebhooks : ({string.Join(", ", toStringOutput)})";
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
            return obj is HubWebhooks other &&                ((this.ServerDeployed == null && other.ServerDeployed == null) || (this.ServerDeployed?.Equals(other.ServerDeployed) == true)) &&
                ((this.ServerDeleted == null && other.ServerDeleted == null) || (this.ServerDeleted?.Equals(other.ServerDeleted) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ServerDeployed = {(this.ServerDeployed == null ? "null" : this.ServerDeployed)}");
            toStringOutput.Add($"this.ServerDeleted = {(this.ServerDeleted == null ? "null" : this.ServerDeleted)}");
        }
    }
}