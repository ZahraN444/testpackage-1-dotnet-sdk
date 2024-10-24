// <copyright file="V1DnsZonesRequest.cs" company="APIMatic">
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
    /// V1DnsZonesRequest.
    /// </summary>
    public class V1DnsZonesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1DnsZonesRequest"/> class.
        /// </summary>
        public V1DnsZonesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1DnsZonesRequest"/> class.
        /// </summary>
        /// <param name="hosted">hosted.</param>
        /// <param name="origin">origin.</param>
        public V1DnsZonesRequest(
            bool hosted,
            string origin)
        {
            this.Hosted = hosted;
            this.Origin = origin;
        }

        /// <summary>
        /// A boolean where true represents the desire for the origin to be of the type `hosted`.
        /// </summary>
        [JsonProperty("hosted")]
        public bool Hosted { get; set; }

        /// <summary>
        /// The origin that will be created.
        /// </summary>
        [JsonProperty("origin")]
        public string Origin { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1DnsZonesRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1DnsZonesRequest other &&                this.Hosted.Equals(other.Hosted) &&
                ((this.Origin == null && other.Origin == null) || (this.Origin?.Equals(other.Origin) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Hosted = {this.Hosted}");
            toStringOutput.Add($"this.Origin = {(this.Origin == null ? "null" : this.Origin)}");
        }
    }
}