// <copyright file="Router.cs" company="APIMatic">
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
    /// Router.
    /// </summary>
    public class Router
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Router"/> class.
        /// </summary>
        public Router()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Router"/> class.
        /// </summary>
        /// <param name="destinations">destinations.</param>
        public Router(
            Dictionary<string, Models.Destinations> destinations = null)
        {
            this.Destinations = destinations;
        }

        /// <summary>
        /// Gets or sets Destinations.
        /// </summary>
        [JsonProperty("destinations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Destinations> Destinations { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Router : ({string.Join(", ", toStringOutput)})";
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
            return obj is Router other &&                ((this.Destinations == null && other.Destinations == null) || (this.Destinations?.Equals(other.Destinations) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Destinations = {(this.Destinations == null ? "null" : this.Destinations.ToString())}");
        }
    }
}