// <copyright file="Token.cs" company="APIMatic">
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
    /// Token.
    /// </summary>
    public class Token
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Token"/> class.
        /// </summary>
        public Token()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Token"/> class.
        /// </summary>
        /// <param name="applicationId">application_id.</param>
        /// <param name="applicationCapabilitiesVersion">application_capabilities_version.</param>
        public Token(
            string applicationId,
            int applicationCapabilitiesVersion)
        {
            this.ApplicationId = applicationId;
            this.ApplicationCapabilitiesVersion = applicationCapabilitiesVersion;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets ApplicationCapabilitiesVersion.
        /// </summary>
        [JsonProperty("application_capabilities_version")]
        public int ApplicationCapabilitiesVersion { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Token : ({string.Join(", ", toStringOutput)})";
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
            return obj is Token other &&                ((this.ApplicationId == null && other.ApplicationId == null) || (this.ApplicationId?.Equals(other.ApplicationId) == true)) &&
                this.ApplicationCapabilitiesVersion.Equals(other.ApplicationCapabilitiesVersion);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ApplicationId = {(this.ApplicationId == null ? "null" : this.ApplicationId)}");
            toStringOutput.Add($"this.ApplicationCapabilitiesVersion = {this.ApplicationCapabilitiesVersion}");
        }
    }
}