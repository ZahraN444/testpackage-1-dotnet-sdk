// <copyright file="JobState.cs" company="APIMatic">
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
    /// JobState.
    /// </summary>
    public class JobState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobState"/> class.
        /// </summary>
        public JobState()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobState"/> class.
        /// </summary>
        /// <param name="current">current.</param>
        /// <param name="changed">changed.</param>
        /// <param name="error">error.</param>
        public JobState(
            Models.Current34Enum current,
            DateTime? changed = null,
            Models.Error6 error = null)
        {
            this.Current = current;
            this.Changed = changed;
            this.Error = error;
        }

        /// <summary>
        /// The current state of the job.
        /// </summary>
        [JsonProperty("current")]
        public Models.Current34Enum Current { get; set; }

        /// <summary>
        /// Gets or sets Changed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("changed", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Changed { get; set; }

        /// <summary>
        /// An error, if any, that has occurred for this job.
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Include)]
        public Models.Error6 Error { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"JobState : ({string.Join(", ", toStringOutput)})";
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
            return obj is JobState other &&                this.Current.Equals(other.Current) &&
                ((this.Changed == null && other.Changed == null) || (this.Changed?.Equals(other.Changed) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Current = {this.Current}");
            toStringOutput.Add($"this.Changed = {(this.Changed == null ? "null" : this.Changed.ToString())}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}