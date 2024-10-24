// <copyright file="ContentMod.cs" company="APIMatic">
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
    /// ContentMod.
    /// </summary>
    public class ContentMod
    {
        private List<Models.Replace> replace;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "replace", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentMod"/> class.
        /// </summary>
        public ContentMod()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentMod"/> class.
        /// </summary>
        /// <param name="replace">replace.</param>
        public ContentMod(
            List<Models.Replace> replace = null)
        {
            if (replace != null)
            {
                this.Replace = replace;
            }

        }

        /// <summary>
        /// An array that describes a list of replacement match/value pairs.
        /// </summary>
        [JsonProperty("replace")]
        public List<Models.Replace> Replace
        {
            get
            {
                return this.replace;
            }

            set
            {
                this.shouldSerialize["replace"] = true;
                this.replace = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContentMod : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReplace()
        {
            this.shouldSerialize["replace"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReplace()
        {
            return this.shouldSerialize["replace"];
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
            return obj is ContentMod other &&                ((this.Replace == null && other.Replace == null) || (this.Replace?.Equals(other.Replace) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Replace = {(this.Replace == null ? "null" : $"[{string.Join(", ", this.Replace)} ]")}");
        }
    }
}