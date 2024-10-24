// <copyright file="CPUServerSpec.cs" company="APIMatic">
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
    /// CPUServerSpec.
    /// </summary>
    public class CPUServerSpec
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CPUServerSpec"/> class.
        /// </summary>
        public CPUServerSpec()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CPUServerSpec"/> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="type">type.</param>
        /// <param name="cores">cores.</param>
        /// <param name="threads">threads.</param>
        /// <param name="shared">shared.</param>
        /// <param name="extra">extra.</param>
        public CPUServerSpec(
            int count,
            string type,
            int? cores = null,
            int? threads = null,
            bool? shared = null,
            Dictionary<string, string> extra = null)
        {
            this.Count = count;
            this.Cores = cores;
            this.Threads = threads;
            this.Type = type;
            this.Shared = shared;
            this.Extra = extra;
        }

        /// <summary>
        /// The number of CPUs.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// The number of cores.
        /// </summary>
        [JsonProperty("cores", NullValueHandling = NullValueHandling.Ignore)]
        public int? Cores { get; set; }

        /// <summary>
        /// The number of threads.
        /// </summary>
        [JsonProperty("threads", NullValueHandling = NullValueHandling.Ignore)]
        public int? Threads { get; set; }

        /// <summary>
        /// The type of the CPU.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// A boolean where true represents the CPU is shared.
        /// </summary>
        [JsonProperty("shared", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shared { get; set; }

        /// <summary>
        /// Extra information about the CPU if there is any.
        /// </summary>
        [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Extra { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CPUServerSpec : ({string.Join(", ", toStringOutput)})";
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
            return obj is CPUServerSpec other &&                this.Count.Equals(other.Count) &&
                ((this.Cores == null && other.Cores == null) || (this.Cores?.Equals(other.Cores) == true)) &&
                ((this.Threads == null && other.Threads == null) || (this.Threads?.Equals(other.Threads) == true)) &&
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
            toStringOutput.Add($"this.Threads = {(this.Threads == null ? "null" : this.Threads.ToString())}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Shared = {(this.Shared == null ? "null" : this.Shared.ToString())}");
            toStringOutput.Add($"Extra = {(this.Extra == null ? "null" : this.Extra.ToString())}");
        }
    }
}