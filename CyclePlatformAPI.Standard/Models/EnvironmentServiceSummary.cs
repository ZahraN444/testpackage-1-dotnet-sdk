// <copyright file="EnvironmentServiceSummary.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// EnvironmentServiceSummary.
    /// </summary>
    public class EnvironmentServiceSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentServiceSummary"/> class.
        /// </summary>
        public EnvironmentServiceSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentServiceSummary"/> class.
        /// </summary>
        /// <param name="loadbalancer">loadbalancer.</param>
        /// <param name="discovery">discovery.</param>
        /// <param name="vpn">vpn.</param>
        /// <param name="scheduler">scheduler.</param>
        public EnvironmentServiceSummary(
            EnvironmentServiceSummaryLoadbalancer loadbalancer = null,
            EnvironmentServiceSummaryDiscovery discovery = null,
            EnvironmentServiceSummaryVpn vpn = null,
            EnvironmentServiceSummaryScheduler scheduler = null)
        {
            this.Loadbalancer = loadbalancer;
            this.Discovery = discovery;
            this.Vpn = vpn;
            this.Scheduler = scheduler;
        }

        /// <summary>
        /// Gets or sets Loadbalancer.
        /// </summary>
        [JsonProperty("loadbalancer", NullValueHandling = NullValueHandling.Ignore)]
        public EnvironmentServiceSummaryLoadbalancer Loadbalancer { get; set; }

        /// <summary>
        /// Gets or sets Discovery.
        /// </summary>
        [JsonProperty("discovery", NullValueHandling = NullValueHandling.Ignore)]
        public EnvironmentServiceSummaryDiscovery Discovery { get; set; }

        /// <summary>
        /// Gets or sets Vpn.
        /// </summary>
        [JsonProperty("vpn", NullValueHandling = NullValueHandling.Ignore)]
        public EnvironmentServiceSummaryVpn Vpn { get; set; }

        /// <summary>
        /// Gets or sets Scheduler.
        /// </summary>
        [JsonProperty("scheduler", NullValueHandling = NullValueHandling.Ignore)]
        public EnvironmentServiceSummaryScheduler Scheduler { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EnvironmentServiceSummary : ({string.Join(", ", toStringOutput)})";
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
            return obj is EnvironmentServiceSummary other &&                ((this.Loadbalancer == null && other.Loadbalancer == null) || (this.Loadbalancer?.Equals(other.Loadbalancer) == true)) &&
                ((this.Discovery == null && other.Discovery == null) || (this.Discovery?.Equals(other.Discovery) == true)) &&
                ((this.Vpn == null && other.Vpn == null) || (this.Vpn?.Equals(other.Vpn) == true)) &&
                ((this.Scheduler == null && other.Scheduler == null) || (this.Scheduler?.Equals(other.Scheduler) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Loadbalancer = {(this.Loadbalancer == null ? "null" : this.Loadbalancer.ToString())}");
            toStringOutput.Add($"Discovery = {(this.Discovery == null ? "null" : this.Discovery.ToString())}");
            toStringOutput.Add($"Vpn = {(this.Vpn == null ? "null" : this.Vpn.ToString())}");
            toStringOutput.Add($"Scheduler = {(this.Scheduler == null ? "null" : this.Scheduler.ToString())}");
        }
    }
}