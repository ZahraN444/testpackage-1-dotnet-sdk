// <copyright file="StackContainerConfigScalingYml.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// StackContainerConfigScalingYml.
    /// </summary>
    public class StackContainerConfigScalingYml
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackContainerConfigScalingYml"/> class.
        /// </summary>
        public StackContainerConfigScalingYml()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackContainerConfigScalingYml"/> class.
        /// </summary>
        /// <param name="instances">instances.</param>
        /// <param name="window">window.</param>
        /// <param name="thresholds">thresholds.</param>
        /// <param name="autoscaleGroup">autoscale_group.</param>
        public StackContainerConfigScalingYml(
            Models.Instances instances,
            string window,
            List<StackContainerScaleThreshold> thresholds,
            string autoscaleGroup = null)
        {
            this.AutoscaleGroup = autoscaleGroup;
            this.Instances = instances;
            this.Window = window;
            this.Thresholds = thresholds;
        }

        /// <summary>
        /// The autoscaling group describes which servers should be deployed
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("autoscale_group", NullValueHandling = NullValueHandling.Include)]
        public string AutoscaleGroup { get; set; }

        /// <summary>
        /// Describes how many instances should be running
        /// </summary>
        [JsonProperty("instances")]
        [JsonRequired]
        public Models.Instances Instances { get; set; }

        /// <summary>
        /// Duration in which the auto-scaler will watch for changes
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("window")]
        [JsonRequired]
        public string Window { get; set; }

        /// <summary>
        /// An array of rules that dictate when a scaling event will be triggered
        /// </summary>
        [JsonProperty("thresholds")]
        [JsonRequired]
        public List<StackContainerScaleThreshold> Thresholds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackContainerConfigScalingYml : ({string.Join(", ", toStringOutput)})";
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
            return obj is StackContainerConfigScalingYml other &&                ((this.AutoscaleGroup == null && other.AutoscaleGroup == null) || (this.AutoscaleGroup?.Equals(other.AutoscaleGroup) == true)) &&
                ((this.Instances == null && other.Instances == null) || (this.Instances?.Equals(other.Instances) == true)) &&
                ((this.Window == null && other.Window == null) || (this.Window?.Equals(other.Window) == true)) &&
                ((this.Thresholds == null && other.Thresholds == null) || (this.Thresholds?.Equals(other.Thresholds) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AutoscaleGroup = {(this.AutoscaleGroup == null ? "null" : this.AutoscaleGroup)}");
            toStringOutput.Add($"this.Instances = {(this.Instances == null ? "null" : this.Instances.ToString())}");
            toStringOutput.Add($"this.Window = {(this.Window == null ? "null" : this.Window)}");
            toStringOutput.Add($"Thresholds = {(this.Thresholds == null ? "null" : this.Thresholds.ToString())}");
        }
    }
}