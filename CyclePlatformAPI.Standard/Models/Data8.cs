// <copyright file="Data8.cs" company="APIMatic">
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
    /// Data8.
    /// </summary>
    public class Data8
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data8"/> class.
        /// </summary>
        public Data8()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data8"/> class.
        /// </summary>
        /// <param name="resourceDensity">resource-density.</param>
        /// <param name="highAvailability">high-availability.</param>
        /// <param name="firstAvailable">first-available.</param>
        /// <param name="node">node.</param>
        /// <param name="edge">edge.</param>
        /// <param name="manual">manual.</param>
        /// <param name="function">function.</param>
        public Data8(
            Models.DeploymentStrategy resourceDensity = null,
            Models.DeploymentStrategy highAvailability = null,
            Models.DeploymentStrategy firstAvailable = null,
            Models.DeploymentStrategy node = null,
            Models.DeploymentStrategy edge = null,
            Models.DeploymentStrategy manual = null,
            Models.DeploymentStrategy function = null)
        {
            this.ResourceDensity = resourceDensity;
            this.HighAvailability = highAvailability;
            this.FirstAvailable = firstAvailable;
            this.Node = node;
            this.Edge = edge;
            this.Manual = manual;
            this.Function = function;
        }

        /// <summary>
        /// Information about supported container deployment strategies.
        /// </summary>
        [JsonProperty("resource-density", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeploymentStrategy ResourceDensity { get; set; }

        /// <summary>
        /// Information about supported container deployment strategies.
        /// </summary>
        [JsonProperty("high-availability", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeploymentStrategy HighAvailability { get; set; }

        /// <summary>
        /// Information about supported container deployment strategies.
        /// </summary>
        [JsonProperty("first-available", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeploymentStrategy FirstAvailable { get; set; }

        /// <summary>
        /// Information about supported container deployment strategies.
        /// </summary>
        [JsonProperty("node", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeploymentStrategy Node { get; set; }

        /// <summary>
        /// Information about supported container deployment strategies.
        /// </summary>
        [JsonProperty("edge", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeploymentStrategy Edge { get; set; }

        /// <summary>
        /// Information about supported container deployment strategies.
        /// </summary>
        [JsonProperty("manual", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeploymentStrategy Manual { get; set; }

        /// <summary>
        /// Information about supported container deployment strategies.
        /// </summary>
        [JsonProperty("function", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DeploymentStrategy Function { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data8 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data8 other &&                ((this.ResourceDensity == null && other.ResourceDensity == null) || (this.ResourceDensity?.Equals(other.ResourceDensity) == true)) &&
                ((this.HighAvailability == null && other.HighAvailability == null) || (this.HighAvailability?.Equals(other.HighAvailability) == true)) &&
                ((this.FirstAvailable == null && other.FirstAvailable == null) || (this.FirstAvailable?.Equals(other.FirstAvailable) == true)) &&
                ((this.Node == null && other.Node == null) || (this.Node?.Equals(other.Node) == true)) &&
                ((this.Edge == null && other.Edge == null) || (this.Edge?.Equals(other.Edge) == true)) &&
                ((this.Manual == null && other.Manual == null) || (this.Manual?.Equals(other.Manual) == true)) &&
                ((this.Function == null && other.Function == null) || (this.Function?.Equals(other.Function) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ResourceDensity = {(this.ResourceDensity == null ? "null" : this.ResourceDensity.ToString())}");
            toStringOutput.Add($"this.HighAvailability = {(this.HighAvailability == null ? "null" : this.HighAvailability.ToString())}");
            toStringOutput.Add($"this.FirstAvailable = {(this.FirstAvailable == null ? "null" : this.FirstAvailable.ToString())}");
            toStringOutput.Add($"this.Node = {(this.Node == null ? "null" : this.Node.ToString())}");
            toStringOutput.Add($"this.Edge = {(this.Edge == null ? "null" : this.Edge.ToString())}");
            toStringOutput.Add($"this.Manual = {(this.Manual == null ? "null" : this.Manual.ToString())}");
            toStringOutput.Add($"this.Function = {(this.Function == null ? "null" : this.Function.ToString())}");
        }
    }
}