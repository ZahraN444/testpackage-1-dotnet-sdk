// <copyright file="MemoryServerSpec.cs" company="APIMatic">
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
    /// MemoryServerSpec.
    /// </summary>
    public class MemoryServerSpec
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryServerSpec"/> class.
        /// </summary>
        public MemoryServerSpec()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryServerSpec"/> class.
        /// </summary>
        /// <param name="sizeGb">size_gb.</param>
        /// <param name="type">type.</param>
        /// <param name="extra">extra.</param>
        public MemoryServerSpec(
            int sizeGb,
            string type,
            Dictionary<string, string> extra)
        {
            this.SizeGb = sizeGb;
            this.Type = type;
            this.Extra = extra;
        }

        /// <summary>
        /// A number that represents the memory resources in GB.
        /// </summary>
        [JsonProperty("size_gb")]
        public int SizeGb { get; set; }

        /// <summary>
        /// The type of the memory resources.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Extra inforamtion about the memory resources.
        /// </summary>
        [JsonProperty("extra")]
        public Dictionary<string, string> Extra { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MemoryServerSpec : ({string.Join(", ", toStringOutput)})";
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
            return obj is MemoryServerSpec other &&                this.SizeGb.Equals(other.SizeGb) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Extra == null && other.Extra == null) || (this.Extra?.Equals(other.Extra) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SizeGb = {this.SizeGb}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"Extra = {(this.Extra == null ? "null" : this.Extra.ToString())}");
        }
    }
}