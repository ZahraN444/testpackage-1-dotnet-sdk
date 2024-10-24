// <copyright file="VolumeSummary.cs" company="APIMatic">
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
    /// VolumeSummary.
    /// </summary>
    public class VolumeSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSummary"/> class.
        /// </summary>
        public VolumeSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeSummary"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hash">hash.</param>
        /// <param name="config">config.</param>
        public VolumeSummary(
            string id,
            string hash,
            Models.ContainerVolume config)
        {
            this.Id = id;
            this.Hash = hash;
            this.Config = config;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// A unique hash for the given volume.
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Configuration settings for container volumes.
        /// </summary>
        [JsonProperty("config")]
        public Models.ContainerVolume Config { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VolumeSummary : ({string.Join(", ", toStringOutput)})";
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
            return obj is VolumeSummary other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Hash == null && other.Hash == null) || (this.Hash?.Equals(other.Hash) == true)) &&
                ((this.Config == null && other.Config == null) || (this.Config?.Equals(other.Config) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Hash = {(this.Hash == null ? "null" : this.Hash)}");
            toStringOutput.Add($"this.Config = {(this.Config == null ? "null" : this.Config.ToString())}");
        }
    }
}