// <copyright file="Contents6.cs" company="APIMatic">
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
    /// Contents6.
    /// </summary>
    public class Contents6
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contents6"/> class.
        /// </summary>
        public Contents6()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contents6"/> class.
        /// </summary>
        /// <param name="sftp">sftp.</param>
        /// <param name="baseVolumeGb">base_volume_gb.</param>
        public Contents6(
            bool sftp,
            int? baseVolumeGb = null)
        {
            this.Sftp = sftp;
            this.BaseVolumeGb = baseVolumeGb;
        }

        /// <summary>
        /// A boolean where true represents the desire for the server to accept incoming SFTP requests for container volumes.
        /// </summary>
        [JsonProperty("sftp")]
        public bool Sftp { get; set; }

        /// <summary>
        /// A number in GB for how big the base volume should be.  This cannot be lower than the currently set value for the server.
        /// </summary>
        [JsonProperty("base_volume_gb", NullValueHandling = NullValueHandling.Include)]
        public int? BaseVolumeGb { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Contents6 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Contents6 other &&                this.Sftp.Equals(other.Sftp) &&
                ((this.BaseVolumeGb == null && other.BaseVolumeGb == null) || (this.BaseVolumeGb?.Equals(other.BaseVolumeGb) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Sftp = {this.Sftp}");
            toStringOutput.Add($"this.BaseVolumeGb = {(this.BaseVolumeGb == null ? "null" : this.BaseVolumeGb.ToString())}");
        }
    }
}