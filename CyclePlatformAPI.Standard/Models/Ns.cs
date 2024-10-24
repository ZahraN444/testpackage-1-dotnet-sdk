// <copyright file="Ns.cs" company="APIMatic">
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
    /// Ns.
    /// </summary>
    public class Ns
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ns"/> class.
        /// </summary>
        public Ns()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ns"/> class.
        /// </summary>
        /// <param name="domain">domain.</param>
        public Ns(
            string domain)
        {
            this.Domain = domain;
        }

        /// <summary>
        /// The domain of the nameserver for this record.
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Ns : ({string.Join(", ", toStringOutput)})";
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
            return obj is Ns other &&                ((this.Domain == null && other.Domain == null) || (this.Domain?.Equals(other.Domain) == true));
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