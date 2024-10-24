// <copyright file="JobDescriptor.cs" company="APIMatic">
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
    /// JobDescriptor.
    /// </summary>
    public class JobDescriptor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobDescriptor"/> class.
        /// </summary>
        public JobDescriptor()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobDescriptor"/> class.
        /// </summary>
        /// <param name="action">action.</param>
        /// <param name="job">job.</param>
        public JobDescriptor(
            string action,
            Models.Job2 job = null)
        {
            this.Action = action;
            this.Job = job;
        }

        /// <summary>
        /// The action that was taken.
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// Contains some basic information about the job associated with this task.
        /// </summary>
        [JsonProperty("job", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Job2 Job { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"JobDescriptor : ({string.Join(", ", toStringOutput)})";
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
            return obj is JobDescriptor other &&                ((this.Action == null && other.Action == null) || (this.Action?.Equals(other.Action) == true)) &&
                ((this.Job == null && other.Job == null) || (this.Job?.Equals(other.Job) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Action = {(this.Action == null ? "null" : this.Action)}");
            toStringOutput.Add($"this.Job = {(this.Job == null ? "null" : this.Job.ToString())}");
        }
    }
}