// <copyright file="V1HubsCurrentRequest.cs" company="APIMatic">
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
    /// V1HubsCurrentRequest.
    /// </summary>
    public class V1HubsCurrentRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1HubsCurrentRequest"/> class.
        /// </summary>
        public V1HubsCurrentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1HubsCurrentRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="webhooks">webhooks.</param>
        public V1HubsCurrentRequest(
            string name = null,
            Models.HubWebhooks webhooks = null)
        {
            this.Name = name;
            this.Webhooks = webhooks;
        }

        /// <summary>
        /// A name for the hub.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Hub related webhooks. When supplied, the given webhook will be called with a payload any time one of these events occurs.
        /// </summary>
        [JsonProperty("webhooks", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HubWebhooks Webhooks { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1HubsCurrentRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1HubsCurrentRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Webhooks == null && other.Webhooks == null) || (this.Webhooks?.Equals(other.Webhooks) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Webhooks = {(this.Webhooks == null ? "null" : this.Webhooks.ToString())}");
        }
    }
}