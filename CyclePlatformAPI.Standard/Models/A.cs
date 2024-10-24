// <copyright file="A.cs" company="APIMatic">
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
    /// A.
    /// </summary>
    public class A
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="A"/> class.
        /// </summary>
        public A()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="A"/> class.
        /// </summary>
        /// <param name="ip">ip.</param>
        public A(
            string ip)
        {
            this.Ip = ip;
        }

        /// <summary>
        /// The IPv4 address that the A record should map to.
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"A : ({string.Join(", ", toStringOutput)})";
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
            return obj is A other &&                ((this.Ip == null && other.Ip == null) || (this.Ip?.Equals(other.Ip) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ip = {(this.Ip == null ? "null" : this.Ip)}");
        }
    }
}