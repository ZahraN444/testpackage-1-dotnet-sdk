// <copyright file="Stateful.cs" company="APIMatic">
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
    /// Stateful.
    /// </summary>
    public class Stateful
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stateful"/> class.
        /// </summary>
        public Stateful()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stateful"/> class.
        /// </summary>
        /// <param name="options">options.</param>
        public Stateful(
            Models.Options options = null)
        {
            this.Options = options;
        }

        /// <summary>
        /// Gets or sets Options.
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Include)]
        public Models.Options Options { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Stateful : ({string.Join(", ", toStringOutput)})";
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
            return obj is Stateful other &&                ((this.Options == null && other.Options == null) || (this.Options?.Equals(other.Options) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Options = {(this.Options == null ? "null" : this.Options.ToString())}");
        }
    }
}