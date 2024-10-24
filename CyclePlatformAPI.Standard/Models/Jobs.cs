// <copyright file="Jobs.cs" company="APIMatic">
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
    /// Jobs.
    /// </summary>
    public class Jobs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Jobs"/> class.
        /// </summary>
        public Jobs()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Jobs"/> class.
        /// </summary>
        /// <param name="apikeyAlerts">apikey_alerts.</param>
        public Jobs(
            bool apikeyAlerts)
        {
            this.ApikeyAlerts = apikeyAlerts;
        }

        /// <summary>
        /// Gets or sets ApikeyAlerts.
        /// </summary>
        [JsonProperty("apikey_alerts")]
        public bool ApikeyAlerts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Jobs : ({string.Join(", ", toStringOutput)})";
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
            return obj is Jobs other &&                this.ApikeyAlerts.Equals(other.ApikeyAlerts);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ApikeyAlerts = {this.ApikeyAlerts}");
        }
    }
}