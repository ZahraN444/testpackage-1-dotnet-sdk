// <copyright file="VolumeGroups.cs" company="APIMatic">
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
    /// VolumeGroups.
    /// </summary>
    public class VolumeGroups
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeGroups"/> class.
        /// </summary>
        public VolumeGroups()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeGroups"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="size">size.</param>
        /// <param name="volumes">volumes.</param>
        public VolumeGroups(
            string name,
            int size,
            Dictionary<string, Models.Volumes> volumes)
        {
            this.Name = name;
            this.Size = size;
            this.Volumes = volumes;
        }

        /// <summary>
        /// A name for the volume group.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A number representing the aggregate group volume size in megabytes.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// The actual volumes.
        /// </summary>
        [JsonProperty("volumes")]
        public Dictionary<string, Models.Volumes> Volumes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VolumeGroups : ({string.Join(", ", toStringOutput)})";
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
            return obj is VolumeGroups other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                this.Size.Equals(other.Size) &&
                ((this.Volumes == null && other.Volumes == null) || (this.Volumes?.Equals(other.Volumes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Size = {this.Size}");
            toStringOutput.Add($"Volumes = {(this.Volumes == null ? "null" : this.Volumes.ToString())}");
        }
    }
}