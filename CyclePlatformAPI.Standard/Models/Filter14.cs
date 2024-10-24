// <copyright file="Filter14.cs" company="APIMatic">
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
    /// Filter14.
    /// </summary>
    public class Filter14
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter14"/> class.
        /// </summary>
        public Filter14()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter14"/> class.
        /// </summary>
        /// <param name="domain">domain.</param>
        public Filter14(
            string domain = null)
        {
            this.Domain = domain;
        }

        /// <summary>
        /// `filter[domain]=value` filter the return for TLS attempts by domain.
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter14 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter14 other &&                ((this.Domain == null && other.Domain == null) || (this.Domain?.Equals(other.Domain) == true));
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