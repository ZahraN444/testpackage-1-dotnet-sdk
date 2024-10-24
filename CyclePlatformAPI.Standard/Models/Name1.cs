// <copyright file="Name1.cs" company="APIMatic">
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
    /// Name1.
    /// </summary>
    public class Name1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Name1"/> class.
        /// </summary>
        public Name1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Name1"/> class.
        /// </summary>
        /// <param name="first">first.</param>
        /// <param name="last">last.</param>
        public Name1(
            string first = null,
            string last = null)
        {
            this.First = first;
            this.Last = last;
        }

        /// <summary>
        /// Gets or sets First.
        /// </summary>
        [JsonProperty("first", NullValueHandling = NullValueHandling.Ignore)]
        public string First { get; set; }

        /// <summary>
        /// Gets or sets Last.
        /// </summary>
        [JsonProperty("last", NullValueHandling = NullValueHandling.Ignore)]
        public string Last { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Name1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Name1 other &&                ((this.First == null && other.First == null) || (this.First?.Equals(other.First) == true)) &&
                ((this.Last == null && other.Last == null) || (this.Last?.Equals(other.Last) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.First = {(this.First == null ? "null" : this.First)}");
            toStringOutput.Add($"this.Last = {(this.Last == null ? "null" : this.Last)}");
        }
    }
}