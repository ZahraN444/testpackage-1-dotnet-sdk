// <copyright file="HubsMeta.cs" company="APIMatic">
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
    /// HubsMeta.
    /// </summary>
    public class HubsMeta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubsMeta"/> class.
        /// </summary>
        public HubsMeta()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HubsMeta"/> class.
        /// </summary>
        /// <param name="membership">membership.</param>
        public HubsMeta(
            Models.HubMembership membership = null)
        {
            this.Membership = membership;
        }

        /// <summary>
        /// A membership resource that is scoped to an individual hub.
        /// </summary>
        [JsonProperty("membership", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HubMembership Membership { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HubsMeta : ({string.Join(", ", toStringOutput)})";
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
            return obj is HubsMeta other &&                ((this.Membership == null && other.Membership == null) || (this.Membership?.Equals(other.Membership) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Membership = {(this.Membership == null ? "null" : this.Membership.ToString())}");
        }
    }
}