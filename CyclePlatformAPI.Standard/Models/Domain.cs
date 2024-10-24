// <copyright file="Domain.cs" company="APIMatic">
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
    /// Domain.
    /// </summary>
    public class Domain
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Domain"/> class.
        /// </summary>
        public Domain()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Domain"/> class.
        /// </summary>
        /// <param name="fqdn">fqdn.</param>
        /// <param name="record">record.</param>
        public Domain(
            string fqdn,
            Models.DNSRecord record = null)
        {
            this.Fqdn = fqdn;
            this.Record = record;
        }

        /// <summary>
        /// The fully qualified domain name.
        /// </summary>
        [JsonProperty("fqdn")]
        public string Fqdn { get; set; }

        /// <summary>
        /// A DNS record.
        /// </summary>
        [JsonProperty("record", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DNSRecord Record { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Domain : ({string.Join(", ", toStringOutput)})";
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
            return obj is Domain other &&                ((this.Fqdn == null && other.Fqdn == null) || (this.Fqdn?.Equals(other.Fqdn) == true)) &&
                ((this.Record == null && other.Record == null) || (this.Record?.Equals(other.Record) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Fqdn = {(this.Fqdn == null ? "null" : this.Fqdn)}");
            toStringOutput.Add($"this.Record = {(this.Record == null ? "null" : this.Record.ToString())}");
        }
    }
}