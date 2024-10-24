// <copyright file="ActivitySecurity.cs" company="APIMatic">
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
    /// ActivitySecurity.
    /// </summary>
    public class ActivitySecurity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitySecurity"/> class.
        /// </summary>
        public ActivitySecurity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitySecurity"/> class.
        /// </summary>
        /// <param name="risk">risk.</param>
        /// <param name="surface">surface.</param>
        /// <param name="mEvent">event.</param>
        /// <param name="attack">attack.</param>
        public ActivitySecurity(
            Models.RiskEnum risk,
            Models.SurfaceEnum surface,
            Models.EventEnum mEvent,
            Models.AttackEnum attack)
        {
            this.Risk = risk;
            this.Surface = surface;
            this.MEvent = mEvent;
            this.Attack = attack;
        }

        /// <summary>
        /// A risk level assessed by the platform. Depending on the nature of the incident, this may change even if the event type is the same.
        /// </summary>
        [JsonProperty("risk")]
        public Models.RiskEnum Risk { get; set; }

        /// <summary>
        /// From where the platform has determined this security event originated from.
        /// </summary>
        [JsonProperty("surface")]
        public Models.SurfaceEnum Surface { get; set; }

        /// <summary>
        /// How the platform has handled this security event.
        /// </summary>
        [JsonProperty("event")]
        public Models.EventEnum MEvent { get; set; }

        /// <summary>
        /// The type of attack the platform has determined has occurred.
        /// </summary>
        [JsonProperty("attack")]
        public Models.AttackEnum Attack { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ActivitySecurity : ({string.Join(", ", toStringOutput)})";
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
            return obj is ActivitySecurity other &&                this.Risk.Equals(other.Risk) &&
                this.Surface.Equals(other.Surface) &&
                this.MEvent.Equals(other.MEvent) &&
                this.Attack.Equals(other.Attack);
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
        }
    }
}