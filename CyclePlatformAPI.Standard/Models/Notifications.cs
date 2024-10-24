// <copyright file="Notifications.cs" company="APIMatic">
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
    /// Notifications.
    /// </summary>
    public class Notifications
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notifications"/> class.
        /// </summary>
        public Notifications()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notifications"/> class.
        /// </summary>
        /// <param name="jobs">jobs.</param>
        public Notifications(
            Models.Jobs jobs)
        {
            this.Jobs = jobs;
        }

        /// <summary>
        /// Gets or sets Jobs.
        /// </summary>
        [JsonProperty("jobs")]
        public Models.Jobs Jobs { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Notifications : ({string.Join(", ", toStringOutput)})";
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
            return obj is Notifications other &&                ((this.Jobs == null && other.Jobs == null) || (this.Jobs?.Equals(other.Jobs) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Jobs = {(this.Jobs == null ? "null" : this.Jobs.ToString())}");
        }
    }
}