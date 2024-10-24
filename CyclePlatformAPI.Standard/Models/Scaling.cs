// <copyright file="Scaling.cs" company="APIMatic">
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
    /// Scaling.
    /// </summary>
    public class Scaling
    {
        private string autoscaleGroup;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "autoscale_group", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Scaling"/> class.
        /// </summary>
        public Scaling()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Scaling"/> class.
        /// </summary>
        /// <param name="autoscaleGroup">autoscale_group.</param>
        /// <param name="instances">instances.</param>
        /// <param name="window">window.</param>
        /// <param name="thresholds">thresholds.</param>
        public Scaling(
            string autoscaleGroup = null,
            Models.Instances instances = null,
            string window = null,
            List<StackContainerScaleThreshold> thresholds = null)
        {
            if (autoscaleGroup != null)
            {
                this.AutoscaleGroup = autoscaleGroup;
            }

            this.Instances = instances;
            this.Window = window;
            this.Thresholds = thresholds;
        }

        /// <summary>
        /// The autoscaling group describes which servers should be deployed
        /// </summary>
        [JsonProperty("autoscale_group")]
        public string AutoscaleGroup
        {
            get
            {
                return this.autoscaleGroup;
            }

            set
            {
                this.shouldSerialize["autoscale_group"] = true;
                this.autoscaleGroup = value;
            }
        }

        /// <summary>
        /// Describes how many instances should be running
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Instances Instances { get; set; }

        /// <summary>
        /// Duration in which the auto-scaler will watch for changes
        /// </summary>
        [JsonProperty("window", NullValueHandling = NullValueHandling.Ignore)]
        public string Window { get; set; }

        /// <summary>
        /// An array of rules that dictate when a scaling event will be triggered
        /// </summary>
        [JsonProperty("thresholds", NullValueHandling = NullValueHandling.Ignore)]
        public List<StackContainerScaleThreshold> Thresholds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Scaling : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAutoscaleGroup()
        {
            this.shouldSerialize["autoscale_group"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAutoscaleGroup()
        {
            return this.shouldSerialize["autoscale_group"];
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
            return obj is Scaling other &&                ((this.AutoscaleGroup == null && other.AutoscaleGroup == null) || (this.AutoscaleGroup?.Equals(other.AutoscaleGroup) == true)) &&
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