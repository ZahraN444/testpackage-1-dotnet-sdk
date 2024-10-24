// <copyright file="Data3.cs" company="APIMatic">
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
    /// Data3.
    /// </summary>
    public class Data3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data3"/> class.
        /// </summary>
        public Data3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data3"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="state">state.</param>
        /// <param name="stats">stats.</param>
        public Data3(
            string id,
            Models.ContainerState state,
            Data3Stats stats = null)
        {
            this.Id = id;
            this.State = state;
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
        public Models.ContainerState State { get; set; }

        /// <summary>
        /// Gets or sets Stats.
        /// </summary>
        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public Data3Stats Stats { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Data3 other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
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
            toStringOutput.Add($"Stats = {(this.Stats == null ? "null" : this.Stats.ToString())}");
        }
    }
}