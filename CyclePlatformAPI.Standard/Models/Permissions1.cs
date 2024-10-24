// <copyright file="Permissions1.cs" company="APIMatic">
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
    /// Permissions1.
    /// </summary>
    public class Permissions1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Permissions1"/> class.
        /// </summary>
        public Permissions1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Permissions1"/> class.
        /// </summary>
        /// <param name="allEnvironments">all_environments.</param>
        /// <param name="environments">environments.</param>
        public Permissions1(
            bool allEnvironments,
            List<Models.Environment2> environments)
        {
            this.AllEnvironments = allEnvironments;
            this.Environments = environments;
        }

        /// <summary>
        /// A boolean where true represents the member has access to view and manage all environments for the resource.
        /// </summary>
        [JsonProperty("all_environments")]
        public bool AllEnvironments { get; set; }

        /// <summary>
        /// An array of environments this resource has access to.
        /// </summary>
        [JsonProperty("environments")]
        public List<Models.Environment2> Environments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Permissions1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Permissions1 other &&                this.AllEnvironments.Equals(other.AllEnvironments) &&
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