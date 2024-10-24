// <copyright file="Features.cs" company="APIMatic">
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
    /// Features.
    /// </summary>
    public class Features
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Features"/> class.
        /// </summary>
        public Features()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Features"/> class.
        /// </summary>
        /// <param name="legacyNetworking">legacy_networking.</param>
        public Features(
            bool legacyNetworking)
        {
            this.LegacyNetworking = legacyNetworking;
        }

        /// <summary>
        /// Whether or not legacy networking mode is enabled on this environment.
        /// </summary>
        [JsonProperty("legacy_networking")]
        public bool LegacyNetworking { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Features : ({string.Join(", ", toStringOutput)})";
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
            return obj is Features other &&                this.LegacyNetworking.Equals(other.LegacyNetworking);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LegacyNetworking = {this.LegacyNetworking}");
        }
    }
}