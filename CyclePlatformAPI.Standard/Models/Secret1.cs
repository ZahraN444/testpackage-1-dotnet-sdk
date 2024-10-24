// <copyright file="Secret1.cs" company="APIMatic">
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
    /// Secret1.
    /// </summary>
    public class Secret1
    {
        private string hint;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "hint", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Secret1"/> class.
        /// </summary>
        public Secret1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Secret1"/> class.
        /// </summary>
        /// <param name="iv">iv.</param>
        /// <param name="hint">hint.</param>
        public Secret1(
            string iv = null,
            string hint = null)
        {
            this.Iv = iv;
            if (hint != null)
            {
                this.Hint = hint;
            }

        }

        /// <summary>
        /// A string describing the IV Hex associated with the encryption of the variable
        /// </summary>
        [JsonProperty("iv", NullValueHandling = NullValueHandling.Ignore)]
        public string Iv { get; set; }

        /// <summary>
        /// A user specified hint that will suggest what the encryption key might be
        /// </summary>
        [JsonProperty("hint")]
        public string Hint
        {
            get
            {
                return this.hint;
            }

            set
            {
                this.shouldSerialize["hint"] = true;
                this.hint = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Secret1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHint()
        {
            this.shouldSerialize["hint"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHint()
        {
            return this.shouldSerialize["hint"];
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
            return obj is Secret1 other &&                ((this.Iv == null && other.Iv == null) || (this.Iv?.Equals(other.Iv) == true)) &&
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