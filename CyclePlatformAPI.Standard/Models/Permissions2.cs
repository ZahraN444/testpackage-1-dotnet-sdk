// <copyright file="Permissions2.cs" company="APIMatic">
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
    /// Permissions2.
    /// </summary>
    public class Permissions2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Permissions2"/> class.
        /// </summary>
        public Permissions2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Permissions2"/> class.
        /// </summary>
        /// <param name="allEnvironments">all_environments.</param>
        /// <param name="environments">environments.</param>
        public Permissions2(
            bool allEnvironments,
            List<Models.Environment1> environments)
        {
            this.AllEnvironments = allEnvironments;
            this.Environments = environments;
        }

        /// <summary>
        /// Boolean value that indicates the user has access to all Environments
        /// </summary>
        [JsonProperty("all_environments")]
        public bool AllEnvironments { get; set; }

        /// <summary>
        /// A list of objects that describe the specific environments the invitee will have access to
        /// </summary>
        [JsonProperty("environments")]
        public List<Models.Environment1> Environments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Permissions2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Permissions2 other &&                this.AllEnvironments.Equals(other.AllEnvironments) &&
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