// <copyright file="Rootfs.cs" company="APIMatic">
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
    /// Rootfs.
    /// </summary>
    public class Rootfs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rootfs"/> class.
        /// </summary>
        public Rootfs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rootfs"/> class.
        /// </summary>
        /// <param name="mReadonly">readonly.</param>
        public Rootfs(
            bool mReadonly)
        {
            this.MReadonly = mReadonly;
        }

        /// <summary>
        /// Gets or sets MReadonly.
        /// </summary>
        [JsonProperty("readonly")]
        public bool MReadonly { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Rootfs : ({string.Join(", ", toStringOutput)})";
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
            return obj is Rootfs other &&                this.MReadonly.Equals(other.MReadonly);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MReadonly = {this.MReadonly}");
        }
    }
}