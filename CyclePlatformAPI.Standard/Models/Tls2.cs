// <copyright file="Tls2.cs" company="APIMatic">
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
    /// Tls2.
    /// </summary>
    public class Tls2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tls2"/> class.
        /// </summary>
        public Tls2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tls2"/> class.
        /// </summary>
        /// <param name="enable">enable.</param>
        public Tls2(
            bool enable)
        {
            this.Enable = enable;
        }

        /// <summary>
        /// A boolean, where true represents this record will be paired with a TLS certificate automatically maintained by the platform.
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Tls2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Tls2 other &&                this.Enable.Equals(other.Enable);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Enable = {this.Enable}");
        }
    }
}