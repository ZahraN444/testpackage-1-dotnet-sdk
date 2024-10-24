// <copyright file="Events.cs" company="APIMatic">
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
    /// Events.
    /// </summary>
    public class Events
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Events"/> class.
        /// </summary>
        public Events()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Events"/> class.
        /// </summary>
        /// <param name="lastLogin">last_login.</param>
        public Events(
            DateTime? lastLogin = null)
        {
            this.LastLogin = lastLogin;
        }

        /// <summary>
        /// Gets or sets LastLogin.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("last_login", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? LastLogin { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Events : ({string.Join(", ", toStringOutput)})";
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
            return obj is Events other &&                ((this.LastLogin == null && other.LastLogin == null) || (this.LastLogin?.Equals(other.LastLogin) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LastLogin = {(this.LastLogin == null ? "null" : this.LastLogin.ToString())}");
        }
    }
}