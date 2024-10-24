// <copyright file="NetworkIncludes.cs" company="APIMatic">
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
    /// NetworkIncludes.
    /// </summary>
    public class NetworkIncludes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkIncludes"/> class.
        /// </summary>
        public NetworkIncludes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkIncludes"/> class.
        /// </summary>
        /// <param name="creators">creators.</param>
        /// <param name="environments">environments.</param>
        public NetworkIncludes(
            Models.CreatorInclude creators = null,
            Dictionary<string, Models.Environment> environments = null)
        {
            this.Creators = creators;
            this.Environments = environments;
        }

        /// <summary>
        /// An identity that created a resource.
        /// </summary>
        [JsonProperty("creators", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatorInclude Creators { get; set; }

        /// <summary>
        /// An identity that is associated with an environment.
        /// </summary>
        [JsonProperty("environments", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Environment> Environments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"NetworkIncludes : ({string.Join(", ", toStringOutput)})";
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
            return obj is NetworkIncludes other &&                ((this.Creators == null && other.Creators == null) || (this.Creators?.Equals(other.Creators) == true)) &&
                ((this.Environments == null && other.Environments == null) || (this.Environments?.Equals(other.Environments) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Creators = {(this.Creators == null ? "null" : this.Creators.ToString())}");
            toStringOutput.Add($"Environments = {(this.Environments == null ? "null" : this.Environments.ToString())}");
        }
    }
}