// <copyright file="StorageServerSpec.cs" company="APIMatic">
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
    /// StorageServerSpec.
    /// </summary>
    public class StorageServerSpec
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageServerSpec"/> class.
        /// </summary>
        public StorageServerSpec()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageServerSpec"/> class.
        /// </summary>
        /// <param name="count">count.</param>
        /// <param name="sizeGb">size_gb.</param>
        /// <param name="type">type.</param>
        /// <param name="extra">extra.</param>
        public StorageServerSpec(
            int count,
            int sizeGb,
            string type,
            Dictionary<string, string> extra)
        {
            this.Count = count;
            this.SizeGb = sizeGb;
            this.Type = type;
            this.Extra = extra;
        }

        /// <summary>
        /// The number of storage devices for a given server.
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// The total amount of storage on a given server, in GB.
        /// </summary>
        [JsonProperty("size_gb")]
        public int SizeGb { get; set; }

        /// <summary>
        /// The type of the storage device(s).
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Extra information about the storage resources for a given server.
        /// </summary>
        [JsonProperty("extra")]
        public Dictionary<string, string> Extra { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StorageServerSpec : ({string.Join(", ", toStringOutput)})";
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
            return obj is StorageServerSpec other &&                this.Count.Equals(other.Count) &&
                this.SizeGb.Equals(other.SizeGb) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Extra == null && other.Extra == null) || (this.Extra?.Equals(other.Extra) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Count = {this.Count}");
            toStringOutput.Add($"this.SizeGb = {this.SizeGb}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"Extra = {(this.Extra == null ? "null" : this.Extra.ToString())}");
        }
    }
}