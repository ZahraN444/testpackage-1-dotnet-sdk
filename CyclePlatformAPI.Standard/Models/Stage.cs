// <copyright file="Stage.cs" company="APIMatic">
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
    /// Stage.
    /// </summary>
    public class Stage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stage"/> class.
        /// </summary>
        public Stage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stage"/> class.
        /// </summary>
        /// <param name="identifier">identifier.</param>
        /// <param name="steps">steps.</param>
        /// <param name="events">events.</param>
        public Stage(
            string identifier,
            List<Models.Step> steps,
            Models.PipelineRunEvents events)
        {
            this.Identifier = identifier;
            this.Steps = steps;
            this.Events = events;
        }

        /// <summary>
        /// A stage identifier.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets Steps.
        /// </summary>
        [JsonProperty("steps")]
        public List<Models.Step> Steps { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the pipeline run's lifetime.
        /// </summary>
        [JsonProperty("events")]
        public Models.PipelineRunEvents Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Stage : ({string.Join(", ", toStringOutput)})";
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
            return obj is Stage other &&                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Steps == null && other.Steps == null) || (this.Steps?.Equals(other.Steps) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Steps = {(this.Steps == null ? "null" : $"[{string.Join(", ", this.Steps)} ]")}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}