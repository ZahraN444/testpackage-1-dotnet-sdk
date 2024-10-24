// <copyright file="Data6.cs" company="APIMatic">
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
    /// Data6.
    /// </summary>
    public class Data6
    {
        private List<Models.IntegrationDefinition> imageBuilders;
        private List<Models.IntegrationDefinition> objectStorage;
        private List<Models.IntegrationDefinition> tlsCertificateGeneration;
        private List<Models.IntegrationDefinition> infrastructureProvider;
        private List<Models.IntegrationDefinition> billing;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "image-builders", false },
            { "object-storage", false },
            { "tls-certificate-generation", false },
            { "infrastructure-provider", false },
            { "billing", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Data6"/> class.
        /// </summary>
        public Data6()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Data6"/> class.
        /// </summary>
        /// <param name="imageBuilders">image-builders.</param>
        /// <param name="objectStorage">object-storage.</param>
        /// <param name="tlsCertificateGeneration">tls-certificate-generation.</param>
        /// <param name="infrastructureProvider">infrastructure-provider.</param>
        /// <param name="billing">billing.</param>
        public Data6(
            List<Models.IntegrationDefinition> imageBuilders = null,
            List<Models.IntegrationDefinition> objectStorage = null,
            List<Models.IntegrationDefinition> tlsCertificateGeneration = null,
            List<Models.IntegrationDefinition> infrastructureProvider = null,
            List<Models.IntegrationDefinition> billing = null)
        {
            if (imageBuilders != null)
            {
                this.ImageBuilders = imageBuilders;
            }

            if (objectStorage != null)
            {
                this.ObjectStorage = objectStorage;
            }

            if (tlsCertificateGeneration != null)
            {
                this.TlsCertificateGeneration = tlsCertificateGeneration;
            }

            if (infrastructureProvider != null)
            {
                this.InfrastructureProvider = infrastructureProvider;
            }

            if (billing != null)
            {
                this.Billing = billing;
            }

        }

        /// <summary>
        /// Gets or sets ImageBuilders.
        /// </summary>
        [JsonProperty("image-builders")]
        public List<Models.IntegrationDefinition> ImageBuilders
        {
            get
            {
                return this.imageBuilders;
            }

            set
            {
                this.shouldSerialize["image-builders"] = true;
                this.imageBuilders = value;
            }
        }

        /// <summary>
        /// Gets or sets ObjectStorage.
        /// </summary>
        [JsonProperty("object-storage")]
        public List<Models.IntegrationDefinition> ObjectStorage
        {
            get
            {
                return this.objectStorage;
            }

            set
            {
                this.shouldSerialize["object-storage"] = true;
                this.objectStorage = value;
            }
        }

        /// <summary>
        /// Gets or sets TlsCertificateGeneration.
        /// </summary>
        [JsonProperty("tls-certificate-generation")]
        public List<Models.IntegrationDefinition> TlsCertificateGeneration
        {
            get
            {
                return this.tlsCertificateGeneration;
            }

            set
            {
                this.shouldSerialize["tls-certificate-generation"] = true;
                this.tlsCertificateGeneration = value;
            }
        }

        /// <summary>
        /// Gets or sets InfrastructureProvider.
        /// </summary>
        [JsonProperty("infrastructure-provider")]
        public List<Models.IntegrationDefinition> InfrastructureProvider
        {
            get
            {
                return this.infrastructureProvider;
            }

            set
            {
                this.shouldSerialize["infrastructure-provider"] = true;
                this.infrastructureProvider = value;
            }
        }

        /// <summary>
        /// Gets or sets Billing.
        /// </summary>
        [JsonProperty("billing")]
        public List<Models.IntegrationDefinition> Billing
        {
            get
            {
                return this.billing;
            }

            set
            {
                this.shouldSerialize["billing"] = true;
                this.billing = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Data6 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetImageBuilders()
        {
            this.shouldSerialize["image-builders"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetObjectStorage()
        {
            this.shouldSerialize["object-storage"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTlsCertificateGeneration()
        {
            this.shouldSerialize["tls-certificate-generation"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInfrastructureProvider()
        {
            this.shouldSerialize["infrastructure-provider"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBilling()
        {
            this.shouldSerialize["billing"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeImageBuilders()
        {
            return this.shouldSerialize["image-builders"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeObjectStorage()
        {
            return this.shouldSerialize["object-storage"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTlsCertificateGeneration()
        {
            return this.shouldSerialize["tls-certificate-generation"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInfrastructureProvider()
        {
            return this.shouldSerialize["infrastructure-provider"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBilling()
        {
            return this.shouldSerialize["billing"];
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
            return obj is Data6 other &&                ((this.ImageBuilders == null && other.ImageBuilders == null) || (this.ImageBuilders?.Equals(other.ImageBuilders) == true)) &&
                ((this.ObjectStorage == null && other.ObjectStorage == null) || (this.ObjectStorage?.Equals(other.ObjectStorage) == true)) &&
                ((this.TlsCertificateGeneration == null && other.TlsCertificateGeneration == null) || (this.TlsCertificateGeneration?.Equals(other.TlsCertificateGeneration) == true)) &&
                ((this.InfrastructureProvider == null && other.InfrastructureProvider == null) || (this.InfrastructureProvider?.Equals(other.InfrastructureProvider) == true)) &&
                ((this.Billing == null && other.Billing == null) || (this.Billing?.Equals(other.Billing) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ImageBuilders = {(this.ImageBuilders == null ? "null" : $"[{string.Join(", ", this.ImageBuilders)} ]")}");
            toStringOutput.Add($"this.ObjectStorage = {(this.ObjectStorage == null ? "null" : $"[{string.Join(", ", this.ObjectStorage)} ]")}");
            toStringOutput.Add($"this.TlsCertificateGeneration = {(this.TlsCertificateGeneration == null ? "null" : $"[{string.Join(", ", this.TlsCertificateGeneration)} ]")}");
            toStringOutput.Add($"this.InfrastructureProvider = {(this.InfrastructureProvider == null ? "null" : $"[{string.Join(", ", this.InfrastructureProvider)} ]")}");
            toStringOutput.Add($"this.Billing = {(this.Billing == null ? "null" : $"[{string.Join(", ", this.Billing)} ]")}");
        }
    }
}