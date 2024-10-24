// <copyright file="Details57.cs" company="APIMatic">
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
    /// Details57.
    /// </summary>
    public class Details57
    {
        private Dictionary<string, string> headers;
        private string body;
        private string from;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "headers", false },
            { "body", false },
            { "from", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Details57"/> class.
        /// </summary>
        public Details57()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details57"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="headers">headers.</param>
        /// <param name="options">options.</param>
        /// <param name="body">body.</param>
        /// <param name="from">from.</param>
        public Details57(
            string url,
            Dictionary<string, string> headers = null,
            Details57Options options = null,
            string body = null,
            string from = null)
        {
            this.Url = url;
            if (headers != null)
            {
                this.Headers = headers;
            }

            this.Options = options;
            if (body != null)
            {
                this.Body = body;
            }

            if (from != null)
            {
                this.From = from;
            }

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
        public Details57Options Options { get; set; }

        /// <summary>
        /// An optional POST body to send with the request. Cannot be used with `from``.
        /// </summary>
        [JsonProperty("body")]
        public string Body
        {
            get
            {
                return this.body;
            }

            set
            {
                this.shouldSerialize["body"] = true;
                this.body = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// Takes the output from a previous step and uses it as the body for the POST request. Cannot be used with `body`. String format is <stageIdentifier/stepIdentifier>
        /// ]]>
        /// </summary>
        [JsonProperty("from")]
        public string From
        {
            get
            {
                return this.from;
            }

            set
            {
                this.shouldSerialize["from"] = true;
                this.from = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details57 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHeaders()
        {
            this.shouldSerialize["headers"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBody()
        {
            this.shouldSerialize["body"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFrom()
        {
            this.shouldSerialize["from"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHeaders()
        {
            return this.shouldSerialize["headers"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBody()
        {
            return this.shouldSerialize["body"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFrom()
        {
            return this.shouldSerialize["from"];
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
            return obj is Details57 other &&                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.Headers == null && other.Headers == null) || (this.Headers?.Equals(other.Headers) == true)) &&
                ((this.Options == null && other.Options == null) || (this.Options?.Equals(other.Options) == true)) &&
                ((this.Body == null && other.Body == null) || (this.Body?.Equals(other.Body) == true)) &&
                ((this.From == null && other.From == null) || (this.From?.Equals(other.From) == true));
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
            toStringOutput.Add($"this.Body = {(this.Body == null ? "null" : this.Body)}");
            toStringOutput.Add($"this.From = {(this.From == null ? "null" : this.From)}");
        }
    }
}