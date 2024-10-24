// <copyright file="OrderEvents.cs" company="APIMatic">
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
    /// OrderEvents.
    /// </summary>
    public class OrderEvents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderEvents"/> class.
        /// </summary>
        public OrderEvents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderEvents"/> class.
        /// </summary>
        /// <param name="expires">expires.</param>
        public OrderEvents(
            DateTime expires)
        {
            this.Expires = expires;
        }

        /// <summary>
        /// The timestamp of when the order expires.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires")]
        public DateTime Expires { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OrderEvents : ({string.Join(", ", toStringOutput)})";
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
            return obj is OrderEvents other &&                this.Expires.Equals(other.Expires);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Expires = {this.Expires}");
        }
    }
}