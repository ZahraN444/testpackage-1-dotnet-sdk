// <copyright file="InfrastructureIPPool.cs" company="APIMatic">
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
    /// InfrastructureIPPool.
    /// </summary>
    public class InfrastructureIPPool
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureIPPool"/> class.
        /// </summary>
        public InfrastructureIPPool()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureIPPool"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="serverId">server_id.</param>
        /// <param name="locationId">location_id.</param>
        /// <param name="kind">kind.</param>
        /// <param name="provider">provider.</param>
        /// <param name="floating">floating.</param>
        /// <param name="ips">ips.</param>
        /// <param name="block">block.</param>
        /// <param name="state">state.</param>
        public InfrastructureIPPool(
            string id,
            string hubId,
            string serverId,
            string locationId,
            Models.Kind1Enum kind,
            Models.IPPoolProvider provider,
            bool floating,
            Models.Ips ips,
            Models.Block block,
            Models.PoolState state)
        {
            this.Id = id;
            this.HubId = hubId;
            this.ServerId = serverId;
            this.LocationId = locationId;
            this.Kind = kind;
            this.Provider = provider;
            this.Floating = floating;
            this.Ips = ips;
            this.Block = block;
            this.State = state;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("hub_id")]
        [JsonRequired]
        public string HubId { get; set; }

        /// <summary>
        /// An ID associated with a server resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("server_id")]
        [JsonRequired]
        public string ServerId { get; set; }

        /// <summary>
        /// An ID associated with a location resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("location_id")]
        [JsonRequired]
        public string LocationId { get; set; }

        /// <summary>
        /// The type of IP pool.
        /// </summary>
        [JsonProperty("kind")]
        [JsonRequired]
        public Models.Kind1Enum Kind { get; set; }

        /// <summary>
        /// A IP Pool provider.
        /// </summary>
        [JsonProperty("provider")]
        [JsonRequired]
        public Models.IPPoolProvider Provider { get; set; }

        /// <summary>
        /// A boolean where true represents the pool as a floating IP pool.
        /// </summary>
        [JsonProperty("floating")]
        [JsonRequired]
        public bool Floating { get; set; }

        /// <summary>
        /// Data about IPs in the pool.
        /// </summary>
        [JsonProperty("ips")]
        [JsonRequired]
        public Models.Ips Ips { get; set; }

        /// <summary>
        /// Network information about the pool.
        /// </summary>
        [JsonProperty("block")]
        [JsonRequired]
        public Models.Block Block { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.PoolState State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InfrastructureIPPool : ({string.Join(", ", toStringOutput)})";
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
            return obj is InfrastructureIPPool other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.ServerId == null && other.ServerId == null) || (this.ServerId?.Equals(other.ServerId) == true)) &&
                ((this.LocationId == null && other.LocationId == null) || (this.LocationId?.Equals(other.LocationId) == true)) &&
                this.Kind.Equals(other.Kind) &&
                ((this.Provider == null && other.Provider == null) || (this.Provider?.Equals(other.Provider) == true)) &&
                this.Floating.Equals(other.Floating) &&
                ((this.Ips == null && other.Ips == null) || (this.Ips?.Equals(other.Ips) == true)) &&
                ((this.Block == null && other.Block == null) || (this.Block?.Equals(other.Block) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.ServerId = {(this.ServerId == null ? "null" : this.ServerId)}");
            toStringOutput.Add($"this.LocationId = {(this.LocationId == null ? "null" : this.LocationId)}");
            toStringOutput.Add($"this.Kind = {this.Kind}");
            toStringOutput.Add($"this.Provider = {(this.Provider == null ? "null" : this.Provider.ToString())}");
            toStringOutput.Add($"this.Floating = {this.Floating}");
            toStringOutput.Add($"this.Ips = {(this.Ips == null ? "null" : this.Ips.ToString())}");
            toStringOutput.Add($"this.Block = {(this.Block == null ? "null" : this.Block.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
        }
    }
}