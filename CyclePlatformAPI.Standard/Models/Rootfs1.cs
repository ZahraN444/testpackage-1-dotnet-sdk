// <copyright file="Rootfs1.cs" company="APIMatic">
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
    /// Rootfs1.
    /// </summary>
    public class Rootfs1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rootfs1"/> class.
        /// </summary>
        public Rootfs1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rootfs1"/> class.
        /// </summary>
        /// <param name="mReadonly">readonly.</param>
        public Rootfs1(
            bool? mReadonly = null)
        {
            this.MReadonly = mReadonly;
        }

        /// <summary>
        /// Enabling this option will set the containers filesystem to readonly. Volumes associated with the container will not be affected by this.
        /// </summary>
        [JsonProperty("readonly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MReadonly { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Rootfs1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Rootfs1 other &&                ((this.MReadonly == null && other.MReadonly == null) || (this.MReadonly?.Equals(other.MReadonly) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MReadonly = {(this.MReadonly == null ? "null" : this.MReadonly.ToString())}");
        }
    }
}