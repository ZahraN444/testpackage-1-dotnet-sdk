// <copyright file="Features2.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// Features2.
    /// </summary>
    public class Features2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Features2"/> class.
        /// </summary>
        public Features2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Features2"/> class.
        /// </summary>
        /// <param name="certificate">certificate.</param>
        public Features2(
            Features2Certificate certificate)
        {
            this.Certificate = certificate;
        }

        /// <summary>
        /// Gets or sets Certificate.
        /// </summary>
        [JsonProperty("certificate")]
        public Features2Certificate Certificate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Features2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Features2 other &&                ((this.Certificate == null && other.Certificate == null) || (this.Certificate?.Equals(other.Certificate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Certificate = {(this.Certificate == null ? "null" : this.Certificate.ToString())}");
        }
    }
}