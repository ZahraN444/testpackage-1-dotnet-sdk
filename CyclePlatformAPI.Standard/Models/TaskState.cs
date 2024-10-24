// <copyright file="TaskState.cs" company="APIMatic">
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
    /// TaskState.
    /// </summary>
    public class TaskState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskState"/> class.
        /// </summary>
        public TaskState()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskState"/> class.
        /// </summary>
        /// <param name="changed">changed.</param>
        /// <param name="current">current.</param>
        public TaskState(
            DateTime? changed = null,
            Models.Current33Enum? current = null)
        {
            this.Changed = changed;
            this.Current = current;
        }

        /// <summary>
        /// Gets or sets Changed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("changed", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Changed { get; set; }

        /// <summary>
        /// The current state of the task.
        /// </summary>
        [JsonProperty("current", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Current33Enum? Current { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TaskState : ({string.Join(", ", toStringOutput)})";
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
            return obj is TaskState other &&                ((this.Changed == null && other.Changed == null) || (this.Changed?.Equals(other.Changed) == true)) &&
                ((this.Current == null && other.Current == null) || (this.Current?.Equals(other.Current) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Changed = {(this.Changed == null ? "null" : this.Changed.ToString())}");
            toStringOutput.Add($"this.Current = {(this.Current == null ? "null" : this.Current.ToString())}");
        }
    }
}