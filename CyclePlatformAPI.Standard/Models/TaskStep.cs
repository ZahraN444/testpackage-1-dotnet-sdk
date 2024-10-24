// <copyright file="TaskStep.cs" company="APIMatic">
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
    /// TaskStep.
    /// </summary>
    public class TaskStep
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskStep"/> class.
        /// </summary>
        public TaskStep()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskStep"/> class.
        /// </summary>
        /// <param name="caption">caption.</param>
        /// <param name="description">description.</param>
        /// <param name="started">started.</param>
        /// <param name="completed">completed.</param>
        public TaskStep(
            string caption,
            string description,
            DateTime started,
            DateTime completed)
        {
            this.Caption = caption;
            this.Description = description;
            this.Started = started;
            this.Completed = completed;
        }

        /// <summary>
        /// A short description of the step.
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }

        /// <summary>
        /// A more verbose description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A timestamp for when the step started.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("started")]
        public DateTime Started { get; set; }

        /// <summary>
        /// A timestamp for when the step completed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("completed")]
        public DateTime Completed { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TaskStep : ({string.Join(", ", toStringOutput)})";
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
            return obj is TaskStep other &&                ((this.Caption == null && other.Caption == null) || (this.Caption?.Equals(other.Caption) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                this.Started.Equals(other.Started) &&
                this.Completed.Equals(other.Completed);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Caption = {(this.Caption == null ? "null" : this.Caption)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Started = {this.Started}");
            toStringOutput.Add($"this.Completed = {this.Completed}");
        }
    }
}