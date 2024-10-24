// <copyright file="SSHTokenEvents.cs" company="APIMatic">
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
    /// SSHTokenEvents.
    /// </summary>
    public class SSHTokenEvents
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SSHTokenEvents"/> class.
        /// </summary>
        public SSHTokenEvents()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSHTokenEvents"/> class.
        /// </summary>
        /// <param name="created">created.</param>
        /// <param name="used">used.</param>
        /// <param name="expires">expires.</param>
        public SSHTokenEvents(
            DateTime created,
            DateTime used,
            DateTime expires)
        {
            this.Created = created;
            this.Used = used;
            this.Expires = expires;
        }

        /// <summary>
        /// The timestamp of when the SSH token was created.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The timestamp of when the SSH token was used.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("used")]
        public DateTime Used { get; set; }

        /// <summary>
        /// The timestamp of when the SSH token expires.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires")]
        public DateTime Expires { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SSHTokenEvents : ({string.Join(", ", toStringOutput)})";
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
            return obj is SSHTokenEvents other &&                this.Created.Equals(other.Created) &&
                this.Used.Equals(other.Used) &&
                this.Expires.Equals(other.Expires);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Created = {this.Created}");
            toStringOutput.Add($"this.Used = {this.Used}");
            toStringOutput.Add($"this.Expires = {this.Expires}");
        }
    }
}