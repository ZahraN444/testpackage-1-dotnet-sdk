// <copyright file="Server2.cs" company="APIMatic">
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
    /// Server2.
    /// </summary>
    public class Server2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Server2"/> class.
        /// </summary>
        public Server2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Server2"/> class.
        /// </summary>
        /// <param name="mNew">new.</param>
        /// <param name="offline">offline.</param>
        public Server2(
            bool? mNew = null,
            bool? offline = null)
        {
            this.MNew = mNew;
            this.Offline = offline;
        }

        /// <summary>
        /// Gets or sets MNew.
        /// </summary>
        [JsonProperty("new", NullValueHandling = NullValueHandling.Include)]
        public bool? MNew { get; set; }

        /// <summary>
        /// Gets or sets Offline.
        /// </summary>
        [JsonProperty("offline", NullValueHandling = NullValueHandling.Include)]
        public bool? Offline { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Server2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Server2 other &&                ((this.MNew == null && other.MNew == null) || (this.MNew?.Equals(other.MNew) == true)) &&
                ((this.Offline == null && other.Offline == null) || (this.Offline?.Equals(other.Offline) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MNew = {(this.MNew == null ? "null" : this.MNew.ToString())}");
            toStringOutput.Add($"this.Offline = {(this.Offline == null ? "null" : this.Offline.ToString())}");
        }
    }
}