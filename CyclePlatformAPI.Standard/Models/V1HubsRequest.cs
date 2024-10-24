// <copyright file="V1HubsRequest.cs" company="APIMatic">
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
    /// V1HubsRequest.
    /// </summary>
    public class V1HubsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1HubsRequest"/> class.
        /// </summary>
        public V1HubsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1HubsRequest"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="webhooks">webhooks.</param>
        public V1HubsRequest(
            string name = null,
            string identifier = null,
            Models.HubWebhooks webhooks = null)
        {
            this.Name = name;
            this.Identifier = identifier;
            this.Webhooks = webhooks;
        }

        /// <summary>
        /// A name for the Hub.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.
        /// The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will
        /// have the identifier of `my-container` and is automatically created by the platform.
        /// The identifier does not have to be unique.
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

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

            return $"V1HubsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1HubsRequest other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Webhooks == null && other.Webhooks == null) || (this.Webhooks?.Equals(other.Webhooks) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Webhooks = {(this.Webhooks == null ? "null" : this.Webhooks.ToString())}");
        }
    }
}