// <copyright file="PipelineRunEvents.cs" company="APIMatic">
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
    /// PipelineRunEvents.
    /// </summary>
    public class PipelineRunEvents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineRunEvents"/> class.
        /// </summary>
        public PipelineRunEvents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelineRunEvents"/> class.
        /// </summary>
        /// <param name="started">started.</param>
        /// <param name="queued">queued.</param>
        /// <param name="finished">finished.</param>
        public PipelineRunEvents(
            DateTime started,
            DateTime queued,
            DateTime finished)
        {
            this.Started = started;
            this.Queued = queued;
            this.Finished = finished;
        }

        /// <summary>
        /// The timestamp of when the pipeline run was started.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("started")]
        public DateTime Started { get; set; }

        /// <summary>
        /// The timestamp of when the pipeline run was queued.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("queued")]
        public DateTime Queued { get; set; }

        /// <summary>
        /// The timestamp of when the pipeline run was finished.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("finished")]
        public DateTime Finished { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PipelineRunEvents : ({string.Join(", ", toStringOutput)})";
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
            return obj is PipelineRunEvents other &&                this.Started.Equals(other.Started) &&
                this.Queued.Equals(other.Queued) &&
                this.Finished.Equals(other.Finished);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Started = {this.Started}");
            toStringOutput.Add($"this.Queued = {this.Queued}");
            toStringOutput.Add($"this.Finished = {this.Finished}");
        }
    }
}