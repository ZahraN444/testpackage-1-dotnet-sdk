// <copyright file="PipelineStage.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// PipelineStage.
    /// </summary>
    public class PipelineStage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineStage"/> class.
        /// </summary>
        public PipelineStage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineStage"/> class.
        /// </summary>
        /// <param name="identifier">identifier.</param>
        /// <param name="steps">steps.</param>
        /// <param name="options">options.</param>
        public PipelineStage(
            string identifier,
            List<PipelineSteps> steps,
            Models.Options33 options = null)
        {
            this.Identifier = identifier;
            this.Steps = steps;
            this.Options = options;
        }

        /// <summary>
        /// A stage identifier.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// An array of steps for the stage.
        /// </summary>
        [JsonProperty("steps")]
        public List<PipelineSteps> Steps { get; set; }

        /// <summary>
        /// Additonal options for the stage.
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Options33 Options { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PipelineStage : ({string.Join(", ", toStringOutput)})";
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
            return obj is PipelineStage other &&                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Steps == null && other.Steps == null) || (this.Steps?.Equals(other.Steps) == true)) &&
                ((this.Options == null && other.Options == null) || (this.Options?.Equals(other.Options) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"Steps = {(this.Steps == null ? "null" : this.Steps.ToString())}");
            toStringOutput.Add($"this.Options = {(this.Options == null ? "null" : this.Options.ToString())}");
        }
    }
}