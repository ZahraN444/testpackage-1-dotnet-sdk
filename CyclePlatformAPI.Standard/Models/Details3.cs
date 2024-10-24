// <copyright file="Details3.cs" company="APIMatic">
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
    /// Details3.
    /// </summary>
    public class Details3
    {
        private Models.Redirect redirect;
        private Models.Forward forward;
        private Models.Proxy proxy;
        private Models.Caching caching;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "redirect", false },
            { "forward", false },
            { "proxy", false },
            { "caching", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Details3"/> class.
        /// </summary>
        public Details3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details3"/> class.
        /// </summary>
        /// <param name="redirect">redirect.</param>
        /// <param name="forward">forward.</param>
        /// <param name="proxy">proxy.</param>
        /// <param name="caching">caching.</param>
        public Details3(
            Models.Redirect redirect = null,
            Models.Forward forward = null,
            Models.Proxy proxy = null,
            Models.Caching caching = null)
        {
            if (redirect != null)
            {
                this.Redirect = redirect;
            }

            if (forward != null)
            {
                this.Forward = forward;
            }

            if (proxy != null)
            {
                this.Proxy = proxy;
            }

            if (caching != null)
            {
                this.Caching = caching;
            }

        }

        /// <summary>
        /// Defines a built-in redirect for HTTP mode routers
        /// </summary>
        [JsonProperty("redirect")]
        public Models.Redirect Redirect
        {
            get
            {
                return this.redirect;
            }

            set
            {
                this.shouldSerialize["redirect"] = true;
                this.redirect = value;
            }
        }

        /// <summary>
        /// Gets or sets Forward.
        /// </summary>
        [JsonProperty("forward")]
        public Models.Forward Forward
        {
            get
            {
                return this.forward;
            }

            set
            {
                this.shouldSerialize["forward"] = true;
                this.forward = value;
            }
        }

        /// <summary>
        /// Gets or sets Proxy.
        /// </summary>
        [JsonProperty("proxy")]
        public Models.Proxy Proxy
        {
            get
            {
                return this.proxy;
            }

            set
            {
                this.shouldSerialize["proxy"] = true;
                this.proxy = value;
            }
        }

        /// <summary>
        /// Gets or sets Caching.
        /// </summary>
        [JsonProperty("caching")]
        public Models.Caching Caching
        {
            get
            {
                return this.caching;
            }

            set
            {
                this.shouldSerialize["caching"] = true;
                this.caching = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details3 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRedirect()
        {
            this.shouldSerialize["redirect"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetForward()
        {
            this.shouldSerialize["forward"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProxy()
        {
            this.shouldSerialize["proxy"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCaching()
        {
            this.shouldSerialize["caching"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRedirect()
        {
            return this.shouldSerialize["redirect"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeForward()
        {
            return this.shouldSerialize["forward"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProxy()
        {
            return this.shouldSerialize["proxy"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCaching()
        {
            return this.shouldSerialize["caching"];
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
            return obj is Details3 other &&                ((this.Redirect == null && other.Redirect == null) || (this.Redirect?.Equals(other.Redirect) == true)) &&
                ((this.Forward == null && other.Forward == null) || (this.Forward?.Equals(other.Forward) == true)) &&
                ((this.Proxy == null && other.Proxy == null) || (this.Proxy?.Equals(other.Proxy) == true)) &&
                ((this.Caching == null && other.Caching == null) || (this.Caching?.Equals(other.Caching) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Redirect = {(this.Redirect == null ? "null" : this.Redirect.ToString())}");
            toStringOutput.Add($"this.Forward = {(this.Forward == null ? "null" : this.Forward.ToString())}");
            toStringOutput.Add($"this.Proxy = {(this.Proxy == null ? "null" : this.Proxy.ToString())}");
            toStringOutput.Add($"this.Caching = {(this.Caching == null ? "null" : this.Caching.ToString())}");
        }
    }
}