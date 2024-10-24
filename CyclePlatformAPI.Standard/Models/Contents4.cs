// <copyright file="Contents4.cs" company="APIMatic">
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
    /// Contents4.
    /// </summary>
    public class Contents4
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contents4"/> class.
        /// </summary>
        public Contents4()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contents4"/> class.
        /// </summary>
        /// <param name="destinationServerId">destination_server_id.</param>
        /// <param name="stateful">stateful.</param>
        public Contents4(
            string destinationServerId,
            Models.Stateful3 stateful = null)
        {
            this.DestinationServerId = destinationServerId;
            this.Stateful = stateful;
        }

        /// <summary>
        /// The ID of the server being migrated to.
        /// </summary>
        [JsonProperty("destination_server_id")]
        public string DestinationServerId { get; set; }

        /// <summary>
        /// Information about additonal configuration settings used when migrating a stateful instance.
        /// </summary>
        [JsonProperty("stateful", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Stateful3 Stateful { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Contents4 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Contents4 other &&                ((this.DestinationServerId == null && other.DestinationServerId == null) || (this.DestinationServerId?.Equals(other.DestinationServerId) == true)) &&
                ((this.Stateful == null && other.Stateful == null) || (this.Stateful?.Equals(other.Stateful) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DestinationServerId = {(this.DestinationServerId == null ? "null" : this.DestinationServerId)}");
            toStringOutput.Add($"this.Stateful = {(this.Stateful == null ? "null" : this.Stateful.ToString())}");
        }
    }
}