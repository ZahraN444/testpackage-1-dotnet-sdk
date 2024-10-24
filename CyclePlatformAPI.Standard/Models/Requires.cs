// <copyright file="Requires.cs" company="APIMatic">
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
    /// Requires.
    /// </summary>
    public class Requires
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Requires"/> class.
        /// </summary>
        public Requires()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Requires"/> class.
        /// </summary>
        /// <param name="nvidiaGpu">nvidia_gpu.</param>
        public Requires(
            bool? nvidiaGpu = null)
        {
            this.NvidiaGpu = nvidiaGpu;
        }

        /// <summary>
        /// Gets or sets NvidiaGpu.
        /// </summary>
        [JsonProperty("nvidia_gpu", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NvidiaGpu { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Requires : ({string.Join(", ", toStringOutput)})";
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
            return obj is Requires other &&                ((this.NvidiaGpu == null && other.NvidiaGpu == null) || (this.NvidiaGpu?.Equals(other.NvidiaGpu) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.NvidiaGpu = {(this.NvidiaGpu == null ? "null" : this.NvidiaGpu.ToString())}");
        }
    }
}