// <copyright file="Expires.cs" company="APIMatic">
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
    /// Expires.
    /// </summary>
    public class Expires
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Expires"/> class.
        /// </summary>
        public Expires()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Expires"/> class.
        /// </summary>
        /// <param name="date">date.</param>
        public Expires(
            DateTime? date = null)
        {
            this.Date = date;
        }

        /// <summary>
        /// A timestamp of when the billing credit expires.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Date { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Expires : ({string.Join(", ", toStringOutput)})";
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
            return obj is Expires other &&                ((this.Date == null && other.Date == null) || (this.Date?.Equals(other.Date) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Date = {(this.Date == null ? "null" : this.Date.ToString())}");
        }
    }
}