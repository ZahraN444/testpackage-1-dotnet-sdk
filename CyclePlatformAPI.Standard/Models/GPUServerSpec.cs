// <copyright file="GPUServerSpec.cs" company="APIMatic">
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
    /// GPUServerSpec.
    /// </summary>
    public class GPUServerSpec
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GPUServerSpec"/> class.
        /// </summary>
        public GPUServerSpec()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPUServerSpec"/> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="type">type.</param>
        /// <param name="cores">cores.</param>
        /// <param name="vramGb">vram_gb.</param>
        /// <param name="shared">shared.</param>
        /// <param name="extra">extra.</param>
        public GPUServerSpec(
            int count,
            string type,
            int? cores = null,
            int? vramGb = null,
            bool? shared = null,
            Dictionary<string, string> extra = null)
        {
            this.Count = count;
            this.Cores = cores;
            this.VramGb = vramGb;
            this.Type = type;
            this.Shared = shared;
            this.Extra = extra;
        }

        /// <summary>
        /// The number of GPUs.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// The number of cores.
        /// </summary>
        [JsonProperty("cores", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cores { get; set; }

        /// <summary>
        /// The amount of virtaul RAM for the GPU.
        /// </summary>
        [JsonProperty("vram_gb", NullValueHandling = NullValueHandling.Ignore)]
        public int? VramGb { get; set; }

        /// <summary>
        /// The type of the GPU.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// A boolean where true represents the GPU is shared.
        /// </summary>
        [JsonProperty("shared", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shared { get; set; }

        /// <summary>
        /// Extra information about the GPU if there is any.
        /// </summary>
        [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Extra { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GPUServerSpec : ({string.Join(", ", toStringOutput)})";
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
            return obj is GPUServerSpec other &&                this.Count.Equals(other.Count) &&
                ((this.Cores == null && other.Cores == null) || (this.Cores?.Equals(other.Cores) == true)) &&
                ((this.VramGb == null && other.VramGb == null) || (this.VramGb?.Equals(other.VramGb) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Shared == null && other.Shared == null) || (this.Shared?.Equals(other.Shared) == true)) &&
                ((this.Extra == null && other.Extra == null) || (this.Extra?.Equals(other.Extra) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Count = {this.Count}");
            toStringOutput.Add($"this.Cores = {(this.Cores == null ? "null" : this.Cores.ToString())}");
            toStringOutput.Add($"this.VramGb = {(this.VramGb == null ? "null" : this.VramGb.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Shared = {(this.Shared == null ? "null" : this.Shared.ToString())}");
            toStringOutput.Add($"Extra = {(this.Extra == null ? "null" : this.Extra.ToString())}");
        }
    }
}