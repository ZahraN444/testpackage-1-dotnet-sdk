// <copyright file="ActivityMonitor.cs" company="APIMatic">
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
    /// ActivityMonitor.
    /// </summary>
    public class ActivityMonitor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityMonitor"/> class.
        /// </summary>
        public ActivityMonitor()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityMonitor"/> class.
        /// </summary>
        /// <param name="level">level.</param>
        /// <param name="mEvent">event.</param>
        /// <param name="state">state.</param>
        public ActivityMonitor(
            Models.LevelEnum level,
            Models.Event1Enum mEvent,
            Models.State8Enum state)
        {
            this.Level = level;
            this.MEvent = mEvent;
            this.State = state;
        }

        /// <summary>
        /// The severity of the event.
        /// </summary>
        [JsonProperty("level")]
        public Models.LevelEnum Level { get; set; }

        /// <summary>
        /// How the platform has handled this monitor event.
        /// </summary>
        [JsonProperty("event")]
        public Models.Event1Enum MEvent { get; set; }

        /// <summary>
        /// The current state of the monitored resource
        /// </summary>
        [JsonProperty("state")]
        public Models.State8Enum State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ActivityMonitor : ({string.Join(", ", toStringOutput)})";
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
            return obj is ActivityMonitor other &&                this.Level.Equals(other.Level) &&
                this.MEvent.Equals(other.MEvent) &&
                this.State.Equals(other.State);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Level = {this.Level}");
            toStringOutput.Add($"this.MEvent = {this.MEvent}");
            toStringOutput.Add($"this.State = {this.State}");
        }
    }
}