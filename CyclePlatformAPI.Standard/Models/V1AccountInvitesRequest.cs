// <copyright file="V1AccountInvitesRequest.cs" company="APIMatic">
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
    /// V1AccountInvitesRequest.
    /// </summary>
    public class V1AccountInvitesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1AccountInvitesRequest"/> class.
        /// </summary>
        public V1AccountInvitesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1AccountInvitesRequest"/> class.
        /// </summary>
        /// <param name="accept">accept.</param>
        /// <param name="decline">decline.</param>
        public V1AccountInvitesRequest(
            bool? accept = null,
            bool? decline = null)
        {
            this.Accept = accept;
            this.Decline = decline;
        }

        /// <summary>
        /// If true, the Invite will be accepted and the associated Account will join the Hub.
        /// </summary>
        [JsonProperty("accept", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Accept { get; set; }

        /// <summary>
        /// If true, the Invite will be declined and the associated Account will NOT join the Hub.
        /// </summary>
        [JsonProperty("decline", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Decline { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1AccountInvitesRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1AccountInvitesRequest other &&                ((this.Accept == null && other.Accept == null) || (this.Accept?.Equals(other.Accept) == true)) &&
                ((this.Decline == null && other.Decline == null) || (this.Decline?.Equals(other.Decline) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Accept = {(this.Accept == null ? "null" : this.Accept.ToString())}");
            toStringOutput.Add($"this.Decline = {(this.Decline == null ? "null" : this.Decline.ToString())}");
        }
    }
}