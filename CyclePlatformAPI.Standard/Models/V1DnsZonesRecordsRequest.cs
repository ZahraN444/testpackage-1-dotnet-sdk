// <copyright file="V1DnsZonesRecordsRequest.cs" company="APIMatic">
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
    /// V1DnsZonesRecordsRequest.
    /// </summary>
    public class V1DnsZonesRecordsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1DnsZonesRecordsRequest"/> class.
        /// </summary>
        public V1DnsZonesRecordsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1DnsZonesRecordsRequest"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="name">name.</param>
        public V1DnsZonesRecordsRequest(
            Models.DNSRecordTypes type,
            string name)
        {
            this.Type = type;
            this.Name = name;
        }

        /// <summary>
        /// DNS record types the platform supports.
        /// </summary>
        [JsonProperty("type")]
        public Models.DNSRecordTypes Type { get; set; }

        /// <summary>
        /// A name for the given record where `@` represents the desire to use the root of the origin.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1DnsZonesRecordsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1DnsZonesRecordsRequest other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
        }
    }
}