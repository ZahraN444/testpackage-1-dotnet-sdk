// <copyright file="PaymentResult.cs" company="APIMatic">
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
    /// PaymentResult.
    /// </summary>
    public class PaymentResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResult"/> class.
        /// </summary>
        public PaymentResult()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentResult"/> class.
        /// </summary>
        /// <param name="success">success.</param>
        /// <param name="error">error.</param>
        public PaymentResult(
            bool success,
            string error)
        {
            this.Success = success;
            this.Error = error;
        }

        /// <summary>
        /// A boolean where true represents the success of the payment.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// A description of the error that took place.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PaymentResult : ({string.Join(", ", toStringOutput)})";
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
            return obj is PaymentResult other &&                this.Success.Equals(other.Success) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Success = {this.Success}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error)}");
        }
    }
}