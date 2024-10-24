// <copyright file="HubMembershipsIncludes.cs" company="APIMatic">
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
    /// HubMembershipsIncludes.
    /// </summary>
    public class HubMembershipsIncludes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubMembershipsIncludes"/> class.
        /// </summary>
        public HubMembershipsIncludes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HubMembershipsIncludes"/> class.
        /// </summary>
        /// <param name="senders">senders.</param>
        /// <param name="accounts">accounts.</param>
        /// <param name="hubs">hubs.</param>
        /// <param name="roles">roles.</param>
        /// <param name="rolesIdentifiers">roles:identifiers.</param>
        public HubMembershipsIncludes(
            Models.Senders senders = null,
            Dictionary<string, Models.PublicAccount> accounts = null,
            Dictionary<string, Models.Hub> hubs = null,
            Dictionary<string, Models.Role> roles = null,
            Dictionary<string, string> rolesIdentifiers = null)
        {
            this.Senders = senders;
            this.Accounts = accounts;
            this.Hubs = hubs;
            this.Roles = roles;
            this.RolesIdentifiers = rolesIdentifiers;
        }

        /// <summary>
        /// A record with an ID mapped to a public account for the account that sent this memberships initial invite.
        /// </summary>
        [JsonProperty("senders", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Senders Senders { get; set; }

        /// <summary>
        /// A record with an ID mapped to a public account.
        /// </summary>
        [JsonProperty("accounts", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.PublicAccount> Accounts { get; set; }

        /// <summary>
        /// A record with an ID mapped to a hub resource.
        /// </summary>
        [JsonProperty("hubs", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Hub> Hubs { get; set; }

        /// <summary>
        /// A map of Roles relevant to this Hub Membership, keyed by the Role ID.
        /// </summary>
        [JsonProperty("roles", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Role> Roles { get; set; }

        /// <summary>
        /// A map of Roles relevant to this Hub Membership, keyed by the Role ID.
        /// </summary>
        [JsonProperty("roles:identifiers", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> RolesIdentifiers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HubMembershipsIncludes : ({string.Join(", ", toStringOutput)})";
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
            return obj is HubMembershipsIncludes other &&                ((this.Senders == null && other.Senders == null) || (this.Senders?.Equals(other.Senders) == true)) &&
                ((this.Accounts == null && other.Accounts == null) || (this.Accounts?.Equals(other.Accounts) == true)) &&
                ((this.Hubs == null && other.Hubs == null) || (this.Hubs?.Equals(other.Hubs) == true)) &&
                ((this.Roles == null && other.Roles == null) || (this.Roles?.Equals(other.Roles) == true)) &&
                ((this.RolesIdentifiers == null && other.RolesIdentifiers == null) || (this.RolesIdentifiers?.Equals(other.RolesIdentifiers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Senders = {(this.Senders == null ? "null" : this.Senders.ToString())}");
            toStringOutput.Add($"Accounts = {(this.Accounts == null ? "null" : this.Accounts.ToString())}");
            toStringOutput.Add($"Hubs = {(this.Hubs == null ? "null" : this.Hubs.ToString())}");
            toStringOutput.Add($"Roles = {(this.Roles == null ? "null" : this.Roles.ToString())}");
            toStringOutput.Add($"RolesIdentifiers = {(this.RolesIdentifiers == null ? "null" : this.RolesIdentifiers.ToString())}");
        }
    }
}