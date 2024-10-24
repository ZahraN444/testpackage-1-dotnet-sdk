// <copyright file="Details8.cs" company="APIMatic">
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
    /// Details8.
    /// </summary>
    public class Details8
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details8"/> class.
        /// </summary>
        public Details8()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details8"/> class.
        /// </summary>
        /// <param name="flavor">flavor.</param>
        /// <param name="credentials">credentials.</param>
        public Details8(
            string flavor,
            Models.RegistryAuthProviderCredentials credentials)
        {
            this.Flavor = flavor;
            this.Credentials = credentials;
        }

        /// <summary>
        /// Gets or sets Flavor.
        /// </summary>
        [JsonProperty("flavor")]
        public string Flavor { get; set; }

        /// <summary>
        /// Gets or sets Credentials.
        /// </summary>
        [JsonProperty("credentials")]
        public Models.RegistryAuthProviderCredentials Credentials { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details8 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details8 other &&                ((this.Flavor == null && other.Flavor == null) || (this.Flavor?.Equals(other.Flavor) == true)) &&
                ((this.Credentials == null && other.Credentials == null) || (this.Credentials?.Equals(other.Credentials) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Flavor = {(this.Flavor == null ? "null" : this.Flavor)}");
            toStringOutput.Add($"this.Credentials = {(this.Credentials == null ? "null" : this.Credentials.ToString())}");
        }
    }
}