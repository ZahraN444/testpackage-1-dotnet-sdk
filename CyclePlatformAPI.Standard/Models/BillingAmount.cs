// <copyright file="BillingAmount.cs" company="APIMatic">
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
    /// BillingAmount.
    /// </summary>
    public class BillingAmount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAmount"/> class.
        /// </summary>
        public BillingAmount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAmount"/> class.
        /// </summary>
        /// <param name="mills">mills.</param>
        /// <param name="term">term.</param>
        public BillingAmount(
            int mills,
            Models.TermEnum term)
        {
            this.Mills = mills;
            this.Term = term;
        }

        /// <summary>
        /// 1/10th of a cent.
        /// </summary>
        [JsonProperty("mills")]
        public int Mills { get; set; }

        /// <summary>
        /// The length of the term.
        /// </summary>
        [JsonProperty("term")]
        public Models.TermEnum Term { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingAmount : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingAmount other &&                this.Mills.Equals(other.Mills) &&
                this.Term.Equals(other.Term);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Mills = {this.Mills}");
            toStringOutput.Add($"this.Term = {this.Term}");
        }
    }
}