// <copyright file="DefaultLbType.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// DefaultLbType.
    /// </summary>
    public class DefaultLbType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultLbType"/> class.
        /// </summary>
        public DefaultLbType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultLbType"/> class.
        /// </summary>
        /// <param name="ipv4">ipv4.</param>
        /// <param name="ipv6">ipv6.</param>
        /// <param name="type">type.</param>
        /// <param name="details">details.</param>
        public DefaultLbType(
            bool ipv4,
            bool ipv6,
            string type,
            DefaultLbTypeDetails details = null)
        {
            this.Ipv4 = ipv4;
            this.Ipv6 = ipv6;
            this.Type = type;
            this.Details = details;
        }

        /// <summary>
        /// Allow / disallow traffic to be routed via IPv4.
        /// </summary>
        [JsonProperty("ipv4")]
        [JsonRequired]
        public bool Ipv4 { get; set; }

        /// <summary>
        /// Allow / disallow traffic to be routed via IPv6.
        /// </summary>
        [JsonProperty("ipv6")]
        [JsonRequired]
        public bool Ipv6 { get; set; }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("type")]
        [JsonRequired]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Details.
        /// </summary>
        [JsonProperty("details", NullValueHandling = NullValueHandling.Include)]
        public DefaultLbTypeDetails Details { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DefaultLbType : ({string.Join(", ", toStringOutput)})";
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
            return obj is DefaultLbType other &&                this.Ipv4.Equals(other.Ipv4) &&
                this.Ipv6.Equals(other.Ipv6) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Details == null && other.Details == null) || (this.Details?.Equals(other.Details) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ipv4 = {this.Ipv4}");
            toStringOutput.Add($"this.Ipv6 = {this.Ipv6}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"Details = {(this.Details == null ? "null" : this.Details.ToString())}");
        }
    }
}