// <copyright file="Override3.cs" company="APIMatic">
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
    /// Override3.
    /// </summary>
    public class Override3
    {
        private string target;
        private string targzUrl;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "target", false },
            { "targz_url", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Override3"/> class.
        /// </summary>
        public Override3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Override3"/> class.
        /// </summary>
        /// <param name="target">target.</param>
        /// <param name="targzUrl">targz_url.</param>
        public Override3(
            string target = null,
            string targzUrl = null)
        {
            if (target != null)
            {
                this.Target = target;
            }

            if (targzUrl != null)
            {
                this.TargzUrl = targzUrl;
            }

        }

        /// <summary>
        /// For image sources with `docker-hub` or `docker-registry` origin types. A target to be used for overridding the default target - should include an image and a tag.
        /// </summary>
        [JsonProperty("target")]
        public string Target
        {
            get
            {
                return this.target;
            }

            set
            {
                this.shouldSerialize["target"] = true;
                this.target = value;
            }
        }

        /// <summary>
        /// For image sources with `docker-file` origin types. A URL pointing to a .tar.gz file of a repo with a Dockerfile in it - can be used instead of linking Cycle directly to a repository.
        /// </summary>
        [JsonProperty("targz_url")]
        public string TargzUrl
        {
            get
            {
                return this.targzUrl;
            }

            set
            {
                this.shouldSerialize["targz_url"] = true;
                this.targzUrl = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Override3 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTarget()
        {
            this.shouldSerialize["target"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTargzUrl()
        {
            this.shouldSerialize["targz_url"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTarget()
        {
            return this.shouldSerialize["target"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTargzUrl()
        {
            return this.shouldSerialize["targz_url"];
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
            return obj is Override3 other &&                ((this.Target == null && other.Target == null) || (this.Target?.Equals(other.Target) == true)) &&
                ((this.TargzUrl == null && other.TargzUrl == null) || (this.TargzUrl?.Equals(other.TargzUrl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Target = {(this.Target == null ? "null" : this.Target)}");
            toStringOutput.Add($"this.TargzUrl = {(this.TargzUrl == null ? "null" : this.TargzUrl)}");
        }
    }
}