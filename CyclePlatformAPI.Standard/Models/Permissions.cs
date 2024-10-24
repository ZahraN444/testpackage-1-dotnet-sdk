// <copyright file="Permissions.cs" company="APIMatic">
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
    /// Permissions.
    /// </summary>
    public class Permissions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Permissions"/> class.
        /// </summary>
        public Permissions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Permissions"/> class.
        /// </summary>
        /// <param name="allEnvironments">all_environments.</param>
        /// <param name="environments">environments.</param>
        public Permissions(
            bool allEnvironments,
            List<Models.EnvironmentPermission> environments)
        {
            this.AllEnvironments = allEnvironments;
            this.Environments = environments;
        }

        /// <summary>
        /// A boolean, where true represents this API key is authorized to make requests that involve all of a hubs environments
        /// </summary>
        [JsonProperty("all_environments")]
        public bool AllEnvironments { get; set; }

        /// <summary>
        /// An environment ID and a boolean representing management configuration for an API key
        /// </summary>
        [JsonProperty("environments")]
        public List<Models.EnvironmentPermission> Environments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Permissions : ({string.Join(", ", toStringOutput)})";
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
            return obj is Permissions other &&                this.AllEnvironments.Equals(other.AllEnvironments) &&
                ((this.Environments == null && other.Environments == null) || (this.Environments?.Equals(other.Environments) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AllEnvironments = {this.AllEnvironments}");
            toStringOutput.Add($"this.Environments = {(this.Environments == null ? "null" : $"[{string.Join(", ", this.Environments)} ]")}");
        }
    }
}