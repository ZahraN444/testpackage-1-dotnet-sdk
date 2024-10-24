// <copyright file="StackBuildDeploymentUpdates.cs" company="APIMatic">
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
    /// StackBuildDeploymentUpdates.
    /// </summary>
    public class StackBuildDeploymentUpdates
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackBuildDeploymentUpdates"/> class.
        /// </summary>
        public StackBuildDeploymentUpdates()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackBuildDeploymentUpdates"/> class.
        /// </summary>
        /// <param name="containers">containers.</param>
        /// <param name="scopedVariables">scoped_variables.</param>
        public StackBuildDeploymentUpdates(
            Dictionary<string, Models.StackDeployContainersObject> containers,
            Models.ScopedVariables scopedVariables = null)
        {
            this.Containers = containers;
            this.ScopedVariables = scopedVariables;
        }

        /// <summary>
        /// A map of the container names to update within the environment.
        /// </summary>
        [JsonProperty("containers")]
        [JsonRequired]
        public Dictionary<string, Models.StackDeployContainersObject> Containers { get; set; }

        /// <summary>
        /// An object that describes configuration options for scoped variables on stack build.
        /// </summary>
        [JsonProperty("scoped_variables", NullValueHandling = NullValueHandling.Include)]
        public Models.ScopedVariables ScopedVariables { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackBuildDeploymentUpdates : ({string.Join(", ", toStringOutput)})";
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
            return obj is StackBuildDeploymentUpdates other &&                ((this.Containers == null && other.Containers == null) || (this.Containers?.Equals(other.Containers) == true)) &&
                ((this.ScopedVariables == null && other.ScopedVariables == null) || (this.ScopedVariables?.Equals(other.ScopedVariables) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Containers = {(this.Containers == null ? "null" : this.Containers.ToString())}");
            toStringOutput.Add($"this.ScopedVariables = {(this.ScopedVariables == null ? "null" : this.ScopedVariables.ToString())}");
        }
    }
}