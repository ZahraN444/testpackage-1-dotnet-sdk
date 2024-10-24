// <copyright file="Provisioning.cs" company="APIMatic">
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
    /// Provisioning.
    /// </summary>
    public class Provisioning
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Provisioning"/> class.
        /// </summary>
        public Provisioning()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Provisioning"/> class.
        /// </summary>
        /// <param name="started">started.</param>
        /// <param name="failed">failed.</param>
        /// <param name="completed">completed.</param>
        public Provisioning(
            DateTime started,
            DateTime failed,
            DateTime completed)
        {
            this.Started = started;
            this.Failed = failed;
            this.Completed = completed;
        }

        /// <summary>
        /// A timestamp of when the server started provisioning.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("started")]
        public DateTime Started { get; set; }

        /// <summary>
        /// A timestamp of when the server failed provisioning.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("failed")]
        public DateTime Failed { get; set; }

        /// <summary>
        /// A timestamp of when the server completed provisioning.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("completed")]
        public DateTime Completed { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Provisioning : ({string.Join(", ", toStringOutput)})";
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
            return obj is Provisioning other &&                this.Started.Equals(other.Started) &&
                this.Failed.Equals(other.Failed) &&
                this.Completed.Equals(other.Completed);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Started = {this.Started}");
            toStringOutput.Add($"this.Failed = {this.Failed}");
            toStringOutput.Add($"this.Completed = {this.Completed}");
        }
    }
}