// <copyright file="Name.cs" company="APIMatic">
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
    /// Name.
    /// </summary>
    public class Name
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Name"/> class.
        /// </summary>
        public Name()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Name"/> class.
        /// </summary>
        /// <param name="first">first.</param>
        /// <param name="last">last.</param>
        public Name(
            string first,
            string last)
        {
            this.First = first;
            this.Last = last;
        }

        /// <summary>
        /// The first name of the Account owner.
        /// </summary>
        [JsonProperty("first")]
        public string First { get; set; }

        /// <summary>
        /// The last name of the Account owner.
        /// </summary>
        [JsonProperty("last")]
        public string Last { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Name : ({string.Join(", ", toStringOutput)})";
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
            return obj is Name other &&                ((this.First == null && other.First == null) || (this.First?.Equals(other.First) == true)) &&
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