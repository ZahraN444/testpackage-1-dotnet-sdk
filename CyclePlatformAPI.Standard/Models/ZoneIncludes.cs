// <copyright file="ZoneIncludes.cs" company="APIMatic">
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
    /// ZoneIncludes.
    /// </summary>
    public class ZoneIncludes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneIncludes"/> class.
        /// </summary>
        public ZoneIncludes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZoneIncludes"/> class.
        /// </summary>
        /// <param name="creators">creators.</param>
        public ZoneIncludes(
            Models.CreatorInclude creators = null)
        {
            this.Creators = creators;
        }

        /// <summary>
        /// An identity that created a resource.
        /// </summary>
        [JsonProperty("creators", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CreatorInclude Creators { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ZoneIncludes : ({string.Join(", ", toStringOutput)})";
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
            return obj is ZoneIncludes other &&                ((this.Creators == null && other.Creators == null) || (this.Creators?.Equals(other.Creators) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Creators = {(this.Creators == null ? "null" : this.Creators.ToString())}");
        }
    }
}