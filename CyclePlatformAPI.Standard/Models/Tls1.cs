// <copyright file="Tls1.cs" company="APIMatic">
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
    /// Tls1.
    /// </summary>
    public class Tls1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tls1"/> class.
        /// </summary>
        public Tls1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tls1"/> class.
        /// </summary>
        /// <param name="enable">enable.</param>
        public Tls1(
            bool enable)
        {
            this.Enable = enable;
        }

        /// <summary>
        /// Enables or disables TLS.
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Tls1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Tls1 other &&                this.Enable.Equals(other.Enable);
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