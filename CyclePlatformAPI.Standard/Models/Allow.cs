// <copyright file="Allow.cs" company="APIMatic">
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
    /// Allow.
    /// </summary>
    public class Allow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Allow"/> class.
        /// </summary>
        public Allow()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Allow"/> class.
        /// </summary>
        /// <param name="pool">pool.</param>
        /// <param name="services">services.</param>
        /// <param name="overcommit">overcommit.</param>
        public Allow(
            bool pool,
            bool services,
            bool overcommit)
        {
            this.Pool = pool;
            this.Services = services;
            this.Overcommit = overcommit;
        }

        /// <summary>
        /// A boolean where true means - allow containers with no tags specified to be deployed to this server.
        /// </summary>
        [JsonProperty("pool")]
        public bool Pool { get; set; }

        /// <summary>
        /// A boolean where true means - allow service containers to be deployed to this container.
        /// </summary>
        [JsonProperty("services")]
        public bool Services { get; set; }

        /// <summary>
        /// A boolean where true means - allow twice the normal amount of CPU shares to be allocated to containers deployed to this server.
        /// </summary>
        [JsonProperty("overcommit")]
        public bool Overcommit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Allow : ({string.Join(", ", toStringOutput)})";
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
            return obj is Allow other &&                this.Pool.Equals(other.Pool) &&
                this.Services.Equals(other.Services) &&
                this.Overcommit.Equals(other.Overcommit);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Pool = {this.Pool}");
            toStringOutput.Add($"this.Services = {this.Services}");
            toStringOutput.Add($"this.Overcommit = {this.Overcommit}");
        }
    }
}