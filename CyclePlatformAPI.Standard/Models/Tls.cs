// <copyright file="Tls.cs" company="APIMatic">
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
    /// Tls.
    /// </summary>
    public class Tls
    {
        private string serverName;
        private bool? allowInsecure;
        private string clientCertAuth;
        private Models.ClientAuthEnum? clientAuth;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "server_name", false },
            { "allow_insecure", false },
            { "client_cert_auth", false },
            { "client_auth", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Tls"/> class.
        /// </summary>
        public Tls()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tls"/> class.
        /// </summary>
        /// <param name="serverName">server_name.</param>
        /// <param name="allowInsecure">allow_insecure.</param>
        /// <param name="clientCertAuth">client_cert_auth.</param>
        /// <param name="clientAuth">client_auth.</param>
        public Tls(
            string serverName = null,
            bool? allowInsecure = null,
            string clientCertAuth = null,
            Models.ClientAuthEnum? clientAuth = null)
        {
            if (serverName != null)
            {
                this.ServerName = serverName;
            }

            if (allowInsecure != null)
            {
                this.AllowInsecure = allowInsecure;
            }

            if (clientCertAuth != null)
            {
                this.ClientCertAuth = clientCertAuth;
            }

            if (clientAuth != null)
            {
                this.ClientAuth = clientAuth;
            }

        }

        /// <summary>
        /// [Advanced] Change the domain the controller listens on.
        /// </summary>
        [JsonProperty("server_name")]
        public string ServerName
        {
            get
            {
                return this.serverName;
            }

            set
            {
                this.shouldSerialize["server_name"] = true;
                this.serverName = value;
            }
        }

        /// <summary>
        /// If enabled, accept TLS traffic with an invalid certificate. This is usually done for development/testing, and is not recommended for production use.
        /// </summary>
        [JsonProperty("allow_insecure")]
        public bool? AllowInsecure
        {
            get
            {
                return this.allowInsecure;
            }

            set
            {
                this.shouldSerialize["allow_insecure"] = true;
                this.allowInsecure = value;
            }
        }

        /// <summary>
        /// A PEM encoded string of certificates.
        /// </summary>
        [JsonProperty("client_cert_auth")]
        public string ClientCertAuth
        {
            get
            {
                return this.clientCertAuth;
            }

            set
            {
                this.shouldSerialize["client_cert_auth"] = true;
                this.clientCertAuth = value;
            }
        }

        /// <summary>
        /// Defines how to validate the connecting TLS certificate.
        /// `none`: Do not require a TLS certificate to be sent
        /// `request`: Asks the client to send a TLS certificate, but does not require nor validate it.
        /// `require`: Requires a certificate be sent for the request to be valid, but does not validate the certificate.
        /// `require-verify`: Requires both that the client send a certificate, and that the certificate is valid. This is required when using https.
        /// </summary>
        [JsonProperty("client_auth")]
        public Models.ClientAuthEnum? ClientAuth
        {
            get
            {
                return this.clientAuth;
            }

            set
            {
                this.shouldSerialize["client_auth"] = true;
                this.clientAuth = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Tls : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetServerName()
        {
            this.shouldSerialize["server_name"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAllowInsecure()
        {
            this.shouldSerialize["allow_insecure"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetClientCertAuth()
        {
            this.shouldSerialize["client_cert_auth"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetClientAuth()
        {
            this.shouldSerialize["client_auth"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeServerName()
        {
            return this.shouldSerialize["server_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAllowInsecure()
        {
            return this.shouldSerialize["allow_insecure"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeClientCertAuth()
        {
            return this.shouldSerialize["client_cert_auth"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeClientAuth()
        {
            return this.shouldSerialize["client_auth"];
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
            return obj is Tls other &&                ((this.ServerName == null && other.ServerName == null) || (this.ServerName?.Equals(other.ServerName) == true)) &&
                ((this.AllowInsecure == null && other.AllowInsecure == null) || (this.AllowInsecure?.Equals(other.AllowInsecure) == true)) &&
                ((this.ClientCertAuth == null && other.ClientCertAuth == null) || (this.ClientCertAuth?.Equals(other.ClientCertAuth) == true)) &&
                ((this.ClientAuth == null && other.ClientAuth == null) || (this.ClientAuth?.Equals(other.ClientAuth) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ServerName = {(this.ServerName == null ? "null" : this.ServerName)}");
            toStringOutput.Add($"this.AllowInsecure = {(this.AllowInsecure == null ? "null" : this.AllowInsecure.ToString())}");
            toStringOutput.Add($"this.ClientCertAuth = {(this.ClientCertAuth == null ? "null" : this.ClientCertAuth)}");
            toStringOutput.Add($"this.ClientAuth = {(this.ClientAuth == null ? "null" : this.ClientAuth.ToString())}");
        }
    }
}