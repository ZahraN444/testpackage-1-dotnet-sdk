// <copyright file="Autoscale.cs" company="APIMatic">
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
    /// Autoscale.
    /// </summary>
    public class Autoscale
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Autoscale"/> class.
        /// </summary>
        public Autoscale()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Autoscale"/> class.
        /// </summary>
        /// <param name="siblingId">sibling_id.</param>
        /// <param name="minTtl">min_ttl.</param>
        public Autoscale(
            string siblingId = null,
            DateTime? minTtl = null)
        {
            this.SiblingId = siblingId;
            this.MinTtl = minTtl;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("sibling_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SiblingId { get; set; }

        /// <summary>
        /// Gets or sets MinTtl.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("min_ttl", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? MinTtl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Autoscale : ({string.Join(", ", toStringOutput)})";
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
            return obj is Autoscale other &&                ((this.SiblingId == null && other.SiblingId == null) || (this.SiblingId?.Equals(other.SiblingId) == true)) &&
                ((this.MinTtl == null && other.MinTtl == null) || (this.MinTtl?.Equals(other.MinTtl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SiblingId = {(this.SiblingId == null ? "null" : this.SiblingId)}");
            toStringOutput.Add($"this.MinTtl = {(this.MinTtl == null ? "null" : this.MinTtl.ToString())}");
        }
    }
}