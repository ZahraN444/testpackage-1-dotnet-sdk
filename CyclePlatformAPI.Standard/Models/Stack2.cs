// <copyright file="Stack2.cs" company="APIMatic">
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
    /// Stack2.
    /// </summary>
    public class Stack2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stack2"/> class.
        /// </summary>
        public Stack2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stack2"/> class.
        /// </summary>
        /// <param name="file">file.</param>
        /// <param name="function">function.</param>
        /// <param name="line">line.</param>
        public Stack2(
            string file,
            string function,
            int line)
        {
            this.File = file;
            this.Function = function;
            this.Line = line;
        }

        /// <summary>
        /// Gets or sets File.
        /// </summary>
        [JsonProperty("file")]
        public string File { get; set; }

        /// <summary>
        /// Gets or sets Function.
        /// </summary>
        [JsonProperty("function")]
        public string Function { get; set; }

        /// <summary>
        /// Gets or sets Line.
        /// </summary>
        [JsonProperty("line")]
        public int Line { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Stack2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Stack2 other &&                ((this.File == null && other.File == null) || (this.File?.Equals(other.File) == true)) &&
                ((this.Function == null && other.Function == null) || (this.Function?.Equals(other.Function) == true)) &&
                this.Line.Equals(other.Line);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.File = {(this.File == null ? "null" : this.File)}");
            toStringOutput.Add($"this.Function = {(this.Function == null ? "null" : this.Function)}");
            toStringOutput.Add($"this.Line = {this.Line}");
        }
    }
}