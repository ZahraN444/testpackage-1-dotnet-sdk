// <copyright file="FailOn.cs" company="APIMatic">
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
    /// FailOn.
    /// </summary>
    public class FailOn
    {
        private List<int> httpCodes;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "http_codes", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="FailOn"/> class.
        /// </summary>
        public FailOn()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FailOn"/> class.
        /// </summary>
        /// <param name="not">not.</param>
        /// <param name="httpCodes">http_codes.</param>
        public FailOn(
            bool not,
            List<int> httpCodes = null)
        {
            this.Not = not;
            if (httpCodes != null)
            {
                this.HttpCodes = httpCodes;
            }

        }

        /// <summary>
        /// If true, will fail on any codes NOT defined in the http_codes array.
        /// </summary>
        [JsonProperty("not")]
        public bool Not { get; set; }

        /// <summary>
        /// A list of http response codes that will trigger a failure.
        /// </summary>
        [JsonProperty("http_codes")]
        public List<int> HttpCodes
        {
            get
            {
                return this.httpCodes;
            }

            set
            {
                this.shouldSerialize["http_codes"] = true;
                this.httpCodes = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FailOn : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHttpCodes()
        {
            this.shouldSerialize["http_codes"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHttpCodes()
        {
            return this.shouldSerialize["http_codes"];
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
            return obj is FailOn other &&                this.Not.Equals(other.Not) &&
                ((this.HttpCodes == null && other.HttpCodes == null) || (this.HttpCodes?.Equals(other.HttpCodes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Not = {this.Not}");
            toStringOutput.Add($"this.HttpCodes = {(this.HttpCodes == null ? "null" : $"[{string.Join(", ", this.HttpCodes)} ]")}");
        }
    }
}