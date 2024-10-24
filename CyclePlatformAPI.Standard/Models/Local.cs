// <copyright file="Local.cs" company="APIMatic">
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
    /// Local.
    /// </summary>
    public class Local
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Local"/> class.
        /// </summary>
        public Local()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Local"/> class.
        /// </summary>
        /// <param name="maxSize">max_size.</param>
        /// <param name="storagePool">storage_pool.</param>
        public Local(
            string maxSize,
            bool? storagePool = null)
        {
            this.MaxSize = maxSize;
            this.StoragePool = storagePool;
        }

        /// <summary>
        /// Gets or sets MaxSize.
        /// </summary>
        [JsonProperty("max_size")]
        public string MaxSize { get; set; }

        /// <summary>
        /// Gets or sets StoragePool.
        /// </summary>
        [JsonProperty("storage_pool", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StoragePool { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Local : ({string.Join(", ", toStringOutput)})";
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
            return obj is Local other &&                ((this.MaxSize == null && other.MaxSize == null) || (this.MaxSize?.Equals(other.MaxSize) == true)) &&
                ((this.StoragePool == null && other.StoragePool == null) || (this.StoragePool?.Equals(other.StoragePool) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MaxSize = {(this.MaxSize == null ? "null" : this.MaxSize)}");
            toStringOutput.Add($"this.StoragePool = {(this.StoragePool == null ? "null" : this.StoragePool.ToString())}");
        }
    }
}