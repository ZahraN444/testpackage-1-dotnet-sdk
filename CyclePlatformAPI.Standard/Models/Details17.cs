// <copyright file="Details17.cs" company="APIMatic">
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
    /// Details17.
    /// </summary>
    public class Details17
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details17"/> class.
        /// </summary>
        public Details17()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details17"/> class.
        /// </summary>
        /// <param name="connectionsTotal">connections_total.</param>
        public Details17(
            int connectionsTotal)
        {
            this.ConnectionsTotal = connectionsTotal;
        }

        /// <summary>
        /// Gets or sets ConnectionsTotal.
        /// </summary>
        [JsonProperty("connections_total")]
        public int ConnectionsTotal { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details17 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details17 other &&                this.ConnectionsTotal.Equals(other.ConnectionsTotal);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ConnectionsTotal = {this.ConnectionsTotal}");
        }
    }
}