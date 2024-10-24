// <copyright file="Details23.cs" company="APIMatic">
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
    /// Details23.
    /// </summary>
    public class Details23
    {
        private Models.Secret1 secret;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "secret", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Details23"/> class.
        /// </summary>
        public Details23()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details23"/> class.
        /// </summary>
        /// <param name="mValue">value.</param>
        /// <param name="blob">blob.</param>
        /// <param name="secret">secret.</param>
        public Details23(
            string mValue,
            bool blob,
            Models.Secret1 secret = null)
        {
            this.MValue = mValue;
            this.Blob = blob;
            if (secret != null)
            {
                this.Secret = secret;
            }

        }

        /// <summary>
        /// The value of the variable.
        /// </summary>
        [JsonProperty("value")]
        public string MValue { get; set; }

        /// <summary>
        /// A boolean where true represents the text the user is entering will be multi line.
        /// </summary>
        [JsonProperty("blob")]
        public bool Blob { get; set; }

        /// <summary>
        /// Gets or sets Secret.
        /// </summary>
        [JsonProperty("secret")]
        public Models.Secret1 Secret
        {
            get
            {
                return this.secret;
            }

            set
            {
                this.shouldSerialize["secret"] = true;
                this.secret = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details23 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSecret()
        {
            this.shouldSerialize["secret"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSecret()
        {
            return this.shouldSerialize["secret"];
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
            return obj is Details23 other &&                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                this.Blob.Equals(other.Blob) &&
                ((this.Secret == null && other.Secret == null) || (this.Secret?.Equals(other.Secret) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue)}");
            toStringOutput.Add($"this.Blob = {this.Blob}");
            toStringOutput.Add($"this.Secret = {(this.Secret == null ? "null" : this.Secret.ToString())}");
        }
    }
}