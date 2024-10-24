// <copyright file="Storage.cs" company="APIMatic">
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
    /// Storage.
    /// </summary>
    public class Storage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Storage"/> class.
        /// </summary>
        public Storage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Storage"/> class.
        /// </summary>
        /// <param name="used">used.</param>
        /// <param name="total">total.</param>
        public Storage(
            int used,
            int total)
        {
            this.Used = used;
            this.Total = total;
        }

        /// <summary>
        /// The amount of volume storage used, in MB's
        /// </summary>
        [JsonProperty("used")]
        public int Used { get; set; }

        /// <summary>
        /// The total amount of volume storage available, in MB's.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Storage : ({string.Join(", ", toStringOutput)})";
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
            return obj is Storage other &&                this.Used.Equals(other.Used) &&
                this.Total.Equals(other.Total);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Used = {this.Used}");
            toStringOutput.Add($"this.Total = {this.Total}");
        }
    }
}