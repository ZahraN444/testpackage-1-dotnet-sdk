// <copyright file="NetworkServerSpec.cs" company="APIMatic">
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
    /// NetworkServerSpec.
    /// </summary>
    public class NetworkServerSpec
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkServerSpec"/> class.
        /// </summary>
        public NetworkServerSpec()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkServerSpec"/> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="scope">scope.</param>
        /// <param name="throughput">throughput.</param>
        /// <param name="type">type.</param>
        public NetworkServerSpec(
            int count,
            Models.Scope1Enum scope,
            int throughput,
            string type)
        {
            this.Count = count;
            this.Scope = scope;
            this.Throughput = throughput;
            this.Type = type;
        }

        /// <summary>
        /// The number of network resources for a given server.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// The scope of the interfaces.
        /// </summary>
        [JsonProperty("scope")]
        public Models.Scope1Enum Scope { get; set; }

        /// <summary>
        /// The network throughput in MB(per second).
        /// </summary>
        [JsonProperty("throughput")]
        public int Throughput { get; set; }

        /// <summary>
        /// The type of the NIC.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NetworkServerSpec : ({string.Join(", ", toStringOutput)})";
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
            return obj is NetworkServerSpec other &&                this.Count.Equals(other.Count) &&
                this.Scope.Equals(other.Scope) &&
                this.Throughput.Equals(other.Throughput) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Count = {this.Count}");
            toStringOutput.Add($"this.Scope = {this.Scope}");
            toStringOutput.Add($"this.Throughput = {this.Throughput}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}