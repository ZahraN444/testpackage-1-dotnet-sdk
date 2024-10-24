// <copyright file="Forward.cs" company="APIMatic">
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
    /// Forward.
    /// </summary>
    public class Forward
    {
        private string scheme;
        private Models.ContentMod contentMod;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "scheme", false },
            { "content_mod", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Forward"/> class.
        /// </summary>
        public Forward()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Forward"/> class.
        /// </summary>
        /// <param name="scheme">scheme.</param>
        /// <param name="contentMod">content_mod.</param>
        public Forward(
            string scheme = null,
            Models.ContentMod contentMod = null)
        {
            if (scheme != null)
            {
                this.Scheme = scheme;
            }

            if (contentMod != null)
            {
                this.ContentMod = contentMod;
            }

        }

        /// <summary>
        /// Gets or sets Scheme.
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

            return $"Forward : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetContentMod()
        {
            this.shouldSerialize["content_mod"] = false;
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
            return obj is Forward other &&                ((this.Scheme == null && other.Scheme == null) || (this.Scheme?.Equals(other.Scheme) == true)) &&
                ((this.ContentMod == null && other.ContentMod == null) || (this.ContentMod?.Equals(other.ContentMod) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Scheme = {(this.Scheme == null ? "null" : this.Scheme)}");
            toStringOutput.Add($"this.ContentMod = {(this.ContentMod == null ? "null" : this.ContentMod.ToString())}");
        }
    }
}