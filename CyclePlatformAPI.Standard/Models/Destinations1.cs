// <copyright file="Destinations1.cs" company="APIMatic">
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
    /// Destinations1.
    /// </summary>
    public class Destinations1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Destinations1"/> class.
        /// </summary>
        public Destinations1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Destinations1"/> class.
        /// </summary>
        /// <param name="requests">requests.</param>
        public Destinations1(
            Models.Requests1 requests = null)
        {
            this.Requests = requests;
        }

        /// <summary>
        /// Gets or sets Requests.
        /// </summary>
        [JsonProperty("requests", NullValueHandling = NullValueHandling.Include)]
        public Models.Requests1 Requests { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Destinations1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Destinations1 other &&                ((this.Requests == null && other.Requests == null) || (this.Requests?.Equals(other.Requests) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Requests = {(this.Requests == null ? "null" : this.Requests.ToString())}");
        }
    }
}