// <copyright file="Features1.cs" company="APIMatic">
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
    /// Features1.
    /// </summary>
    public class Features1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Features1"/> class.
        /// </summary>
        public Features1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Features1"/> class.
        /// </summary>
        /// <param name="tls">tls.</param>
        public Features1(
            Models.Tls2 tls)
        {
            this.Tls = tls;
        }

        /// <summary>
        /// TLS properties of the record.
        /// </summary>
        [JsonProperty("tls")]
        public Models.Tls2 Tls { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Features1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Features1 other &&                ((this.Tls == null && other.Tls == null) || (this.Tls?.Equals(other.Tls) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Tls = {(this.Tls == null ? "null" : this.Tls.ToString())}");
        }
    }
}