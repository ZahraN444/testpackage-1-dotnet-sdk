// <copyright file="V1DnsZonesRecordsRequest1.cs" company="APIMatic">
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
    /// V1DnsZonesRecordsRequest1.
    /// </summary>
    public class V1DnsZonesRecordsRequest1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1DnsZonesRecordsRequest1"/> class.
        /// </summary>
        public V1DnsZonesRecordsRequest1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1DnsZonesRecordsRequest1"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        public V1DnsZonesRecordsRequest1(
            Models.DNSRecordTypes type)
        {
            this.Type = type;
        }

        /// <summary>
        /// DNS record types the platform supports.
        /// </summary>
        [JsonProperty("type")]
        public Models.DNSRecordTypes Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1DnsZonesRecordsRequest1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1DnsZonesRecordsRequest1 other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type.ToString())}");
        }
    }
}