// <copyright file="Cpu2.cs" company="APIMatic">
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
    /// Cpu2.
    /// </summary>
    public class Cpu2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cpu2"/> class.
        /// </summary>
        public Cpu2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cpu2"/> class.
        /// </summary>
        /// <param name="cores">cores.</param>
        /// <param name="shares">shares.</param>
        /// <param name="shareRatio">share_ratio.</param>
        public Cpu2(
            int cores,
            Models.Shares2 shares,
            int? shareRatio = null)
        {
            this.Cores = cores;
            this.Shares = shares;
            this.ShareRatio = shareRatio;
        }

        /// <summary>
        /// The number of CPU cores.
        /// </summary>
        [JsonProperty("cores")]
        public int Cores { get; set; }

        /// <summary>
        /// Information about CPU shares.
        /// </summary>
        [JsonProperty("shares")]
        public Models.Shares2 Shares { get; set; }

        /// <summary>
        /// The ratio of shares allocated to total shares.
        /// </summary>
        [JsonProperty("share_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public int? ShareRatio { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Cpu2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Cpu2 other &&                this.Cores.Equals(other.Cores) &&
                ((this.Shares == null && other.Shares == null) || (this.Shares?.Equals(other.Shares) == true)) &&
                ((this.ShareRatio == null && other.ShareRatio == null) || (this.ShareRatio?.Equals(other.ShareRatio) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Cores = {this.Cores}");
            toStringOutput.Add($"this.Shares = {(this.Shares == null ? "null" : this.Shares.ToString())}");
            toStringOutput.Add($"this.ShareRatio = {(this.ShareRatio == null ? "null" : this.ShareRatio.ToString())}");
        }
    }
}