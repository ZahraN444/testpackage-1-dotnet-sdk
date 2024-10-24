// <copyright file="SharedFileSystems.cs" company="APIMatic">
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
    /// SharedFileSystems.
    /// </summary>
    public class SharedFileSystems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharedFileSystems"/> class.
        /// </summary>
        public SharedFileSystems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedFileSystems"/> class.
        /// </summary>
        /// <param name="writable">writable.</param>
        /// <param name="mountPoint">mount_point.</param>
        public SharedFileSystems(
            bool writable,
            string mountPoint)
        {
            this.Writable = writable;
            this.MountPoint = mountPoint;
        }

        /// <summary>
        /// Gets or sets Writable.
        /// </summary>
        [JsonProperty("writable")]
        public bool Writable { get; set; }

        /// <summary>
        /// Gets or sets MountPoint.
        /// </summary>
        [JsonProperty("mount_point")]
        public string MountPoint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SharedFileSystems : ({string.Join(", ", toStringOutput)})";
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
            return obj is SharedFileSystems other &&                this.Writable.Equals(other.Writable) &&
                ((this.MountPoint == null && other.MountPoint == null) || (this.MountPoint?.Equals(other.MountPoint) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Writable = {this.Writable}");
            toStringOutput.Add($"this.MountPoint = {(this.MountPoint == null ? "null" : this.MountPoint)}");
        }
    }
}