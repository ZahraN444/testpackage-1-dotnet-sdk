// <copyright file="Details58.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// Details58.
    /// </summary>
    public class Details58
    {
        private Dictionary<string, string> headers;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "headers", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Details58"/> class.
        /// </summary>
        public Details58()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details58"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="headers">headers.</param>
        /// <param name="options">options.</param>
        public Details58(
            string url,
            Dictionary<string, string> headers = null,
            Details58Options options = null)
        {
            this.Url = url;
            if (headers != null)
            {
                this.Headers = headers;
            }

            this.Options = options;
        }

        /// <summary>
        /// The url to submit a POST request to.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// An optional map of headers to send with the request.
        /// </summary>
        [JsonProperty("headers")]
        public Dictionary<string, string> Headers
        {
            get
            {
                return this.headers;
            }

            set
            {
                this.shouldSerialize["headers"] = true;
                this.headers = value;
            }
        }

        /// <summary>
        /// Gets or sets Options.
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public Details58Options Options { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details58 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHeaders()
        {
            this.shouldSerialize["headers"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHeaders()
        {
            return this.shouldSerialize["headers"];
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
            return obj is Details58 other &&                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.Headers == null && other.Headers == null) || (this.Headers?.Equals(other.Headers) == true)) &&
                ((this.Options == null && other.Options == null) || (this.Options?.Equals(other.Options) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"Headers = {(this.Headers == null ? "null" : this.Headers.ToString())}");
            toStringOutput.Add($"Options = {(this.Options == null ? "null" : this.Options.ToString())}");
        }
    }
}