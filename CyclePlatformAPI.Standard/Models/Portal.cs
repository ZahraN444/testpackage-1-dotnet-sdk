// <copyright file="Portal.cs" company="APIMatic">
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
    /// Portal.
    /// </summary>
    public class Portal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Portal"/> class.
        /// </summary>
        public Portal()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Portal"/> class.
        /// </summary>
        /// <param name="notifications">notifications.</param>
        public Portal(
            Models.Notifications notifications)
        {
            this.Notifications = notifications;
        }

        /// <summary>
        /// Gets or sets Notifications.
        /// </summary>
        [JsonProperty("notifications")]
        public Models.Notifications Notifications { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Portal : ({string.Join(", ", toStringOutput)})";
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
            return obj is Portal other &&                ((this.Notifications == null && other.Notifications == null) || (this.Notifications?.Equals(other.Notifications) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Notifications = {(this.Notifications == null ? "null" : this.Notifications.ToString())}");
        }
    }
}