// <copyright file="MountedFS.cs" company="APIMatic">
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
    /// MountedFS.
    /// </summary>
    public class MountedFS
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MountedFS"/> class.
        /// </summary>
        public MountedFS()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MountedFS"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="total">total.</param>
        /// <param name="free">free.</param>
        /// <param name="used">used.</param>
        /// <param name="device">device.</param>
        /// <param name="mountpoint">mountpoint.</param>
        public MountedFS(
            string type,
            int total,
            int free,
            int used,
            string device = null,
            string mountpoint = null)
        {
            this.Device = device;
            this.Type = type;
            this.Mountpoint = mountpoint;
            this.Total = total;
            this.Free = free;
            this.Used = used;
        }

        /// <summary>
        /// The device assocaited with the mount.
        /// </summary>
        [JsonProperty("device", NullValueHandling = NullValueHandling.Ignore)]
        public string Device { get; set; }

        /// <summary>
        /// The type of filesystem in use by the mount.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The path the mount is associated with.
        /// </summary>
        [JsonProperty("mountpoint", NullValueHandling = NullValueHandling.Ignore)]
        public string Mountpoint { get; set; }

        /// <summary>
        /// The total amount of storage in KB available at this mount.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// The amount of uninitialized storage in KB.
        /// </summary>
        [JsonProperty("free")]
        public int Free { get; set; }

        /// <summary>
        /// The amount of storage being used in KB.
        /// </summary>
        [JsonProperty("used")]
        public int Used { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MountedFS : ({string.Join(", ", toStringOutput)})";
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
            return obj is MountedFS other &&                ((this.Device == null && other.Device == null) || (this.Device?.Equals(other.Device) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Mountpoint == null && other.Mountpoint == null) || (this.Mountpoint?.Equals(other.Mountpoint) == true)) &&
                this.Total.Equals(other.Total) &&
                this.Free.Equals(other.Free) &&
                this.Used.Equals(other.Used);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Device = {(this.Device == null ? "null" : this.Device)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Mountpoint = {(this.Mountpoint == null ? "null" : this.Mountpoint)}");
            toStringOutput.Add($"this.Total = {this.Total}");
            toStringOutput.Add($"this.Free = {this.Free}");
            toStringOutput.Add($"this.Used = {this.Used}");
        }
    }
}