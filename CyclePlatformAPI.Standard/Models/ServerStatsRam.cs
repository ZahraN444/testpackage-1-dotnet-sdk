// <copyright file="ServerStatsRam.cs" company="APIMatic">
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
    /// ServerStatsRam.
    /// </summary>
    public class ServerStatsRam
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsRam"/> class.
        /// </summary>
        public ServerStatsRam()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsRam"/> class.
        /// </summary>
        /// <param name="available">available.</param>
        /// <param name="free">free.</param>
        /// <param name="total">total.</param>
        public ServerStatsRam(
            int available,
            int free,
            int total)
        {
            this.Available = available;
            this.Free = free;
            this.Total = total;
        }

        /// <summary>
        /// The available RAM on the server.
        /// </summary>
        [JsonProperty("available")]
        public int Available { get; set; }

        /// <summary>
        /// The free RAM on the server.
        /// </summary>
        [JsonProperty("free")]
        public int Free { get; set; }

        /// <summary>
        /// The total RAM on the server.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerStatsRam : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerStatsRam other &&                this.Available.Equals(other.Available) &&
                this.Free.Equals(other.Free) &&
                this.Total.Equals(other.Total);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Available = {this.Available}");
            toStringOutput.Add($"this.Free = {this.Free}");
            toStringOutput.Add($"this.Total = {this.Total}");
        }
    }
}