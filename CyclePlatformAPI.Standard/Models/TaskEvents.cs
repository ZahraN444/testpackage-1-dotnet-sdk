// <copyright file="TaskEvents.cs" company="APIMatic">
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
    /// TaskEvents.
    /// </summary>
    public class TaskEvents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskEvents"/> class.
        /// </summary>
        public TaskEvents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskEvents"/> class.
        /// </summary>
        /// <param name="queued">queued.</param>
        /// <param name="completed">completed.</param>
        /// <param name="started">started.</param>
        public TaskEvents(
            DateTime queued,
            DateTime completed,
            DateTime started)
        {
            this.Queued = queued;
            this.Completed = completed;
            this.Started = started;
        }

        /// <summary>
        /// The timestamp of when the task was queued.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("queued")]
        public DateTime Queued { get; set; }

        /// <summary>
        /// The timestamp of when the task was completed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("completed")]
        public DateTime Completed { get; set; }

        /// <summary>
        /// The timestamp of when the task was started.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("started")]
        public DateTime Started { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TaskEvents : ({string.Join(", ", toStringOutput)})";
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
            return obj is TaskEvents other &&                this.Queued.Equals(other.Queued) &&
                this.Completed.Equals(other.Completed) &&
                this.Started.Equals(other.Started);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Queued = {this.Queued}");
            toStringOutput.Add($"this.Completed = {this.Completed}");
            toStringOutput.Add($"this.Started = {this.Started}");
        }
    }
}