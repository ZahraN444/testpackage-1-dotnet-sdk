// <copyright file="AutoScaleGroupScale.cs" company="APIMatic">
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
    /// AutoScaleGroupScale.
    /// </summary>
    public class AutoScaleGroupScale
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutoScaleGroupScale"/> class.
        /// </summary>
        public AutoScaleGroupScale()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoScaleGroupScale"/> class.
        /// </summary>
        /// <param name="down">down.</param>
        /// <param name="up">up.</param>
        public AutoScaleGroupScale(
            Models.AutoScaleGroupScaleDown down = null,
            Models.AutoScaleGroupScaleUp up = null)
        {
            this.Down = down;
            this.Up = up;
        }

        /// <summary>
        /// Gets or sets Down.
        /// </summary>
        [JsonProperty("down", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AutoScaleGroupScaleDown Down { get; set; }

        /// <summary>
        /// Gets or sets Up.
        /// </summary>
        [JsonProperty("up", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AutoScaleGroupScaleUp Up { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AutoScaleGroupScale : ({string.Join(", ", toStringOutput)})";
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
            return obj is AutoScaleGroupScale other &&                ((this.Down == null && other.Down == null) || (this.Down?.Equals(other.Down) == true)) &&
                ((this.Up == null && other.Up == null) || (this.Up?.Equals(other.Up) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Down = {(this.Down == null ? "null" : this.Down.ToString())}");
            toStringOutput.Add($"this.Up = {(this.Up == null ? "null" : this.Up.ToString())}");
        }
    }
}