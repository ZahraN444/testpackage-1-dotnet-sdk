// <copyright file="Backend.cs" company="APIMatic">
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
    /// Backend.
    /// </summary>
    public class Backend
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Backend"/> class.
        /// </summary>
        public Backend()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Backend"/> class.
        /// </summary>
        /// <param name="balance">balance.</param>
        /// <param name="timeouts">timeouts.</param>
        public Backend(
            Models.BalanceEnum balance,
            Models.Timeouts1 timeouts = null)
        {
            this.Balance = balance;
            this.Timeouts = timeouts;
        }

        /// <summary>
        /// How connections are balanced across your container instances. Can be one of the following:
        ///  - `roundrobin`: Each container instance is used in turns.
        ///  - `static-rr`: Each container instance is used in turns, but is faster than Round Robin at the expense of being less dynamic.
        ///  - `leastconn`: Routes traffic to the instance with the least number of active connections.
        ///  - `first`: Routes traffic to the first available instance.
        ///  - `source`: The same client IP always reaches the same container instance as long as no instance goes down or up.
        /// </summary>
        [JsonProperty("balance")]
        public Models.BalanceEnum Balance { get; set; }

        /// <summary>
        /// Various options for handling timeouts when communicating with a container instance behind the load balancer.
        /// </summary>
        [JsonProperty("timeouts", NullValueHandling = NullValueHandling.Include)]
        public Models.Timeouts1 Timeouts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Backend : ({string.Join(", ", toStringOutput)})";
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
            return obj is Backend other &&                this.Balance.Equals(other.Balance) &&
                ((this.Timeouts == null && other.Timeouts == null) || (this.Timeouts?.Equals(other.Timeouts) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Balance = {this.Balance}");
            toStringOutput.Add($"this.Timeouts = {(this.Timeouts == null ? "null" : this.Timeouts.ToString())}");
        }
    }
}