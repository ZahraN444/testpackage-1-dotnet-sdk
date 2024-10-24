// <copyright file="JobTask.cs" company="APIMatic">
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
    /// JobTask.
    /// </summary>
    public class JobTask
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobTask"/> class.
        /// </summary>
        public JobTask()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobTask"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="caption">caption.</param>
        /// <param name="header">header.</param>
        /// <param name="events">events.</param>
        /// <param name="state">state.</param>
        /// <param name="input">input.</param>
        /// <param name="steps">steps.</param>
        /// <param name="output">output.</param>
        /// <param name="error">error.</param>
        public JobTask(
            string id,
            string caption,
            string header,
            Models.TaskEvents events,
            Models.TaskState state,
            object input,
            List<Models.TaskStep> steps = null,
            Dictionary<string, string> output = null,
            Models.Error5 error = null)
        {
            this.Id = id;
            this.Caption = caption;
            this.Header = header;
            this.Events = events;
            this.Steps = steps;
            this.State = state;
            this.Input = input;
            this.Output = output;
            this.Error = error;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

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
        /// A collection of timestamps for each event in the job's lifetime.
        /// </summary>
        [JsonProperty("events")]
        public Models.TaskEvents Events { get; set; }

        /// <summary>
        /// An array of job task steps.
        /// </summary>
        [JsonProperty("steps", NullValueHandling = NullValueHandling.Include)]
        public List<Models.TaskStep> Steps { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.TaskState State { get; set; }

        /// <summary>
        /// Input information used for the job tasks.
        /// </summary>
        [JsonProperty("input")]
        public object Input { get; set; }

        /// <summary>
        /// Output informaiton used for the job tasks.
        /// </summary>
        [JsonProperty("output", NullValueHandling = NullValueHandling.Include)]
        public Dictionary<string, string> Output { get; set; }

        /// <summary>
        /// An error object describing issues with the job.
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Include)]
        public Models.Error5 Error { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"JobTask : ({string.Join(", ", toStringOutput)})";
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
            return obj is JobTask other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Caption == null && other.Caption == null) || (this.Caption?.Equals(other.Caption) == true)) &&
                ((this.Header == null && other.Header == null) || (this.Header?.Equals(other.Header) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.Steps == null && other.Steps == null) || (this.Steps?.Equals(other.Steps) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Input == null && other.Input == null) || (this.Input?.Equals(other.Input) == true)) &&
                ((this.Output == null && other.Output == null) || (this.Output?.Equals(other.Output) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Caption = {(this.Caption == null ? "null" : this.Caption)}");
            toStringOutput.Add($"this.Header = {(this.Header == null ? "null" : this.Header)}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.Steps = {(this.Steps == null ? "null" : $"[{string.Join(", ", this.Steps)} ]")}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"Input = {(this.Input == null ? "null" : this.Input.ToString())}");
            toStringOutput.Add($"Output = {(this.Output == null ? "null" : this.Output.ToString())}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}