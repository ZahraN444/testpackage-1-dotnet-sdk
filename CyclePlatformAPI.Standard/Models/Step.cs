// <copyright file="Step.cs" company="APIMatic">
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
    /// Step.
    /// </summary>
    public class Step
    {
        private Models.Error4 error;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "error", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Step"/> class.
        /// </summary>
        public Step()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Step"/> class.
        /// </summary>
        /// <param name="identifier">identifier.</param>
        /// <param name="action">action.</param>
        /// <param name="events">events.</param>
        /// <param name="success">success.</param>
        /// <param name="error">error.</param>
        public Step(
            string identifier,
            Models.Action1Enum action,
            Models.PipelineRunEvents events,
            bool success,
            Models.Error4 error = null)
        {
            this.Identifier = identifier;
            this.Action = action;
            this.Events = events;
            this.Success = success;
            if (error != null)
            {
                this.Error = error;
            }

        }

        /// <summary>
        /// Gets or sets Identifier.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets Action.
        /// </summary>
        [JsonProperty("action")]
        public Models.Action1Enum Action { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the pipeline run's lifetime.
        /// </summary>
        [JsonProperty("events")]
        public Models.PipelineRunEvents Events { get; set; }

        /// <summary>
        /// Gets or sets Success.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// An error, if any, that has occurred for this step.
        /// </summary>
        [JsonProperty("error")]
        public Models.Error4 Error
        {
            get
            {
                return this.error;
            }

            set
            {
                this.shouldSerialize["error"] = true;
                this.error = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Step : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetError()
        {
            this.shouldSerialize["error"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeError()
        {
            return this.shouldSerialize["error"];
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
            return obj is Step other &&                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                this.Action.Equals(other.Action) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                this.Success.Equals(other.Success) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Action = {this.Action}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.Success = {this.Success}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}