// <copyright file="Auth3.cs" company="APIMatic">
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
    /// Auth3.
    /// </summary>
    public class Auth3
    {
        private string regex;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "regex", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Auth3"/> class.
        /// </summary>
        public Auth3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Auth3"/> class.
        /// </summary>
        /// <param name="required">required.</param>
        /// <param name="description">description.</param>
        /// <param name="regex">regex.</param>
        public Auth3(
            bool required,
            string description,
            string regex = null)
        {
            if (regex != null)
            {
                this.Regex = regex;
            }

            this.Required = required;
            this.Description = description;
        }

        /// <summary>
        /// Gets or sets Regex.
        /// </summary>
        [JsonProperty("regex")]
        public string Regex
        {
            get
            {
                return this.regex;
            }

            set
            {
                this.shouldSerialize["regex"] = true;
                this.regex = value;
            }
        }

        /// <summary>
        /// Gets or sets Required.
        /// </summary>
        [JsonProperty("required")]
        public bool Required { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Auth3 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRegex()
        {
            this.shouldSerialize["regex"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRegex()
        {
            return this.shouldSerialize["regex"];
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
            return obj is Auth3 other &&                ((this.Regex == null && other.Regex == null) || (this.Regex?.Equals(other.Regex) == true)) &&
                this.Required.Equals(other.Required) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Regex = {(this.Regex == null ? "null" : this.Regex)}");
            toStringOutput.Add($"this.Required = {this.Required}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
        }
    }
}