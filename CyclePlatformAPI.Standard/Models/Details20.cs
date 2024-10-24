// <copyright file="Details20.cs" company="APIMatic">
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
    /// Details20.
    /// </summary>
    public class Details20
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details20"/> class.
        /// </summary>
        public Details20()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details20"/> class.
        /// </summary>
        /// <param name="url">url.</param>
        /// <param name="branch">branch.</param>
        /// <param name="auth">auth.</param>
        /// <param name="mRef">ref.</param>
        public Details20(
            string url,
            string branch = null,
            Details20Auth auth = null,
            Models.Ref mRef = null)
        {
            this.Url = url;
            this.Branch = branch;
            this.Auth = auth;
            this.MRef = mRef;
        }

        /// <summary>
        /// The URL of the repository.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// An optional branch arguement.  Default value is `master`.
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// Authentication information for the repository.
        /// </summary>
        [JsonProperty("auth", NullValueHandling = NullValueHandling.Ignore)]
        public Details20Auth Auth { get; set; }

        /// <summary>
        /// Repository reference information.
        /// </summary>
        [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Ref MRef { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details20 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details20 other &&                ((this.Url == null && other.Url == null) || (this.Url?.Equals(other.Url) == true)) &&
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