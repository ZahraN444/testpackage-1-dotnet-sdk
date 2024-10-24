// <copyright file="V1DnsZonesRequest1.cs" company="APIMatic">
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
    /// V1DnsZonesRequest1.
    /// </summary>
    public class V1DnsZonesRequest1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1DnsZonesRequest1"/> class.
        /// </summary>
        public V1DnsZonesRequest1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1DnsZonesRequest1"/> class.
        /// </summary>
        /// <param name="hosted">hosted.</param>
        public V1DnsZonesRequest1(
            bool hosted)
        {
            this.Hosted = hosted;
        }

        /// <summary>
        /// A boolean where true represents the desire for the origin to be of the type `hosted`.
        /// </summary>
        [JsonProperty("hosted")]
        public bool Hosted { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1DnsZonesRequest1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1DnsZonesRequest1 other &&                this.Hosted.Equals(other.Hosted);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Hosted = {this.Hosted}");
        }
    }
}