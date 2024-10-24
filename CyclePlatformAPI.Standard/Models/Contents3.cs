// <copyright file="Contents3.cs" company="APIMatic">
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
    /// Contents3.
    /// </summary>
    public class Contents3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contents3"/> class.
        /// </summary>
        public Contents3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contents3"/> class.
        /// </summary>
        /// <param name="instances">instances.</param>
        public Contents3(
            int instances)
        {
            this.Instances = instances;
        }

        /// <summary>
        /// The number of desired instances to scale to.
        /// </summary>
        [JsonProperty("instances")]
        public int Instances { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Contents3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Contents3 other &&                this.Instances.Equals(other.Instances);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Instances = {this.Instances}");
        }
    }
}