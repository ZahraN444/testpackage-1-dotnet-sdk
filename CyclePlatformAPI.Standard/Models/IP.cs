// <copyright file="IP.cs" company="APIMatic">
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
    /// IP.
    /// </summary>
    public class IP
    {
        private Models.Assignment assignment;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "assignment", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="IP"/> class.
        /// </summary>
        public IP()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IP"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="kind">kind.</param>
        /// <param name="poolId">pool_id.</param>
        /// <param name="address">address.</param>
        /// <param name="gateway">gateway.</param>
        /// <param name="cidr">cidr.</param>
        /// <param name="state">state.</param>
        /// <param name="assignment">assignment.</param>
        public IP(
            string id,
            string hubId,
            Models.KindEnum kind,
            string poolId,
            string address,
            string gateway,
            string cidr,
            Models.IpState state,
            Models.Assignment assignment = null)
        {
            this.Id = id;
            this.HubId = hubId;
            this.Kind = kind;
            if (assignment != null)
            {
                this.Assignment = assignment;
            }

            this.PoolId = poolId;
            this.Address = address;
            this.Gateway = gateway;
            this.Cidr = cidr;
            this.State = state;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonProperty("hub_id")]
        public string HubId { get; set; }

        /// <summary>
        /// The type of IP protocol this IP is.
        /// </summary>
        [JsonProperty("kind")]
        public Models.KindEnum Kind { get; set; }

        /// <summary>
        /// Information about the assignment of this IP.
        /// </summary>
        [JsonProperty("assignment")]
        public Models.Assignment Assignment
        {
            get
            {
                return this.assignment;
            }

            set
            {
                this.shouldSerialize["assignment"] = true;
                this.assignment = value;
            }
        }

        /// <summary>
        /// A unique identifier that associates the IP with an IP pool.
        /// </summary>
        [JsonProperty("pool_id")]
        public string PoolId { get; set; }

        /// <summary>
        /// The IP address.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// The IP gateway.
        /// </summary>
        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        /// <summary>
        /// The CIDR for the IP.
        /// </summary>
        [JsonProperty("cidr")]
        public string Cidr { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.IpState State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IP : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAssignment()
        {
            this.shouldSerialize["assignment"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAssignment()
        {
            return this.shouldSerialize["assignment"];
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
            return obj is IP other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                this.Kind.Equals(other.Kind) &&
                ((this.Assignment == null && other.Assignment == null) || (this.Assignment?.Equals(other.Assignment) == true)) &&
                ((this.PoolId == null && other.PoolId == null) || (this.PoolId?.Equals(other.PoolId) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Gateway == null && other.Gateway == null) || (this.Gateway?.Equals(other.Gateway) == true)) &&
                ((this.Cidr == null && other.Cidr == null) || (this.Cidr?.Equals(other.Cidr) == true)) &&
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
            toStringOutput.Add($"this.Kind = {this.Kind}");
            toStringOutput.Add($"this.Assignment = {(this.Assignment == null ? "null" : this.Assignment.ToString())}");
            toStringOutput.Add($"this.PoolId = {(this.PoolId == null ? "null" : this.PoolId)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address)}");
            toStringOutput.Add($"this.Gateway = {(this.Gateway == null ? "null" : this.Gateway)}");
            toStringOutput.Add($"this.Cidr = {(this.Cidr == null ? "null" : this.Cidr)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
        }
    }
}