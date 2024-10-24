// <copyright file="ContainerState.cs" company="APIMatic">
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
    /// ContainerState.
    /// </summary>
    public class ContainerState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerState"/> class.
        /// </summary>
        public ContainerState()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerState"/> class.
        /// </summary>
        /// <param name="current">current.</param>
        /// <param name="changed">changed.</param>
        /// <param name="desired">desired.</param>
        /// <param name="error">error.</param>
        public ContainerState(
            Models.Current11Enum current,
            DateTime changed,
            Models.DesiredEnum? desired = null,
            Models.Error1 error = null)
        {
            this.Current = current;
            this.Desired = desired;
            this.Changed = changed;
            this.Error = error;
        }

        /// <summary>
        /// The current state of the container.
        /// </summary>
        [JsonProperty("current")]
        public Models.Current11Enum Current { get; set; }

        /// <summary>
        /// The desired state of the container.
        /// </summary>
        [JsonProperty("desired", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DesiredEnum? Desired { get; set; }

        /// <summary>
        /// Gets or sets Changed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("changed")]
        public DateTime Changed { get; set; }

        /// <summary>
        /// An error, if any, that has occurred for this resource.
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Error1 Error { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContainerState : ({string.Join(", ", toStringOutput)})";
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
            return obj is ContainerState other &&                this.Current.Equals(other.Current) &&
                ((this.Desired == null && other.Desired == null) || (this.Desired?.Equals(other.Desired) == true)) &&
                this.Changed.Equals(other.Changed) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Current = {this.Current}");
            toStringOutput.Add($"this.Desired = {(this.Desired == null ? "null" : this.Desired.ToString())}");
            toStringOutput.Add($"this.Changed = {this.Changed}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}