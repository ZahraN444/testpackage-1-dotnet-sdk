// <copyright file="ContainerVolume.cs" company="APIMatic">
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
    /// ContainerVolume.
    /// </summary>
    public class ContainerVolume
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerVolume"/> class.
        /// </summary>
        public ContainerVolume()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerVolume"/> class.
        /// </summary>
        /// <param name="readOnly">read_only.</param>
        /// <param name="destination">destination.</param>
        /// <param name="local">local.</param>
        /// <param name="remoteAccess">remote_access.</param>
        public ContainerVolume(
            bool readOnly,
            string destination,
            Models.Local1 local = null,
            Models.RemoteAccess1 remoteAccess = null)
        {
            this.ReadOnly = readOnly;
            this.Local = local;
            this.Destination = destination;
            this.RemoteAccess = remoteAccess;
        }

        /// <summary>
        /// A boolean where true marks the volume as read only.
        /// </summary>
        [JsonProperty("read_only")]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Configuration for settings local to the container filesystem.
        /// </summary>
        [JsonProperty("local", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Local1 Local { get; set; }

        /// <summary>
        /// The mountpoint path for the container.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// Configuration settings for remotely accessing the container volume.
        /// </summary>
        [JsonProperty("remote_access", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RemoteAccess1 RemoteAccess { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContainerVolume : ({string.Join(", ", toStringOutput)})";
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
            return obj is ContainerVolume other &&                this.ReadOnly.Equals(other.ReadOnly) &&
                ((this.Local == null && other.Local == null) || (this.Local?.Equals(other.Local) == true)) &&
                ((this.Destination == null && other.Destination == null) || (this.Destination?.Equals(other.Destination) == true)) &&
                ((this.RemoteAccess == null && other.RemoteAccess == null) || (this.RemoteAccess?.Equals(other.RemoteAccess) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ReadOnly = {this.ReadOnly}");
            toStringOutput.Add($"this.Local = {(this.Local == null ? "null" : this.Local.ToString())}");
            toStringOutput.Add($"this.Destination = {(this.Destination == null ? "null" : this.Destination)}");
            toStringOutput.Add($"this.RemoteAccess = {(this.RemoteAccess == null ? "null" : this.RemoteAccess.ToString())}");
        }
    }
}