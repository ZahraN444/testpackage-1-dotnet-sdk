// <copyright file="IntegrationAuth.cs" company="APIMatic">
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
    /// IntegrationAuth.
    /// </summary>
    public class IntegrationAuth
    {
        private string region;
        private string mNamespace;
        private string apiKey;
        private string keyId;
        private string secret;
        private string subscriptionId;
        private string clientId;
        private string base64Config;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "region", false },
            { "namespace", false },
            { "api_key", false },
            { "key_id", false },
            { "secret", false },
            { "subscription_id", false },
            { "client_id", false },
            { "base64_config", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationAuth"/> class.
        /// </summary>
        public IntegrationAuth()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationAuth"/> class.
        /// </summary>
        /// <param name="region">region.</param>
        /// <param name="mNamespace">namespace.</param>
        /// <param name="apiKey">api_key.</param>
        /// <param name="keyId">key_id.</param>
        /// <param name="secret">secret.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="clientId">client_id.</param>
        /// <param name="base64Config">base64_config.</param>
        public IntegrationAuth(
            string region = null,
            string mNamespace = null,
            string apiKey = null,
            string keyId = null,
            string secret = null,
            string subscriptionId = null,
            string clientId = null,
            string base64Config = null)
        {
            if (region != null)
            {
                this.Region = region;
            }

            if (mNamespace != null)
            {
                this.MNamespace = mNamespace;
            }

            if (apiKey != null)
            {
                this.ApiKey = apiKey;
            }

            if (keyId != null)
            {
                this.KeyId = keyId;
            }

            if (secret != null)
            {
                this.Secret = secret;
            }

            if (subscriptionId != null)
            {
                this.SubscriptionId = subscriptionId;
            }

            if (clientId != null)
            {
                this.ClientId = clientId;
            }

            if (base64Config != null)
            {
                this.Base64Config = base64Config;
            }

        }

        /// <summary>
        /// The region associated with the Integration.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("region")]
        public string Region
        {
            get
            {
                return this.region;
            }

            set
            {
                this.shouldSerialize["region"] = true;
                this.region = value;
            }
        }

        /// <summary>
        /// The namespace associated with the Integration.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("namespace")]
        public string MNamespace
        {
            get
            {
                return this.mNamespace;
            }

            set
            {
                this.shouldSerialize["namespace"] = true;
                this.mNamespace = value;
            }
        }

        /// <summary>
        /// API key for accessing the Integration.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
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

        /// <summary>
        /// Key ID for accessing the Integration.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("key_id")]
        public string KeyId
        {
            get
            {
                return this.keyId;
            }

            set
            {
                this.shouldSerialize["key_id"] = true;
                this.keyId = value;
            }
        }

        /// <summary>
        /// Secret for accessing the Integration.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("secret")]
        public string Secret
        {
            get
            {
                return this.secret;
            }

            set
            {
                this.shouldSerialize["secret"] = true;
                this.secret = value;
            }
        }

        /// <summary>
        /// Subscription ID for the Integration.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("subscription_id")]
        public string SubscriptionId
        {
            get
            {
                return this.subscriptionId;
            }

            set
            {
                this.shouldSerialize["subscription_id"] = true;
                this.subscriptionId = value;
            }
        }

        /// <summary>
        /// Client ID for the Integration.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("client_id")]
        public string ClientId
        {
            get
            {
                return this.clientId;
            }

            set
            {
                this.shouldSerialize["client_id"] = true;
                this.clientId = value;
            }
        }

        /// <summary>
        /// Base64 encoded configuration for the Integration.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("base64_config")]
        public string Base64Config
        {
            get
            {
                return this.base64Config;
            }

            set
            {
                this.shouldSerialize["base64_config"] = true;
                this.base64Config = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IntegrationAuth : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRegion()
        {
            this.shouldSerialize["region"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNamespace()
        {
            this.shouldSerialize["namespace"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetApiKey()
        {
            this.shouldSerialize["api_key"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetKeyId()
        {
            this.shouldSerialize["key_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSecret()
        {
            this.shouldSerialize["secret"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSubscriptionId()
        {
            this.shouldSerialize["subscription_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetClientId()
        {
            this.shouldSerialize["client_id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBase64Config()
        {
            this.shouldSerialize["base64_config"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRegion()
        {
            return this.shouldSerialize["region"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNamespace()
        {
            return this.shouldSerialize["namespace"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeApiKey()
        {
            return this.shouldSerialize["api_key"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeKeyId()
        {
            return this.shouldSerialize["key_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSecret()
        {
            return this.shouldSerialize["secret"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSubscriptionId()
        {
            return this.shouldSerialize["subscription_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeClientId()
        {
            return this.shouldSerialize["client_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBase64Config()
        {
            return this.shouldSerialize["base64_config"];
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
            return obj is IntegrationAuth other &&                ((this.Region == null && other.Region == null) || (this.Region?.Equals(other.Region) == true)) &&
                ((this.MNamespace == null && other.MNamespace == null) || (this.MNamespace?.Equals(other.MNamespace) == true)) &&
                ((this.ApiKey == null && other.ApiKey == null) || (this.ApiKey?.Equals(other.ApiKey) == true)) &&
                ((this.KeyId == null && other.KeyId == null) || (this.KeyId?.Equals(other.KeyId) == true)) &&
                ((this.Secret == null && other.Secret == null) || (this.Secret?.Equals(other.Secret) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true)) &&
                ((this.ClientId == null && other.ClientId == null) || (this.ClientId?.Equals(other.ClientId) == true)) &&
                ((this.Base64Config == null && other.Base64Config == null) || (this.Base64Config?.Equals(other.Base64Config) == true));
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
            toStringOutput.Add($"this.KeyId = {(this.KeyId == null ? "null" : this.KeyId)}");
            toStringOutput.Add($"this.Secret = {(this.Secret == null ? "null" : this.Secret)}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId)}");
            toStringOutput.Add($"this.ClientId = {(this.ClientId == null ? "null" : this.ClientId)}");
            toStringOutput.Add($"this.Base64Config = {(this.Base64Config == null ? "null" : this.Base64Config)}");
        }
    }
}