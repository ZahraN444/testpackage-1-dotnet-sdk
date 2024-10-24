// <copyright file="StackSpecServices.cs" company="APIMatic">
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
    /// StackSpecServices.
    /// </summary>
    public class StackSpecServices
    {
        private Models.Discovery2 discovery;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "discovery", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="StackSpecServices"/> class.
        /// </summary>
        public StackSpecServices()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackSpecServices"/> class.
        /// </summary>
        /// <param name="discovery">discovery.</param>
        /// <param name="loadbalancer">loadbalancer.</param>
        /// <param name="vpn">vpn.</param>
        public StackSpecServices(
            Models.Discovery2 discovery = null,
            StackSpecServicesLoadbalancer loadbalancer = null,
            Models.Vpn2 vpn = null)
        {
            if (discovery != null)
            {
                this.Discovery = discovery;
            }

            this.Loadbalancer = loadbalancer;
            this.Vpn = vpn;
        }

        /// <summary>
        /// Gets or sets Discovery.
        /// </summary>
        [JsonProperty("discovery")]
        public Models.Discovery2 Discovery
        {
            get
            {
                return this.discovery;
            }

            set
            {
                this.shouldSerialize["discovery"] = true;
                this.discovery = value;
            }
        }

        /// <summary>
        /// Gets or sets Loadbalancer.
        /// </summary>
        [JsonProperty("loadbalancer", NullValueHandling = NullValueHandling.Ignore)]
        public StackSpecServicesLoadbalancer Loadbalancer { get; set; }

        /// <summary>
        /// Gets or sets Vpn.
        /// </summary>
        [JsonProperty("vpn", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Vpn2 Vpn { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackSpecServices : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDiscovery()
        {
            this.shouldSerialize["discovery"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDiscovery()
        {
            return this.shouldSerialize["discovery"];
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
            return obj is StackSpecServices other &&                ((this.Discovery == null && other.Discovery == null) || (this.Discovery?.Equals(other.Discovery) == true)) &&
                ((this.Loadbalancer == null && other.Loadbalancer == null) || (this.Loadbalancer?.Equals(other.Loadbalancer) == true)) &&
                ((this.Vpn == null && other.Vpn == null) || (this.Vpn?.Equals(other.Vpn) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Discovery = {(this.Discovery == null ? "null" : this.Discovery.ToString())}");
            toStringOutput.Add($"Loadbalancer = {(this.Loadbalancer == null ? "null" : this.Loadbalancer.ToString())}");
            toStringOutput.Add($"this.Vpn = {(this.Vpn == null ? "null" : this.Vpn.ToString())}");
        }
    }
}