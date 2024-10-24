// <copyright file="Allow1.cs" company="APIMatic">
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
    /// Allow1.
    /// </summary>
    public class Allow1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Allow1"/> class.
        /// </summary>
        public Allow1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Allow1"/> class.
        /// </summary>
        /// <param name="pool">pool.</param>
        /// <param name="services">services.</param>
        /// <param name="overcommit">overcommit.</param>
        public Allow1(
            bool pool,
            bool services,
            bool overcommit)
        {
            this.Pool = pool;
            this.Services = services;
            this.Overcommit = overcommit;
        }

        /// <summary>
        /// A boolean where true represents the Server can accept containers with no tags set.
        /// </summary>
        [JsonProperty("pool")]
        public bool Pool { get; set; }

        /// <summary>
        /// A boolean where true represents the Server being a target for service containers.
        /// </summary>
        [JsonProperty("services")]
        public bool Services { get; set; }

        /// <summary>
        /// A boolean where true represents the desire for the Server to allow the overcommitting of shares.
        /// </summary>
        [JsonProperty("overcommit")]
        public bool Overcommit { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Allow1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Allow1 other &&                this.Pool.Equals(other.Pool) &&
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