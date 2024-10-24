// <copyright file="StoragePool.cs" company="APIMatic">
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
    /// StoragePool.
    /// </summary>
    public class StoragePool
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoragePool"/> class.
        /// </summary>
        public StoragePool()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoragePool"/> class.
        /// </summary>
        /// <param name="dataPercent">data_percent.</param>
        /// <param name="metaPercent">meta_percent.</param>
        /// <param name="total">total.</param>
        public StoragePool(
            double dataPercent,
            double metaPercent,
            double total)
        {
            this.DataPercent = dataPercent;
            this.MetaPercent = metaPercent;
            this.Total = total;
        }

        /// <summary>
        /// The percentage of storage used by user data.
        /// </summary>
        [JsonProperty("data_percent")]
        public double DataPercent { get; set; }

        /// <summary>
        /// The percentage of storage used by the file allocation stables, etc.
        /// </summary>
        [JsonProperty("meta_percent")]
        public double MetaPercent { get; set; }

        /// <summary>
        /// The total amount of storage available.
        /// </summary>
        [JsonProperty("total")]
        public double Total { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StoragePool : ({string.Join(", ", toStringOutput)})";
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
            return obj is StoragePool other &&                this.DataPercent.Equals(other.DataPercent) &&
                this.MetaPercent.Equals(other.MetaPercent) &&
                this.Total.Equals(other.Total);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DataPercent = {this.DataPercent}");
            toStringOutput.Add($"this.MetaPercent = {this.MetaPercent}");
            toStringOutput.Add($"this.Total = {this.Total}");
        }
    }
}