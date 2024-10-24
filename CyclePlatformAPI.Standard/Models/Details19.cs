// <copyright file="Details19.cs" company="APIMatic">
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
    /// Details19.
    /// </summary>
    public class Details19
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details19"/> class.
        /// </summary>
        public Details19()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details19"/> class.
        /// </summary>
        /// <param name="mPrivate">private.</param>
        /// <param name="bandwidth">bandwidth.</param>
        public Details19(
            bool mPrivate,
            string bandwidth)
        {
            this.MPrivate = mPrivate;
            this.Bandwidth = bandwidth;
        }

        /// <summary>
        /// Gets or sets MPrivate.
        /// </summary>
        [JsonProperty("private")]
        public bool MPrivate { get; set; }

        /// <summary>
        /// The limit (maximum) amount of throughput each instance of the given container can use before triggering a scaling event.
        /// </summary>
        [JsonProperty("bandwidth")]
        public string Bandwidth { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details19 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details19 other &&                this.MPrivate.Equals(other.MPrivate) &&
                ((this.Bandwidth == null && other.Bandwidth == null) || (this.Bandwidth?.Equals(other.Bandwidth) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MPrivate = {this.MPrivate}");
            toStringOutput.Add($"this.Bandwidth = {(this.Bandwidth == null ? "null" : this.Bandwidth)}");
        }
    }
}