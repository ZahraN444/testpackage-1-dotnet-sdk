// <copyright file="File.cs" company="APIMatic">
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
    /// File.
    /// </summary>
    public class File
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="File"/> class.
        /// </summary>
        public File()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File"/> class.
        /// </summary>
        /// <param name="match">match.</param>
        /// <param name="ttl">ttl.</param>
        public File(
            string match,
            string ttl)
        {
            this.Match = match;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Regex string that describes the files to cache.
        /// </summary>
        [JsonProperty("match")]
        public string Match { get; set; }

        /// <summary>
        /// Time string that describes the time to live.
        /// </summary>
        [JsonProperty("ttl")]
        public string Ttl { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"File : ({string.Join(", ", toStringOutput)})";
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
            return obj is File other &&                ((this.Match == null && other.Match == null) || (this.Match?.Equals(other.Match) == true)) &&
                ((this.Ttl == null && other.Ttl == null) || (this.Ttl?.Equals(other.Ttl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Match = {(this.Match == null ? "null" : this.Match)}");
            toStringOutput.Add($"this.Ttl = {(this.Ttl == null ? "null" : this.Ttl)}");
        }
    }
}