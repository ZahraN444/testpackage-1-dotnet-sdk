// <copyright file="InvoiceMeta.cs" company="APIMatic">
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
    /// InvoiceMeta.
    /// </summary>
    public class InvoiceMeta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceMeta"/> class.
        /// </summary>
        public InvoiceMeta()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceMeta"/> class.
        /// </summary>
        /// <param name="due">due.</param>
        public InvoiceMeta(
            int? due = null)
        {
            this.Due = due;
        }

        /// <summary>
        /// The amount due for a given invoice.
        /// </summary>
        [JsonProperty("due", NullValueHandling = NullValueHandling.Ignore)]
        public int? Due { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceMeta : ({string.Join(", ", toStringOutput)})";
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
            return obj is InvoiceMeta other &&                ((this.Due == null && other.Due == null) || (this.Due?.Equals(other.Due) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Due = {(this.Due == null ? "null" : this.Due.ToString())}");
        }
    }
}