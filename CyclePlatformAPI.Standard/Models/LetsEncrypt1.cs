// <copyright file="LetsEncrypt1.cs" company="APIMatic">
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
    /// LetsEncrypt1.
    /// </summary>
    public class LetsEncrypt1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LetsEncrypt1"/> class.
        /// </summary>
        public LetsEncrypt1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LetsEncrypt1"/> class.
        /// </summary>
        /// <param name="enable">enable.</param>
        /// <param name="certificatePath">certificate_path.</param>
        /// <param name="chainPath">chain_path.</param>
        /// <param name="keyPath">key_path.</param>
        /// <param name="bundlePath">bundle_path.</param>
        /// <param name="additionalCertsPath">additional_certs_path.</param>
        public LetsEncrypt1(
            bool enable,
            string certificatePath = null,
            string chainPath = null,
            string keyPath = null,
            string bundlePath = null,
            string additionalCertsPath = null)
        {
            this.Enable = enable;
            this.CertificatePath = certificatePath;
            this.ChainPath = chainPath;
            this.KeyPath = keyPath;
            this.BundlePath = bundlePath;
            this.AdditionalCertsPath = additionalCertsPath;
        }

        /// <summary>
        /// A boolean where true represents the desire for a container to have its corresponding TLS certificate(s) injected into the configured path(s).
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// Path where the `certificate.cert` will be saved.
        /// </summary>
        [JsonProperty("certificate_path", NullValueHandling = NullValueHandling.Ignore)]
        public string CertificatePath { get; set; }

        /// <summary>
        /// Path where the `certificate.chain` will be saved.
        /// </summary>
        [JsonProperty("chain_path", NullValueHandling = NullValueHandling.Ignore)]
        public string ChainPath { get; set; }

        /// <summary>
        /// Path where the `certificate.key` will be saved.
        /// </summary>
        [JsonProperty("key_path", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyPath { get; set; }

        /// <summary>
        /// Path where the `certificate.bundle` will be saved.
        /// </summary>
        [JsonProperty("bundle_path", NullValueHandling = NullValueHandling.Ignore)]
        public string BundlePath { get; set; }

        /// <summary>
        /// File path where any remaining certificate files will be stored.
        /// </summary>
        [JsonProperty("additional_certs_path", NullValueHandling = NullValueHandling.Ignore)]
        public string AdditionalCertsPath { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LetsEncrypt1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is LetsEncrypt1 other &&                this.Enable.Equals(other.Enable) &&
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