// <copyright file="RepoSourceType.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// RepoSourceType.
    /// </summary>
    public class RepoSourceType
    {
        private RepoSourceTypeAuth auth;
        private Models.Ref mRef;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "auth", false },
            { "ref", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoSourceType"/> class.
        /// </summary>
        public RepoSourceType()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoSourceType"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="branch">branch.</param>
        /// <param name="auth">auth.</param>
        /// <param name="mRef">ref.</param>
        public RepoSourceType(
            string url,
            string branch = null,
            RepoSourceTypeAuth auth = null,
            Models.Ref mRef = null)
        {
            this.Url = url;
            this.Branch = branch;
            if (auth != null)
            {
                this.Auth = auth;
            }

            if (mRef != null)
            {
                this.MRef = mRef;
            }

        }

        /// <summary>
        /// The URL of the repository.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("url")]
        [JsonRequired]
        public string Url { get; set; }

        /// <summary>
        /// An optional branch arguement.  Default value is `master`.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// Authentication information for the repository.
        /// </summary>
        [JsonProperty("auth")]
        public RepoSourceTypeAuth Auth
        {
            get
            {
                return this.auth;
            }

            set
            {
                this.shouldSerialize["auth"] = true;
                this.auth = value;
            }
        }

        /// <summary>
        /// Repository reference information.
        /// </summary>
        [JsonProperty("ref")]
        public Models.Ref MRef
        {
            get
            {
                return this.mRef;
            }

            set
            {
                this.shouldSerialize["ref"] = true;
                this.mRef = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RepoSourceType : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAuth()
        {
            this.shouldSerialize["auth"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRef()
        {
            this.shouldSerialize["ref"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAuth()
        {
            return this.shouldSerialize["auth"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRef()
        {
            return this.shouldSerialize["ref"];
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
            return obj is RepoSourceType other &&                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
                ((this.Branch == null && other.Branch == null) || (this.Branch?.Equals(other.Branch) == true)) &&
                ((this.Auth == null && other.Auth == null) || (this.Auth?.Equals(other.Auth) == true)) &&
                ((this.MRef == null && other.MRef == null) || (this.MRef?.Equals(other.MRef) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Url = {(this.Url == null ? "null" : this.Url)}");
            toStringOutput.Add($"this.Branch = {(this.Branch == null ? "null" : this.Branch)}");
            toStringOutput.Add($"Auth = {(this.Auth == null ? "null" : this.Auth.ToString())}");
            toStringOutput.Add($"this.MRef = {(this.MRef == null ? "null" : this.MRef.ToString())}");
        }
    }
}