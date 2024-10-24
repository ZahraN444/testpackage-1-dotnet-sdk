// <copyright file="HubMembershipPermissions.cs" company="APIMatic">
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
    /// HubMembershipPermissions.
    /// </summary>
    public class HubMembershipPermissions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubMembershipPermissions"/> class.
        /// </summary>
        public HubMembershipPermissions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HubMembershipPermissions"/> class.
        /// </summary>
        /// <param name="allEnvironments">all_environments.</param>
        /// <param name="environments">environments.</param>
        public HubMembershipPermissions(
            bool allEnvironments,
            List<Models.Environment4> environments)
        {
            this.AllEnvironments = allEnvironments;
            this.Environments = environments;
        }

        /// <summary>
        /// A boolean where true represents the member has access to view and manage all environments for the hub.
        /// </summary>
        [JsonProperty("all_environments")]
        public bool AllEnvironments { get; set; }

        /// <summary>
        /// An array of environments this membership has access to.
        /// </summary>
        [JsonProperty("environments")]
        public List<Models.Environment4> Environments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HubMembershipPermissions : ({string.Join(", ", toStringOutput)})";
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
            return obj is HubMembershipPermissions other &&                this.AllEnvironments.Equals(other.AllEnvironments) &&
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