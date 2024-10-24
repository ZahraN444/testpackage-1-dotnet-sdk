// <copyright file="ContainersMeta.cs" company="APIMatic">
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
    /// ContainersMeta.
    /// </summary>
    public class ContainersMeta
    {
        private List<Models.Domain> domains;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "domains", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainersMeta"/> class.
        /// </summary>
        public ContainersMeta()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainersMeta"/> class.
        /// </summary>
        /// <param name="instancesCount">instances_count.</param>
        /// <param name="domains">domains.</param>
        /// <param name="ips">ips.</param>
        public ContainersMeta(
            Models.ResourceCountSummary instancesCount = null,
            List<Models.Domain> domains = null,
            List<Models.IP> ips = null)
        {
            this.InstancesCount = instancesCount;
            if (domains != null)
            {
                this.Domains = domains;
            }

            this.Ips = ips;
        }

        /// <summary>
        /// A summary of resources by state
        /// </summary>
        [JsonProperty("instances_count", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResourceCountSummary InstancesCount { get; set; }

        /// <summary>
        /// Gets or sets Domains.
        /// </summary>
        [JsonProperty("domains")]
        public List<Models.Domain> Domains
        {
            get
            {
                return this.domains;
            }

            set
            {
                this.shouldSerialize["domains"] = true;
                this.domains = value;
            }
        }

        /// <summary>
        /// An array of IP resources.
        /// </summary>
        [JsonProperty("ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.IP> Ips { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContainersMeta : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDomains()
        {
            this.shouldSerialize["domains"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDomains()
        {
            return this.shouldSerialize["domains"];
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
            return obj is ContainersMeta other &&                ((this.InstancesCount == null && other.InstancesCount == null) || (this.InstancesCount?.Equals(other.InstancesCount) == true)) &&
                ((this.Domains == null && other.Domains == null) || (this.Domains?.Equals(other.Domains) == true)) &&
                ((this.Ips == null && other.Ips == null) || (this.Ips?.Equals(other.Ips) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InstancesCount = {(this.InstancesCount == null ? "null" : this.InstancesCount.ToString())}");
            toStringOutput.Add($"this.Domains = {(this.Domains == null ? "null" : $"[{string.Join(", ", this.Domains)} ]")}");
            toStringOutput.Add($"this.Ips = {(this.Ips == null ? "null" : $"[{string.Join(", ", this.Ips)} ]")}");
        }
    }
}