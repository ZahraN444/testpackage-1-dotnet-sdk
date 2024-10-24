// <copyright file="V1HubsCurrentIntegrationsRequest1.cs" company="APIMatic">
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
    /// V1HubsCurrentIntegrationsRequest1.
    /// </summary>
    public class V1HubsCurrentIntegrationsRequest1
    {
        private string name;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "name", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="V1HubsCurrentIntegrationsRequest1"/> class.
        /// </summary>
        public V1HubsCurrentIntegrationsRequest1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1HubsCurrentIntegrationsRequest1"/> class.
        /// </summary>
        /// <param name="vendor">vendor.</param>
        /// <param name="name">name.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="auth">auth.</param>
        /// <param name="extra">extra.</param>
        public V1HubsCurrentIntegrationsRequest1(
            string vendor,
            string name = null,
            string identifier = null,
            Models.Auth6 auth = null,
            Dictionary<string, string> extra = null)
        {
            if (name != null)
            {
                this.Name = name;
            }

            this.Vendor = vendor;
            this.Identifier = identifier;
            this.Auth = auth;
            this.Extra = extra;
        }

        /// <summary>
        /// A name for the Integration.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.shouldSerialize["name"] = true;
                this.name = value;
            }
        }

        /// <summary>
        /// Unique vendor for the Integration, subject to validation.
        /// </summary>
        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.
        /// The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will
        /// have the identifier of `my-container` and is automatically created by the platform.
        /// The identifier does not have to be unique.
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// Authentication information for the Integration.
        /// </summary>
        [JsonProperty("auth", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Auth6 Auth { get; set; }

        /// <summary>
        /// Additional key-value pairs associated with the Integration.
        /// </summary>
        [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Extra { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1HubsCurrentIntegrationsRequest1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetName()
        {
            this.shouldSerialize["name"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeName()
        {
            return this.shouldSerialize["name"];
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
            return obj is V1HubsCurrentIntegrationsRequest1 other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Vendor == null && other.Vendor == null) || (this.Vendor?.Equals(other.Vendor) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Auth == null && other.Auth == null) || (this.Auth?.Equals(other.Auth) == true)) &&
                ((this.Extra == null && other.Extra == null) || (this.Extra?.Equals(other.Extra) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Vendor = {(this.Vendor == null ? "null" : this.Vendor)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Auth = {(this.Auth == null ? "null" : this.Auth.ToString())}");
            toStringOutput.Add($"Extra = {(this.Extra == null ? "null" : this.Extra.ToString())}");
        }
    }
}