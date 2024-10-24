// <copyright file="File1.cs" company="APIMatic">
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
    /// File1.
    /// </summary>
    public class File1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="File1"/> class.
        /// </summary>
        public File1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File1"/> class.
        /// </summary>
        /// <param name="decode">decode.</param>
        /// <param name="path">path.</param>
        public File1(
            bool decode,
            string path = null)
        {
            this.Decode = decode;
            this.Path = path;
        }

        /// <summary>
        /// When true, Cycle will interpret this variable as a base-64 encoded string, and decode it before passing it into the container.
        /// </summary>
        [JsonProperty("decode")]
        public bool Decode { get; set; }

        /// <summary>
        /// The path to mount the file to inside the container.
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Include)]
        public string Path { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"File1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is File1 other &&                this.Decode.Equals(other.Decode) &&
                ((this.Path == null && other.Path == null) || (this.Path?.Equals(other.Path) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Decode = {this.Decode}");
            toStringOutput.Add($"this.Path = {(this.Path == null ? "null" : this.Path)}");
        }
    }
}