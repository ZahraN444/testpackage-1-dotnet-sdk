// <copyright file="Aws.cs" company="APIMatic">
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
    /// Aws.
    /// </summary>
    public class Aws
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Aws"/> class.
        /// </summary>
        public Aws()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Aws"/> class.
        /// </summary>
        /// <param name="enaSupport">ena_support.</param>
        /// <param name="ebsOptimized">ebs_optimized.</param>
        public Aws(
            bool enaSupport,
            bool ebsOptimized)
        {
            this.EnaSupport = enaSupport;
            this.EbsOptimized = ebsOptimized;
        }

        /// <summary>
        /// A boolean where true indicates this is a machine that can support a much higher networking throughput.
        /// </summary>
        [JsonProperty("ena_support")]
        public bool EnaSupport { get; set; }

        /// <summary>
        /// A boolean where true indicates this is a machine that can support higher storage throughput.
        /// </summary>
        [JsonProperty("ebs_optimized")]
        public bool EbsOptimized { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Aws : ({string.Join(", ", toStringOutput)})";
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
            return obj is Aws other &&                this.EnaSupport.Equals(other.EnaSupport) &&
                this.EbsOptimized.Equals(other.EbsOptimized);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EnaSupport = {this.EnaSupport}");
            toStringOutput.Add($"this.EbsOptimized = {this.EbsOptimized}");
        }
    }
}