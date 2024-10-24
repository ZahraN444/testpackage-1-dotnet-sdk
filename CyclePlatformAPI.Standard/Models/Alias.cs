// <copyright file="Alias.cs" company="APIMatic">
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
    /// Alias.
    /// </summary>
    public class Alias
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Alias"/> class.
        /// </summary>
        public Alias()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Alias"/> class.
        /// </summary>
        /// <param name="domain">domain.</param>
        public Alias(
            string domain)
        {
            this.Domain = domain;
        }

        /// <summary>
        /// The domain string returned from the DNS server when this alias record is requested.
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Alias : ({string.Join(", ", toStringOutput)})";
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
            return obj is Alias other &&                ((this.Domain == null && other.Domain == null) || (this.Domain?.Equals(other.Domain) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Domain = {(this.Domain == null ? "null" : this.Domain)}");
        }
    }
}