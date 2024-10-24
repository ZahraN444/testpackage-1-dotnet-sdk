// <copyright file="EnvironmentSummary.cs" company="APIMatic">
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
    /// EnvironmentSummary.
    /// </summary>
    public class EnvironmentSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentSummary"/> class.
        /// </summary>
        public EnvironmentSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentSummary"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="state">state.</param>
        /// <param name="services">services.</param>
        /// <param name="stats">stats.</param>
        public EnvironmentSummary(
            string id,
            Models.EnvironmentState state,
            Models.EnvironmentServiceSummary services,
            Models.EnvironmentSummaryStats stats)
        {
            this.Id = id;
            this.State = state;
            this.Services = services;
            this.Stats = stats;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.EnvironmentState State { get; set; }

        /// <summary>
        /// An object containing information about the service containers associated with this container. Each key is the name of a service, one of `discovery`, `vpn`, or `loadbalancer`.
        /// </summary>
        [JsonProperty("services")]
        public Models.EnvironmentServiceSummary Services { get; set; }

        /// <summary>
        /// Statistics about the containers and instances associated with this environment.
        /// </summary>
        [JsonProperty("stats")]
        public Models.EnvironmentSummaryStats Stats { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EnvironmentSummary : ({string.Join(", ", toStringOutput)})";
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
            return obj is EnvironmentSummary other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Services == null && other.Services == null) || (this.Services?.Equals(other.Services) == true)) &&
                ((this.Stats == null && other.Stats == null) || (this.Stats?.Equals(other.Stats) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Services = {(this.Services == null ? "null" : this.Services.ToString())}");
            toStringOutput.Add($"this.Stats = {(this.Stats == null ? "null" : this.Stats.ToString())}");
        }
    }
}