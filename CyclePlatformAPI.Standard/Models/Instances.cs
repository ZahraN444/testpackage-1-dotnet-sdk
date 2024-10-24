// <copyright file="Instances.cs" company="APIMatic">
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
    /// Instances.
    /// </summary>
    public class Instances
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Instances"/> class.
        /// </summary>
        public Instances()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Instances"/> class.
        /// </summary>
        /// <param name="delta">delta.</param>
        /// <param name="max">max.</param>
        /// <param name="maxServer">max_server.</param>
        /// <param name="minTtl">min_ttl.</param>
        public Instances(
            int delta,
            int max,
            int maxServer,
            string minTtl)
        {
            this.Delta = delta;
            this.Max = max;
            this.MaxServer = maxServer;
            this.MinTtl = minTtl;
        }

        /// <summary>
        /// Number of additional instances the auto-scaler will add/subtract per scaling event
        /// </summary>
        [JsonProperty("delta")]
        public int Delta { get; set; }

        /// <summary>
        /// Maximum additional instances the auto-scaler will run at any time
        /// </summary>
        [JsonProperty("max")]
        public int Max { get; set; }

        /// <summary>
        /// Minimum number of instances per server
        /// </summary>
        [JsonProperty("max_server")]
        public int MaxServer { get; set; }

        /// <summary>
        /// Minimum amount of time an instance will live
        /// </summary>
        [JsonProperty("min_ttl")]
        public string MinTtl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Instances : ({string.Join(", ", toStringOutput)})";
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
            return obj is Instances other &&                this.Delta.Equals(other.Delta) &&
                this.Max.Equals(other.Max) &&
                this.MaxServer.Equals(other.MaxServer) &&
                ((this.MinTtl == null && other.MinTtl == null) || (this.MinTtl?.Equals(other.MinTtl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Delta = {this.Delta}");
            toStringOutput.Add($"this.Max = {this.Max}");
            toStringOutput.Add($"this.MaxServer = {this.MaxServer}");
            toStringOutput.Add($"this.MinTtl = {(this.MinTtl == null ? "null" : this.MinTtl)}");
        }
    }
}