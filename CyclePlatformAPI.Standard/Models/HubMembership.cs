// <copyright file="HubMembership.cs" company="APIMatic">
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
    /// HubMembership.
    /// </summary>
    public class HubMembership
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubMembership"/> class.
        /// </summary>
        public HubMembership()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HubMembership"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="events">events.</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="state">state.</param>
        /// <param name="invitation">invitation.</param>
        /// <param name="accountId">account_id.</param>
        /// <param name="roleId">role_id.</param>
        /// <param name="preferences">preferences.</param>
        /// <param name="cycle">cycle.</param>
        /// <param name="meta">meta.</param>
        public HubMembership(
            string id,
            string hubId,
            Models.MembershipEvents events,
            Models.HubMembershipPermissions permissions,
            Models.MembershipState state,
            Models.HubMembershipInvitation invitation,
            string accountId = null,
            string roleId = null,
            Models.HubMembershipPreferences preferences = null,
            Models.Cycle cycle = null,
            Models.HubMembershipMeta meta = null)
        {
            this.Id = id;
            this.AccountId = accountId;
            this.HubId = hubId;
            this.Events = events;
            this.RoleId = roleId;
            this.Permissions = permissions;
            this.Preferences = preferences;
            this.State = state;
            this.Invitation = invitation;
            this.Cycle = cycle;
            this.Meta = meta;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// An ID for the account associated with the given membership.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("hub_id")]
        [JsonRequired]
        public string HubId { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the membership's lifetime.
        /// </summary>
        [JsonProperty("events")]
        [JsonRequired]
        public Models.MembershipEvents Events { get; set; }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleId { get; set; }

        /// <summary>
        /// Information about this member's permissions for a given hub.
        /// </summary>
        [JsonProperty("permissions")]
        [JsonRequired]
        public Models.HubMembershipPermissions Permissions { get; set; }

        /// <summary>
        /// Preference information set by the user for the membership.
        /// </summary>
        [JsonProperty("preferences", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HubMembershipPreferences Preferences { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        [JsonRequired]
        public Models.MembershipState State { get; set; }

        /// <summary>
        /// Information about a hub membership invitation.
        /// </summary>
        [JsonProperty("invitation")]
        [JsonRequired]
        public Models.HubMembershipInvitation Invitation { get; set; }

        /// <summary>
        /// If this member is a Cycle employee, their employee ID will be listed here. Cycle employee accounts do not consume a "membership" for a given hub.
        /// </summary>
        [JsonProperty("cycle", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Cycle Cycle { get; set; }

        /// <summary>
        /// A list of meta fields that can be applied to a membership.
        /// </summary>
        [JsonProperty("meta", NullValueHandling = NullValueHandling.Ignore)]
        public Models.HubMembershipMeta Meta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"HubMembership : ({string.Join(", ", toStringOutput)})";
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
            return obj is HubMembership other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.RoleId == null && other.RoleId == null) || (this.RoleId?.Equals(other.RoleId) == true)) &&
                ((this.Permissions == null && other.Permissions == null) || (this.Permissions?.Equals(other.Permissions) == true)) &&
                ((this.Preferences == null && other.Preferences == null) || (this.Preferences?.Equals(other.Preferences) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Invitation == null && other.Invitation == null) || (this.Invitation?.Equals(other.Invitation) == true)) &&
                ((this.Cycle == null && other.Cycle == null) || (this.Cycle?.Equals(other.Cycle) == true)) &&
                ((this.Meta == null && other.Meta == null) || (this.Meta?.Equals(other.Meta) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId)}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.RoleId = {(this.RoleId == null ? "null" : this.RoleId)}");
            toStringOutput.Add($"this.Permissions = {(this.Permissions == null ? "null" : this.Permissions.ToString())}");
            toStringOutput.Add($"this.Preferences = {(this.Preferences == null ? "null" : this.Preferences.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Invitation = {(this.Invitation == null ? "null" : this.Invitation.ToString())}");
            toStringOutput.Add($"this.Cycle = {(this.Cycle == null ? "null" : this.Cycle.ToString())}");
            toStringOutput.Add($"this.Meta = {(this.Meta == null ? "null" : this.Meta.ToString())}");
        }
    }
}