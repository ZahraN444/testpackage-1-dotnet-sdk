// <copyright file="CreditCard1.cs" company="APIMatic">
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
    /// CreditCard1.
    /// </summary>
    public class CreditCard1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCard1"/> class.
        /// </summary>
        public CreditCard1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCard1"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="number">number.</param>
        /// <param name="cvv">cvv.</param>
        /// <param name="expiration">expiration.</param>
        public CreditCard1(
            string name,
            string number,
            string cvv,
            Models.Expiration expiration)
        {
            this.Name = name;
            this.Number = number;
            this.Cvv = cvv;
            this.Expiration = expiration;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets Cvv.
        /// </summary>
        [JsonProperty("cvv")]
        public string Cvv { get; set; }

        /// <summary>
        /// Gets or sets Expiration.
        /// </summary>
        [JsonProperty("expiration")]
        public Models.Expiration Expiration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreditCard1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreditCard1 other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.Cvv == null && other.Cvv == null) || (this.Cvv?.Equals(other.Cvv) == true)) &&
                ((this.Expiration == null && other.Expiration == null) || (this.Expiration?.Equals(other.Expiration) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number)}");
            toStringOutput.Add($"this.Cvv = {(this.Cvv == null ? "null" : this.Cvv)}");
            toStringOutput.Add($"this.Expiration = {(this.Expiration == null ? "null" : this.Expiration.ToString())}");
        }
    }
}