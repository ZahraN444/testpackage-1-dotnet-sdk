// <copyright file="Secret.cs" company="APIMatic">
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
    /// Secret.
    /// </summary>
    public class Secret
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Secret"/> class.
        /// </summary>
        public Secret()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Secret"/> class.
        /// </summary>
        /// <param name="iv">iv.</param>
        /// <param name="hint">hint.</param>
        public Secret(
            string iv = null,
            string hint = null)
        {
            this.Iv = iv;
            this.Hint = hint;
        }

        /// <summary>
        /// A string describing the IV Hex associated with the encryption of the variable
        /// </summary>
        [JsonProperty("iv", NullValueHandling = NullValueHandling.Ignore)]
        public string Iv { get; set; }

        /// <summary>
        /// A user specified hint that will suggest what the encryption key might be
        /// </summary>
        [JsonProperty("hint", NullValueHandling = NullValueHandling.Ignore)]
        public string Hint { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Secret : ({string.Join(", ", toStringOutput)})";
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
            return obj is Secret other &&                ((this.Iv == null && other.Iv == null) || (this.Iv?.Equals(other.Iv) == true)) &&
                ((this.Hint == null && other.Hint == null) || (this.Hint?.Equals(other.Hint) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Iv = {(this.Iv == null ? "null" : this.Iv)}");
            toStringOutput.Add($"this.Hint = {(this.Hint == null ? "null" : this.Hint)}");
        }
    }
}