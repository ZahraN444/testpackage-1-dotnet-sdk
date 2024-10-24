// <copyright file="Timeouts2.cs" company="APIMatic">
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
    /// Timeouts2.
    /// </summary>
    public class Timeouts2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Timeouts2"/> class.
        /// </summary>
        public Timeouts2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Timeouts2"/> class.
        /// </summary>
        /// <param name="destinationConnection">destination_connection.</param>
        public Timeouts2(
            string destinationConnection)
        {
            this.DestinationConnection = destinationConnection;
        }

        /// <summary>
        /// The duration the load balancer will wait before timing out while attempting to connect to the destination.
        /// </summary>
        [JsonProperty("destination_connection")]
        public string DestinationConnection { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Timeouts2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Timeouts2 other &&                ((this.DestinationConnection == null && other.DestinationConnection == null) || (this.DestinationConnection?.Equals(other.DestinationConnection) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DestinationConnection = {(this.DestinationConnection == null ? "null" : this.DestinationConnection)}");
        }
    }
}