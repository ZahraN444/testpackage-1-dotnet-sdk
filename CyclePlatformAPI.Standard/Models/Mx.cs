// <copyright file="Mx.cs" company="APIMatic">
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
    /// Mx.
    /// </summary>
    public class Mx
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mx"/> class.
        /// </summary>
        public Mx()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mx"/> class.
        /// </summary>
        /// <param name="priority">priority.</param>
        /// <param name="domain">domain.</param>
        public Mx(
            int priority,
            string domain)
        {
            this.Priority = priority;
            this.Domain = domain;
        }

        /// <summary>
        /// The priority setting for this mx record.
        /// </summary>
        [JsonProperty("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// The domain this mx record points to.
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Mx : ({string.Join(", ", toStringOutput)})";
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
            return obj is Mx other &&                this.Priority.Equals(other.Priority) &&
                ((this.Domain == null && other.Domain == null) || (this.Domain?.Equals(other.Domain) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Priority = {this.Priority}");
            toStringOutput.Add($"this.Domain = {(this.Domain == null ? "null" : this.Domain)}");
        }
    }
}