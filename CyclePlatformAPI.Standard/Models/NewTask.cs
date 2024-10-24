// <copyright file="NewTask.cs" company="APIMatic">
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
    /// NewTask.
    /// </summary>
    public class NewTask
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewTask"/> class.
        /// </summary>
        public NewTask()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewTask"/> class.
        /// </summary>
        /// <param name="caption">caption.</param>
        /// <param name="header">header.</param>
        /// <param name="input">input.</param>
        /// <param name="steps">steps.</param>
        public NewTask(
            string caption,
            string header,
            object input,
            List<Models.TaskStep> steps = null)
        {
            this.Caption = caption;
            this.Header = header;
            this.Steps = steps;
            this.Input = input;
        }

        /// <summary>
        /// A short description of the task.
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }

        /// <summary>
        /// The API function called.
        /// </summary>
        [JsonProperty("header")]
        public string Header { get; set; }

        /// <summary>
        /// An array of job task steps.
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Include)]
        public List<Models.TaskStep> Steps { get; set; }

        /// <summary>
        /// Input information used for the job tasks.
        /// </summary>
        [JsonProperty("input")]
        public object Input { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NewTask : ({string.Join(", ", toStringOutput)})";
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
            return obj is NewTask other &&                ((this.Caption == null && other.Caption == null) || (this.Caption?.Equals(other.Caption) == true)) &&
                ((this.Header == null && other.Header == null) || (this.Header?.Equals(other.Header) == true)) &&
                ((this.Steps == null && other.Steps == null) || (this.Steps?.Equals(other.Steps) == true)) &&
                ((this.Input == null && other.Input == null) || (this.Input?.Equals(other.Input) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Caption = {(this.Caption == null ? "null" : this.Caption)}");
            toStringOutput.Add($"this.Header = {(this.Header == null ? "null" : this.Header)}");
            toStringOutput.Add($"this.Steps = {(this.Steps == null ? "null" : $"[{string.Join(", ", this.Steps)} ]")}");
            toStringOutput.Add($"Input = {(this.Input == null ? "null" : this.Input.ToString())}");
        }
    }
}