// <copyright file="RegistryAuthProviderCredentials.cs" company="APIMatic">
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
    /// RegistryAuthProviderCredentials.
    /// </summary>
    public class RegistryAuthProviderCredentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistryAuthProviderCredentials"/> class.
        /// </summary>
        public RegistryAuthProviderCredentials()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistryAuthProviderCredentials"/> class.
        /// </summary>
        /// <param name="region">region.</param>
        /// <param name="mNamespace">namespace.</param>
        /// <param name="apiKey">api_key.</param>
        /// <param name="secret">secret.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="clientId">client_id.</param>
        /// <param name="config">config.</param>
        public RegistryAuthProviderCredentials(
            string region = null,
            string mNamespace = null,
            string apiKey = null,
            string secret = null,
            string subscriptionId = null,
            string clientId = null,
            string config = null)
        {
            this.Region = region;
            this.MNamespace = mNamespace;
            this.ApiKey = apiKey;
            this.Secret = secret;
            this.SubscriptionId = subscriptionId;
            this.ClientId = clientId;
            this.Config = config;
        }

        /// <summary>
        /// Gets or sets Region.
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets MNamespace.
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string MNamespace { get; set; }

        /// <summary>
        /// Gets or sets ApiKey.
        /// </summary>
        [JsonProperty("api_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets Secret.
        /// </summary>
        [JsonProperty("secret", NullValueHandling = NullValueHandling.Ignore)]
        public string Secret { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets ClientId.
        /// </summary>
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        /// <summary>
        /// A base64'd string of additional configuration options.
        /// </summary>
        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public string Config { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RegistryAuthProviderCredentials : ({string.Join(", ", toStringOutput)})";
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
            return obj is RegistryAuthProviderCredentials other &&                ((this.Region == null && other.Region == null) || (this.Region?.Equals(other.Region) == true)) &&
                ((this.MNamespace == null && other.MNamespace == null) || (this.MNamespace?.Equals(other.MNamespace) == true)) &&
                ((this.ApiKey == null && other.ApiKey == null) || (this.ApiKey?.Equals(other.ApiKey) == true)) &&
                ((this.Secret == null && other.Secret == null) || (this.Secret?.Equals(other.Secret) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.ClientId == null && other.ClientId == null) || (this.ClientId?.Equals(other.ClientId) == true)) &&
                ((this.Config == null && other.Config == null) || (this.Config?.Equals(other.Config) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Region = {(this.Region == null ? "null" : this.Region)}");
            toStringOutput.Add($"this.MNamespace = {(this.MNamespace == null ? "null" : this.MNamespace)}");
            toStringOutput.Add($"this.ApiKey = {(this.ApiKey == null ? "null" : this.ApiKey)}");
            toStringOutput.Add($"this.Secret = {(this.Secret == null ? "null" : this.Secret)}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId)}");
            toStringOutput.Add($"this.ClientId = {(this.ClientId == null ? "null" : this.ClientId)}");
            toStringOutput.Add($"this.Config = {(this.Config == null ? "null" : this.Config)}");
        }
    }
}