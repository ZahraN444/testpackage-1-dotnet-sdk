// <copyright file="Session.cs" company="APIMatic">
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
    /// Session.
    /// </summary>
    public class Session
    {
        private Models.Token token;
        private string apiKey;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "token", false },
            { "api_key", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Session"/> class.
        /// </summary>
        public Session()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Session"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="ip">ip.</param>
        /// <param name="token">token.</param>
        /// <param name="apiKey">api_key.</param>
        public Session(
            string url = null,
            string ip = null,
            Models.Token token = null,
            string apiKey = null)
        {
            this.Url = url;
            this.Ip = ip;
            if (token != null)
            {
                this.Token = token;
            }

            if (apiKey != null)
            {
                this.ApiKey = apiKey;
            }

        }

        /// <summary>
        /// URL endpoint assocaited with the activity context - does not include domain.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// The IP of the account associated with the session.
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or sets Token.
        /// </summary>
        [JsonProperty("token")]
        public Models.Token Token
        {
            get
            {
                return this.token;
            }

            set
            {
                this.shouldSerialize["token"] = true;
                this.token = value;
            }
        }

        /// <summary>
        /// The API key ID.
        /// </summary>
        [JsonProperty("api_key")]
        public string ApiKey
        {
            get
            {
                return this.apiKey;
            }

            set
            {
                this.shouldSerialize["api_key"] = true;
                this.apiKey = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Session : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetToken()
        {
            this.shouldSerialize["token"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetApiKey()
        {
            this.shouldSerialize["api_key"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeToken()
        {
            return this.shouldSerialize["token"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeApiKey()
        {
            return this.shouldSerialize["api_key"];
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
            return obj is Session other &&                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.Ip == null && other.Ip == null) || (this.Ip?.Equals(other.Ip) == true)) &&
                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true)) &&
                ((this.ApiKey == null && other.ApiKey == null) || (this.ApiKey?.Equals(other.ApiKey) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.Ip = {(this.Ip == null ? "null" : this.Ip)}");
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token.ToString())}");
            toStringOutput.Add($"this.ApiKey = {(this.ApiKey == null ? "null" : this.ApiKey)}");
        }
    }
}