// <copyright file="LetsEncrypt.cs" company="APIMatic">
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
    /// LetsEncrypt.
    /// </summary>
    public class LetsEncrypt
    {
        private string certificatePath;
        private string chainPath;
        private string keyPath;
        private string bundlePath;
        private string additionalCertsPath;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "certificate_path", false },
            { "chain_path", false },
            { "key_path", false },
            { "bundle_path", false },
            { "additional_certs_path", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="LetsEncrypt"/> class.
        /// </summary>
        public LetsEncrypt()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LetsEncrypt"/> class.
        /// </summary>
        /// <param name="enable">enable.</param>
        /// <param name="certificatePath">certificate_path.</param>
        /// <param name="chainPath">chain_path.</param>
        /// <param name="keyPath">key_path.</param>
        /// <param name="bundlePath">bundle_path.</param>
        /// <param name="additionalCertsPath">additional_certs_path.</param>
        public LetsEncrypt(
            bool enable,
            string certificatePath = null,
            string chainPath = null,
            string keyPath = null,
            string bundlePath = null,
            string additionalCertsPath = null)
        {
            this.Enable = enable;
            if (certificatePath != null)
            {
                this.CertificatePath = certificatePath;
            }

            if (chainPath != null)
            {
                this.ChainPath = chainPath;
            }

            if (keyPath != null)
            {
                this.KeyPath = keyPath;
            }

            if (bundlePath != null)
            {
                this.BundlePath = bundlePath;
            }

            if (additionalCertsPath != null)
            {
                this.AdditionalCertsPath = additionalCertsPath;
            }

        }

        /// <summary>
        /// Gets or sets Enable.
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// Gets or sets CertificatePath.
        /// </summary>
        [JsonProperty("certificate_path")]
        public string CertificatePath
        {
            get
            {
                return this.certificatePath;
            }

            set
            {
                this.shouldSerialize["certificate_path"] = true;
                this.certificatePath = value;
            }
        }

        /// <summary>
        /// Gets or sets ChainPath.
        /// </summary>
        [JsonProperty("chain_path")]
        public string ChainPath
        {
            get
            {
                return this.chainPath;
            }

            set
            {
                this.shouldSerialize["chain_path"] = true;
                this.chainPath = value;
            }
        }

        /// <summary>
        /// Gets or sets KeyPath.
        /// </summary>
        [JsonProperty("key_path")]
        public string KeyPath
        {
            get
            {
                return this.keyPath;
            }

            set
            {
                this.shouldSerialize["key_path"] = true;
                this.keyPath = value;
            }
        }

        /// <summary>
        /// Gets or sets BundlePath.
        /// </summary>
        [JsonProperty("bundle_path")]
        public string BundlePath
        {
            get
            {
                return this.bundlePath;
            }

            set
            {
                this.shouldSerialize["bundle_path"] = true;
                this.bundlePath = value;
            }
        }

        /// <summary>
        /// Gets or sets AdditionalCertsPath.
        /// </summary>
        [JsonProperty("additional_certs_path")]
        public string AdditionalCertsPath
        {
            get
            {
                return this.additionalCertsPath;
            }

            set
            {
                this.shouldSerialize["additional_certs_path"] = true;
                this.additionalCertsPath = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LetsEncrypt : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCertificatePath()
        {
            this.shouldSerialize["certificate_path"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetChainPath()
        {
            this.shouldSerialize["chain_path"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetKeyPath()
        {
            this.shouldSerialize["key_path"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBundlePath()
        {
            this.shouldSerialize["bundle_path"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAdditionalCertsPath()
        {
            this.shouldSerialize["additional_certs_path"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCertificatePath()
        {
            return this.shouldSerialize["certificate_path"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChainPath()
        {
            return this.shouldSerialize["chain_path"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeKeyPath()
        {
            return this.shouldSerialize["key_path"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBundlePath()
        {
            return this.shouldSerialize["bundle_path"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditionalCertsPath()
        {
            return this.shouldSerialize["additional_certs_path"];
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
            return obj is LetsEncrypt other &&                this.Enable.Equals(other.Enable) &&
                ((this.CertificatePath == null && other.CertificatePath == null) || (this.CertificatePath?.Equals(other.CertificatePath) == true)) &&
                ((this.ChainPath == null && other.ChainPath == null) || (this.ChainPath?.Equals(other.ChainPath) == true)) &&
                ((this.KeyPath == null && other.KeyPath == null) || (this.KeyPath?.Equals(other.KeyPath) == true)) &&
                ((this.BundlePath == null && other.BundlePath == null) || (this.BundlePath?.Equals(other.BundlePath) == true)) &&
                ((this.AdditionalCertsPath == null && other.AdditionalCertsPath == null) || (this.AdditionalCertsPath?.Equals(other.AdditionalCertsPath) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Enable = {this.Enable}");
            toStringOutput.Add($"this.CertificatePath = {(this.CertificatePath == null ? "null" : this.CertificatePath)}");
            toStringOutput.Add($"this.ChainPath = {(this.ChainPath == null ? "null" : this.ChainPath)}");
            toStringOutput.Add($"this.KeyPath = {(this.KeyPath == null ? "null" : this.KeyPath)}");
            toStringOutput.Add($"this.BundlePath = {(this.BundlePath == null ? "null" : this.BundlePath)}");
            toStringOutput.Add($"this.AdditionalCertsPath = {(this.AdditionalCertsPath == null ? "null" : this.AdditionalCertsPath)}");
        }
    }
}