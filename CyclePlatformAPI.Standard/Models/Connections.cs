// <copyright file="Connections.cs" company="APIMatic">
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
    /// Connections.
    /// </summary>
    public class Connections
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Connections"/> class.
        /// </summary>
        public Connections()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Connections"/> class.
        /// </summary>
        /// <param name="maxIdleConnsPerConnection">max_idle_conns_per_connection.</param>
        public Connections(
            int? maxIdleConnsPerConnection = null)
        {
            this.MaxIdleConnsPerConnection = maxIdleConnsPerConnection;
        }

        /// <summary>
        /// Maximum number of simultaneous connections (via http/2) per connection.
        /// </summary>
        [JsonProperty("max_idle_conns_per_connection", NullValueHandling = NullValueHandling.Include)]
        public int? MaxIdleConnsPerConnection { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Connections : ({string.Join(", ", toStringOutput)})";
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
            return obj is Connections other &&                ((this.MaxIdleConnsPerConnection == null && other.MaxIdleConnsPerConnection == null) || (this.MaxIdleConnsPerConnection?.Equals(other.MaxIdleConnsPerConnection) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MaxIdleConnsPerConnection = {(this.MaxIdleConnsPerConnection == null ? "null" : this.MaxIdleConnsPerConnection.ToString())}");
        }
    }
}