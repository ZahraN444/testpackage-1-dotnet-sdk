// <copyright file="Stateful1.cs" company="APIMatic">
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
    /// Stateful1.
    /// </summary>
    public class Stateful1
    {
        private Models.Options options;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "options", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Stateful1"/> class.
        /// </summary>
        public Stateful1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stateful1"/> class.
        /// </summary>
        /// <param name="options">options.</param>
        public Stateful1(
            Models.Options options = null)
        {
            if (options != null)
            {
                this.Options = options;
            }

        }

        /// <summary>
        /// Gets or sets Options.
        /// </summary>
        [JsonProperty("options")]
        public Models.Options Options
        {
            get
            {
                return this.options;
            }

            set
            {
                this.shouldSerialize["options"] = true;
                this.options = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Stateful1 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOptions()
        {
            this.shouldSerialize["options"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOptions()
        {
            return this.shouldSerialize["options"];
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
            return obj is Stateful1 other &&                ((this.Options == null && other.Options == null) || (this.Options?.Equals(other.Options) == true));
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