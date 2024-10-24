// <copyright file="Volumes.cs" company="APIMatic">
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
    /// Volumes.
    /// </summary>
    public class Volumes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Volumes"/> class.
        /// </summary>
        public Volumes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Volumes"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="size">size.</param>
        /// <param name="dataPercent">data_percent.</param>
        /// <param name="metaPercent">meta_percent.</param>
        /// <param name="pool">pool.</param>
        public Volumes(
            string name,
            int size,
            int dataPercent,
            int metaPercent,
            string pool)
        {
            this.Name = name;
            this.Size = size;
            this.DataPercent = dataPercent;
            this.MetaPercent = metaPercent;
            this.Pool = pool;
        }

        /// <summary>
        /// The name of the volume.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The size in megabytes of the volume.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// The percent of the volumes size being used by data.
        /// </summary>
        [JsonProperty("data_percent")]
        public int DataPercent { get; set; }

        /// <summary>
        /// The percent of the volumes size being used by meta data.
        /// </summary>
        [JsonProperty("meta_percent")]
        public int MetaPercent { get; set; }

        /// <summary>
        /// The name of the volume pool this volume is associated with.
        /// </summary>
        [JsonProperty("pool")]
        public string Pool { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Volumes : ({string.Join(", ", toStringOutput)})";
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
            return obj is Volumes other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                this.Size.Equals(other.Size) &&
                this.DataPercent.Equals(other.DataPercent) &&
                this.MetaPercent.Equals(other.MetaPercent) &&
                ((this.Pool == null && other.Pool == null) || (this.Pool?.Equals(other.Pool) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Size = {this.Size}");
            toStringOutput.Add($"this.DataPercent = {this.DataPercent}");
            toStringOutput.Add($"this.MetaPercent = {this.MetaPercent}");
            toStringOutput.Add($"this.Pool = {(this.Pool == null ? "null" : this.Pool)}");
        }
    }
}