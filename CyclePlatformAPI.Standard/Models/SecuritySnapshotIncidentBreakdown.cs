// <copyright file="SecuritySnapshotIncidentBreakdown.cs" company="APIMatic">
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
    /// SecuritySnapshotIncidentBreakdown.
    /// </summary>
    public class SecuritySnapshotIncidentBreakdown
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySnapshotIncidentBreakdown"/> class.
        /// </summary>
        public SecuritySnapshotIncidentBreakdown()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySnapshotIncidentBreakdown"/> class.
        /// </summary>
        /// <param name="surface">surface.</param>
        /// <param name="attack">attack.</param>
        public SecuritySnapshotIncidentBreakdown(
            Models.Surface2 surface,
            Models.Attack2 attack)
        {
            this.Surface = surface;
            this.Attack = attack;
        }

        /// <summary>
        /// Gets or sets Surface.
        /// </summary>
        [JsonProperty("surface")]
        public Models.Surface2 Surface { get; set; }

        /// <summary>
        /// Gets or sets Attack.
        /// </summary>
        [JsonProperty("attack")]
        public Models.Attack2 Attack { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SecuritySnapshotIncidentBreakdown : ({string.Join(", ", toStringOutput)})";
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
            return obj is SecuritySnapshotIncidentBreakdown other &&                ((this.Surface == null && other.Surface == null) || (this.Surface?.Equals(other.Surface) == true)) &&
                ((this.Attack == null && other.Attack == null) || (this.Attack?.Equals(other.Attack) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Surface = {(this.Surface == null ? "null" : this.Surface.ToString())}");
            toStringOutput.Add($"this.Attack = {(this.Attack == null ? "null" : this.Attack.ToString())}");
        }
    }
}