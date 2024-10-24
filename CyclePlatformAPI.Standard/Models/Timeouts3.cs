// <copyright file="Timeouts3.cs" company="APIMatic">
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
    /// Timeouts3.
    /// </summary>
    public class Timeouts3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Timeouts3"/> class.
        /// </summary>
        public Timeouts3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Timeouts3"/> class.
        /// </summary>
        /// <param name="idle">idle.</param>
        public Timeouts3(
            string idle)
        {
            this.Idle = idle;
        }

        /// <summary>
        /// The total amount of time a connection can be idle before being killed.
        /// </summary>
        [JsonProperty("idle")]
        public string Idle { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Timeouts3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Timeouts3 other &&                ((this.Idle == null && other.Idle == null) || (this.Idle?.Equals(other.Idle) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Idle = {(this.Idle == null ? "null" : this.Idle)}");
        }
    }
}