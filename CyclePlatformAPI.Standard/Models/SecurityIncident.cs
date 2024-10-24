// <copyright file="SecurityIncident.cs" company="APIMatic">
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
    /// SecurityIncident.
    /// </summary>
    public class SecurityIncident
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityIncident"/> class.
        /// </summary>
        public SecurityIncident()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityIncident"/> class.
        /// </summary>
        /// <param name="risk">risk.</param>
        /// <param name="surface">surface.</param>
        /// <param name="mEvent">event.</param>
        /// <param name="attack">attack.</param>
        /// <param name="count">count.</param>
        public SecurityIncident(
            Models.Risk1Enum risk,
            Models.Surface1Enum surface,
            Models.Event3Enum mEvent,
            Models.Attack1Enum attack,
            int count)
        {
            this.Risk = risk;
            this.Surface = surface;
            this.MEvent = mEvent;
            this.Attack = attack;
            this.Count = count;
        }

        /// <summary>
        /// The risk level of the security.
        /// </summary>
        [JsonProperty("risk")]
        public Models.Risk1Enum Risk { get; set; }

        /// <summary>
        /// The vector of attack.
        /// </summary>
        [JsonProperty("surface")]
        public Models.Surface1Enum Surface { get; set; }

        /// <summary>
        /// How the platform handled the event.
        /// </summary>
        [JsonProperty("event")]
        public Models.Event3Enum MEvent { get; set; }

        /// <summary>
        /// The type of attack detected.
        /// </summary>
        [JsonProperty("attack")]
        public Models.Attack1Enum Attack { get; set; }

        /// <summary>
        /// Gets or sets Count.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SecurityIncident : ({string.Join(", ", toStringOutput)})";
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
            return obj is SecurityIncident other &&                this.Risk.Equals(other.Risk) &&
                this.Surface.Equals(other.Surface) &&
                this.MEvent.Equals(other.MEvent) &&
                this.Attack.Equals(other.Attack) &&
                this.Count.Equals(other.Count);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Risk = {this.Risk}");
            toStringOutput.Add($"this.Surface = {this.Surface}");
            toStringOutput.Add($"this.MEvent = {this.MEvent}");
            toStringOutput.Add($"this.Attack = {this.Attack}");
            toStringOutput.Add($"this.Count = {this.Count}");
        }
    }
}