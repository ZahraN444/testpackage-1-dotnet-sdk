// <copyright file="ServerStatsStorage.cs" company="APIMatic">
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
    /// ServerStatsStorage.
    /// </summary>
    public class ServerStatsStorage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsStorage"/> class.
        /// </summary>
        public ServerStatsStorage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsStorage"/> class.
        /// </summary>
        /// <param name="volumeGroups">volume_groups.</param>
        /// <param name="mounts">mounts.</param>
        public ServerStatsStorage(
            Dictionary<string, Models.VolumeGroups> volumeGroups,
            Dictionary<string, Models.MountedFS> mounts)
        {
            this.VolumeGroups = volumeGroups;
            this.Mounts = mounts;
        }

        /// <summary>
        /// An array of volume group objects.
        /// </summary>
        [JsonProperty("volume_groups")]
        public Dictionary<string, Models.VolumeGroups> VolumeGroups { get; set; }

        /// <summary>
        /// Records that show information about mounted filesystems where the key is the path to the mount.
        /// </summary>
        [JsonProperty("mounts")]
        public Dictionary<string, Models.MountedFS> Mounts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerStatsStorage : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerStatsStorage other &&                ((this.VolumeGroups == null && other.VolumeGroups == null) || (this.VolumeGroups?.Equals(other.VolumeGroups) == true)) &&
                ((this.Mounts == null && other.Mounts == null) || (this.Mounts?.Equals(other.Mounts) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"VolumeGroups = {(this.VolumeGroups == null ? "null" : this.VolumeGroups.ToString())}");
            toStringOutput.Add($"Mounts = {(this.Mounts == null ? "null" : this.Mounts.ToString())}");
        }
    }
}