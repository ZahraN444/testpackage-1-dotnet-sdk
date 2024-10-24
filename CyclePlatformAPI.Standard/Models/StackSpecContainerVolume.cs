// <copyright file="StackSpecContainerVolume.cs" company="APIMatic">
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
    /// StackSpecContainerVolume.
    /// </summary>
    public class StackSpecContainerVolume
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackSpecContainerVolume"/> class.
        /// </summary>
        public StackSpecContainerVolume()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackSpecContainerVolume"/> class.
        /// </summary>
        /// <param name="destination">destination.</param>
        /// <param name="readOnly">read_only.</param>
        /// <param name="local">local.</param>
        /// <param name="remoteAccess">remote_access.</param>
        public StackSpecContainerVolume(
            string destination,
            bool readOnly,
            Models.Local local = null,
            Models.RemoteAccess remoteAccess = null)
        {
            this.Local = local;
            this.Destination = destination;
            this.ReadOnly = readOnly;
            this.RemoteAccess = remoteAccess;
        }

        /// <summary>
        /// Gets or sets Local.
        /// </summary>
        [JsonProperty("local", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Local Local { get; set; }

        /// <summary>
        /// Gets or sets Destination.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or sets ReadOnly.
        /// </summary>
        [JsonProperty("read_only")]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Gets or sets RemoteAccess.
        /// </summary>
        [JsonProperty("remote_access", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RemoteAccess RemoteAccess { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackSpecContainerVolume : ({string.Join(", ", toStringOutput)})";
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
            return obj is StackSpecContainerVolume other &&                ((this.Local == null && other.Local == null) || (this.Local?.Equals(other.Local) == true)) &&
                ((this.Destination == null && other.Destination == null) || (this.Destination?.Equals(other.Destination) == true)) &&
                this.ReadOnly.Equals(other.ReadOnly) &&
                ((this.RemoteAccess == null && other.RemoteAccess == null) || (this.RemoteAccess?.Equals(other.RemoteAccess) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Local = {(this.Local == null ? "null" : this.Local.ToString())}");
            toStringOutput.Add($"this.Destination = {(this.Destination == null ? "null" : this.Destination)}");
            toStringOutput.Add($"this.ReadOnly = {this.ReadOnly}");
            toStringOutput.Add($"this.RemoteAccess = {(this.RemoteAccess == null ? "null" : this.RemoteAccess.ToString())}");
        }
    }
}