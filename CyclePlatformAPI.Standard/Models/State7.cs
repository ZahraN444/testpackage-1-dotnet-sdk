// <copyright file="State7.cs" company="APIMatic">
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
    /// State7.
    /// </summary>
    public class State7
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="State7"/> class.
        /// </summary>
        public State7()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="State7"/> class.
        /// </summary>
        /// <param name="mNew">new.</param>
        /// <param name="downloading">downloading.</param>
        /// <param name="building">building.</param>
        /// <param name="verifying">verifying.</param>
        /// <param name="saving">saving.</param>
        /// <param name="live">live.</param>
        /// <param name="deleting">deleting.</param>
        public State7(
            double mNew,
            double downloading,
            double building,
            double verifying,
            double saving,
            double live,
            double deleting)
        {
            this.MNew = mNew;
            this.Downloading = downloading;
            this.Building = building;
            this.Verifying = verifying;
            this.Saving = saving;
            this.Live = live;
            this.Deleting = deleting;
        }

        /// <summary>
        /// Number of images in this source with state new
        /// </summary>
        [JsonProperty("new")]
        public double MNew { get; set; }

        /// <summary>
        /// Number of images in this source with state downloading
        /// </summary>
        [JsonProperty("downloading")]
        public double Downloading { get; set; }

        /// <summary>
        /// Number of images in this source with state building
        /// </summary>
        [JsonProperty("building")]
        public double Building { get; set; }

        /// <summary>
        /// Number of images in this source with state verifying
        /// </summary>
        [JsonProperty("verifying")]
        public double Verifying { get; set; }

        /// <summary>
        /// Number of images in this source with state saving
        /// </summary>
        [JsonProperty("saving")]
        public double Saving { get; set; }

        /// <summary>
        /// Number of images in this source with state live
        /// </summary>
        [JsonProperty("live")]
        public double Live { get; set; }

        /// <summary>
        /// Number of images in this source with state deleting
        /// </summary>
        [JsonProperty("deleting")]
        public double Deleting { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"State7 : ({string.Join(", ", toStringOutput)})";
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
            return obj is State7 other &&                this.MNew.Equals(other.MNew) &&
                this.Downloading.Equals(other.Downloading) &&
                this.Building.Equals(other.Building) &&
                this.Verifying.Equals(other.Verifying) &&
                this.Saving.Equals(other.Saving) &&
                this.Live.Equals(other.Live) &&
                this.Deleting.Equals(other.Deleting);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MNew = {this.MNew}");
            toStringOutput.Add($"this.Downloading = {this.Downloading}");
            toStringOutput.Add($"this.Building = {this.Building}");
            toStringOutput.Add($"this.Verifying = {this.Verifying}");
            toStringOutput.Add($"this.Saving = {this.Saving}");
            toStringOutput.Add($"this.Live = {this.Live}");
            toStringOutput.Add($"this.Deleting = {this.Deleting}");
        }
    }
}