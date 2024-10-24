// <copyright file="Redirect.cs" company="APIMatic">
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
    /// Redirect.
    /// </summary>
    public class Redirect
    {
        private int? port;
        private string scheme;
        private string url;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "port", false },
            { "scheme", false },
            { "url", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Redirect"/> class.
        /// </summary>
        public Redirect()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Redirect"/> class.
        /// </summary>
        /// <param name="autoHttpsRedirect">auto_https_redirect.</param>
        /// <param name="removeWww">remove_www.</param>
        /// <param name="port">port.</param>
        /// <param name="scheme">scheme.</param>
        /// <param name="url">url.</param>
        public Redirect(
            bool autoHttpsRedirect,
            bool removeWww,
            int? port = null,
            string scheme = null,
            string url = null)
        {
            this.AutoHttpsRedirect = autoHttpsRedirect;
            this.RemoveWww = removeWww;
            if (port != null)
            {
                this.Port = port;
            }

            if (scheme != null)
            {
                this.Scheme = scheme;
            }

            if (url != null)
            {
                this.Url = url;
            }

        }

        /// <summary>
        /// If enabled and a sibling controller exists for port 443, requests will be auto redirected to it. Essentially sets up automatic TLS redirection for this router.
        /// </summary>
        [JsonProperty("auto_https_redirect")]
        public bool AutoHttpsRedirect { get; set; }

        /// <summary>
        /// If true, any request comes in with "www" prefix will be permanently redirected to the same path without www.
        /// </summary>
        [JsonProperty("remove_www")]
        public bool RemoveWww { get; set; }

        /// <summary>
        /// The port to redirect traffic to.
        /// </summary>
        [JsonProperty("port")]
        public int? Port
        {
            get
            {
                return this.port;
            }

            set
            {
                this.shouldSerialize["port"] = true;
                this.port = value;
            }
        }

        /// <summary>
        /// The scheme to redirect to. (i.e. `https`)
        /// </summary>
        [JsonProperty("scheme")]
        public string Scheme
        {
            get
            {
                return this.scheme;
            }

            set
            {
                this.shouldSerialize["scheme"] = true;
                this.scheme = value;
            }
        }

        /// <summary>
        /// A specific URL to redirect to.
        /// </summary>
        [JsonProperty("url")]
        public string Url
        {
            get
            {
                return this.url;
            }

            set
            {
                this.shouldSerialize["url"] = true;
                this.url = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Redirect : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPort()
        {
            this.shouldSerialize["port"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetScheme()
        {
            this.shouldSerialize["scheme"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUrl()
        {
            this.shouldSerialize["url"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePort()
        {
            return this.shouldSerialize["port"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeScheme()
        {
            return this.shouldSerialize["scheme"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUrl()
        {
            return this.shouldSerialize["url"];
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
            return obj is Redirect other &&                this.AutoHttpsRedirect.Equals(other.AutoHttpsRedirect) &&
                this.RemoveWww.Equals(other.RemoveWww) &&
                ((this.Port == null && other.Port == null) || (this.Port?.Equals(other.Port) == true)) &&
                ((this.Scheme == null && other.Scheme == null) || (this.Scheme?.Equals(other.Scheme) == true)) &&
                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AutoHttpsRedirect = {this.AutoHttpsRedirect}");
            toStringOutput.Add($"this.RemoveWww = {this.RemoveWww}");
            toStringOutput.Add($"this.Port = {(this.Port == null ? "null" : this.Port.ToString())}");
            toStringOutput.Add($"this.Scheme = {(this.Scheme == null ? "null" : this.Scheme)}");
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
        }
    }
}