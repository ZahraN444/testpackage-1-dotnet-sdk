// <copyright file="DeploymentStrategy.cs" company="APIMatic">
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
    /// DeploymentStrategy.
    /// </summary>
    public class DeploymentStrategy
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentStrategy"/> class.
        /// </summary>
        public DeploymentStrategy()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentStrategy"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="disabled">disabled.</param>
        /// <param name="description">description.</param>
        public DeploymentStrategy(
            string name,
            bool disabled,
            string description)
        {
            this.Name = name;
            this.Disabled = disabled;
            this.Description = description;
        }

        /// <summary>
        /// The human-friendly name of the deployment strategy.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A boolean where true signifies a strategy is either not yet or no longer available.
        /// </summary>
        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        /// <summary>
        /// A description for the deployment strategy.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DeploymentStrategy : ({string.Join(", ", toStringOutput)})";
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
            return obj is DeploymentStrategy other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                this.Disabled.Equals(other.Disabled) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Disabled = {this.Disabled}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
        }
    }
}