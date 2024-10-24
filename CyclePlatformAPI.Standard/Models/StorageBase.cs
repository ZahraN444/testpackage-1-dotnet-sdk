// <copyright file="StorageBase.cs" company="APIMatic">
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
    /// StorageBase.
    /// </summary>
    public class StorageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageBase"/> class.
        /// </summary>
        public StorageBase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageBase"/> class.
        /// </summary>
        /// <param name="used">used.</param>
        /// <param name="free">free.</param>
        /// <param name="total">total.</param>
        public StorageBase(
            int used,
            int free,
            int total)
        {
            this.Used = used;
            this.Free = free;
            this.Total = total;
        }

        /// <summary>
        /// The amount of storage currently used in the base volume.
        /// </summary>
        [JsonProperty("used")]
        public int Used { get; set; }

        /// <summary>
        /// The amount of free space on the base volume.
        /// </summary>
        [JsonProperty("free")]
        public int Free { get; set; }

        /// <summary>
        /// The total amount of space on the base volume.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StorageBase : ({string.Join(", ", toStringOutput)})";
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
            return obj is StorageBase other &&                this.Used.Equals(other.Used) &&
                this.Free.Equals(other.Free) &&
                this.Total.Equals(other.Total);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Used = {this.Used}");
            toStringOutput.Add($"this.Free = {this.Free}");
            toStringOutput.Add($"this.Total = {this.Total}");
        }
    }
}