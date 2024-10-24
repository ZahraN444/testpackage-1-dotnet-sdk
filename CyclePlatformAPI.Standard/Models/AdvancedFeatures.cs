// <copyright file="AdvancedFeatures.cs" company="APIMatic">
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
    /// AdvancedFeatures.
    /// </summary>
    public class AdvancedFeatures
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedFeatures"/> class.
        /// </summary>
        public AdvancedFeatures()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedFeatures"/> class.
        /// </summary>
        /// <param name="gpu">gpu.</param>
        /// <param name="ial">ial.</param>
        /// <param name="deployments">deployments.</param>
        /// <param name="autoscale">autoscale.</param>
        public AdvancedFeatures(
            bool gpu,
            bool ial,
            bool deployments,
            bool autoscale)
        {
            this.Gpu = gpu;
            this.Ial = ial;
            this.Deployments = deployments;
            this.Autoscale = autoscale;
        }

        /// <summary>
        /// Gets or sets Gpu.
        /// </summary>
        [JsonProperty("gpu")]
        public bool Gpu { get; set; }

        /// <summary>
        /// Gets or sets Ial.
        /// </summary>
        [JsonProperty("ial")]
        public bool Ial { get; set; }

        /// <summary>
        /// Gets or sets Deployments.
        /// </summary>
        [JsonProperty("deployments")]
        public bool Deployments { get; set; }

        /// <summary>
        /// Gets or sets Autoscale.
        /// </summary>
        [JsonProperty("autoscale")]
        public bool Autoscale { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AdvancedFeatures : ({string.Join(", ", toStringOutput)})";
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
            return obj is AdvancedFeatures other &&                this.Gpu.Equals(other.Gpu) &&
                this.Ial.Equals(other.Ial) &&
                this.Deployments.Equals(other.Deployments) &&
                this.Autoscale.Equals(other.Autoscale);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Gpu = {this.Gpu}");
            toStringOutput.Add($"this.Ial = {this.Ial}");
            toStringOutput.Add($"this.Deployments = {this.Deployments}");
            toStringOutput.Add($"this.Autoscale = {this.Autoscale}");
        }
    }
}