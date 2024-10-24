// <copyright file="AssociatedCredit.cs" company="APIMatic">
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
    /// AssociatedCredit.
    /// </summary>
    public class AssociatedCredit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociatedCredit"/> class.
        /// </summary>
        public AssociatedCredit()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssociatedCredit"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="amount">amount.</param>
        public AssociatedCredit(
            string id,
            int amount)
        {
            this.Id = id;
            this.Amount = amount;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The amount of the credit.
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AssociatedCredit : ({string.Join(", ", toStringOutput)})";
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
            return obj is AssociatedCredit other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.Amount.Equals(other.Amount);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Amount = {this.Amount}");
        }
    }
}