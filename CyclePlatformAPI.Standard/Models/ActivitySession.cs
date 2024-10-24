// <copyright file="ActivitySession.cs" company="APIMatic">
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
    /// ActivitySession.
    /// </summary>
    public class ActivitySession
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitySession"/> class.
        /// </summary>
        public ActivitySession()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivitySession"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="ip">ip.</param>
        /// <param name="token">token.</param>
        /// <param name="apiKey">api_key.</param>
        public ActivitySession(
            string url,
            string ip,
            Models.Token token = null,
            string apiKey = null)
        {
            this.Url = url;
            this.Ip = ip;
            this.Token = token;
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// URL endpoint assocaited with the activity context - does not include domain.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("url")]
        [JsonRequired]
        public string Url { get; set; }

        /// <summary>
        /// The IP of the account associated with the session.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("ip")]
        [JsonRequired]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or sets Token.
        /// </summary>
        [JsonProperty("token", NullValueHandling = NullValueHandling.Include)]
        public Models.Token Token { get; set; }

        /// <summary>
        /// The API key ID.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("api_key", NullValueHandling = NullValueHandling.Include)]
        public string ApiKey { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ActivitySession : ({string.Join(", ", toStringOutput)})";
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
            return obj is ActivitySession other &&                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
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