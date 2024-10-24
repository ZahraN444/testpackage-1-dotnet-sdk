// <copyright file="ServerConstraints.cs" company="APIMatic">
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
    /// ServerConstraints.
    /// </summary>
    public class ServerConstraints
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerConstraints"/> class.
        /// </summary>
        public ServerConstraints()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerConstraints"/> class.
        /// </summary>
        /// <param name="tags">tags.</param>
        /// <param name="allow">allow.</param>
        public ServerConstraints(
            List<string> tags,
            Models.Allow allow)
        {
            this.Tags = tags;
            this.Allow = allow;
        }

        /// <summary>
        /// A list of server tags to put on the given server.
        /// </summary>
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Settings for the server, things that are or are not allowed.
        /// </summary>
        [JsonProperty("allow")]
        public Models.Allow Allow { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerConstraints : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerConstraints other &&                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true)) &&
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