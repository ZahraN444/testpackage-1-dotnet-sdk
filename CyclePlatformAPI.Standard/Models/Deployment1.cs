// <copyright file="Deployment1.cs" company="APIMatic">
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
    /// Deployment1.
    /// </summary>
    public class Deployment1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Deployment1"/> class.
        /// </summary>
        public Deployment1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Deployment1"/> class.
        /// </summary>
        /// <param name="environmentId">environment_id.</param>
        /// <param name="match">match.</param>
        public Deployment1(
            string environmentId,
            Models.Match1 match)
        {
            this.EnvironmentId = environmentId;
            this.Match = match;
        }

        /// <summary>
        /// The ID of the environment with the deployment tag mapping we want to reference.
        /// </summary>
        [JsonProperty("environment_id")]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Describes which container and which tagged deployment this record should target.
        /// </summary>
        [JsonProperty("match")]
        public Models.Match1 Match { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Deployment1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Deployment1 other &&                ((this.EnvironmentId == null && other.EnvironmentId == null) || (this.EnvironmentId?.Equals(other.EnvironmentId) == true)) &&
                ((this.Match == null && other.Match == null) || (this.Match?.Equals(other.Match) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EnvironmentId = {(this.EnvironmentId == null ? "null" : this.EnvironmentId)}");
            toStringOutput.Add($"this.Match = {(this.Match == null ? "null" : this.Match.ToString())}");
        }
    }
}