// <copyright file="Constraints2.cs" company="APIMatic">
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
    /// Constraints2.
    /// </summary>
    public class Constraints2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Constraints2"/> class.
        /// </summary>
        public Constraints2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Constraints2"/> class.
        /// </summary>
        /// <param name="tags">tags.</param>
        /// <param name="allow">allow.</param>
        public Constraints2(
            List<string> tags = null,
            Models.Allow1 allow = null)
        {
            this.Tags = tags;
            this.Allow = allow;
        }

        /// <summary>
        /// A list of Server tags.
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Server constraints for the given Server.
        /// </summary>
        [JsonProperty("allow", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Allow1 Allow { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Constraints2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Constraints2 other &&                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true)) &&
                ((this.Allow == null && other.Allow == null) || (this.Allow?.Equals(other.Allow) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : $"[{string.Join(", ", this.Tags)} ]")}");
            toStringOutput.Add($"this.Allow = {(this.Allow == null ? "null" : this.Allow.ToString())}");
        }
    }
}