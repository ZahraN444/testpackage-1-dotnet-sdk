// <copyright file="ServerFeatures.cs" company="APIMatic">
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
    /// ServerFeatures.
    /// </summary>
    public class ServerFeatures
    {
        private int? baseVolumeGb;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "base_volume_gb", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerFeatures"/> class.
        /// </summary>
        public ServerFeatures()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerFeatures"/> class.
        /// </summary>
        /// <param name="sftp">sftp.</param>
        /// <param name="baseVolumeGb">base_volume_gb.</param>
        public ServerFeatures(
            bool sftp,
            int? baseVolumeGb = null)
        {
            this.Sftp = sftp;
            if (baseVolumeGb != null)
            {
                this.BaseVolumeGb = baseVolumeGb;
            }

        }

        /// <summary>
        /// A boolean where true means the server accepts incoming SFTP connections through the remote volume integration.
        /// </summary>
        [JsonProperty("sftp")]
        public bool Sftp { get; set; }

        /// <summary>
        /// The size of the base volume (where Cycle stores container images on this server).
        /// </summary>
        [JsonProperty("base_volume_gb")]
        public int? BaseVolumeGb
        {
            get
            {
                return this.baseVolumeGb;
            }

            set
            {
                this.shouldSerialize["base_volume_gb"] = true;
                this.baseVolumeGb = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerFeatures : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBaseVolumeGb()
        {
            this.shouldSerialize["base_volume_gb"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBaseVolumeGb()
        {
            return this.shouldSerialize["base_volume_gb"];
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
            return obj is ServerFeatures other &&                this.Sftp.Equals(other.Sftp) &&
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