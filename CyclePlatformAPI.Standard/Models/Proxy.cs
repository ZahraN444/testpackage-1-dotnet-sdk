// <copyright file="Proxy.cs" company="APIMatic">
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
    /// Proxy.
    /// </summary>
    public class Proxy
    {
        private string domain;
        private Models.ContentMod contentMod;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "domain", false },
            { "content_mod", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Proxy"/> class.
        /// </summary>
        public Proxy()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Proxy"/> class.
        /// </summary>
        /// <param name="domain">domain.</param>
        /// <param name="contentMod">content_mod.</param>
        public Proxy(
            string domain = null,
            Models.ContentMod contentMod = null)
        {
            if (domain != null)
            {
                this.Domain = domain;
            }

            if (contentMod != null)
            {
                this.ContentMod = contentMod;
            }

        }

        /// <summary>
        /// The proxy domain for this router.
        /// </summary>
        [JsonProperty("domain")]
        public string Domain
        {
            get
            {
                return this.domain;
            }

            set
            {
                this.shouldSerialize["domain"] = true;
                this.domain = value;
            }
        }

        /// <summary>
        /// Allows the load balancer to modify content before it reaches the user.
        /// </summary>
        [JsonProperty("content_mod")]
        public Models.ContentMod ContentMod
        {
            get
            {
                return this.contentMod;
            }

            set
            {
                this.shouldSerialize["content_mod"] = true;
                this.contentMod = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Proxy : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDomain()
        {
            this.shouldSerialize["domain"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetContentMod()
        {
            this.shouldSerialize["content_mod"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDomain()
        {
            return this.shouldSerialize["domain"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeContentMod()
        {
            return this.shouldSerialize["content_mod"];
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
            return obj is Proxy other &&                ((this.Domain == null && other.Domain == null) || (this.Domain?.Equals(other.Domain) == true)) &&
                ((this.ContentMod == null && other.ContentMod == null) || (this.ContentMod?.Equals(other.ContentMod) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Domain = {(this.Domain == null ? "null" : this.Domain)}");
            toStringOutput.Add($"this.ContentMod = {(this.ContentMod == null ? "null" : this.ContentMod.ToString())}");
        }
    }
}