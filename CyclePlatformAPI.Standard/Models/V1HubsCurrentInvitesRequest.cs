// <copyright file="V1HubsCurrentInvitesRequest.cs" company="APIMatic">
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
    /// V1HubsCurrentInvitesRequest.
    /// </summary>
    public class V1HubsCurrentInvitesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1HubsCurrentInvitesRequest"/> class.
        /// </summary>
        public V1HubsCurrentInvitesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1HubsCurrentInvitesRequest"/> class.
        /// </summary>
        /// <param name="recipient">recipient.</param>
        /// <param name="roleId">role_id.</param>
        /// <param name="permissions">permissions.</param>
        public V1HubsCurrentInvitesRequest(
            string recipient = null,
            string roleId = null,
            Models.Permissions2 permissions = null)
        {
            this.Recipient = recipient;
            this.RoleId = roleId;
            this.Permissions = permissions;
        }

        /// <summary>
        /// The email address of the invitee.
        /// </summary>
        [JsonProperty("recipient", NullValueHandling = NullValueHandling.Ignore)]
        public string Recipient { get; set; }

        /// <summary>
        /// The account role.
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleId { get; set; }

        /// <summary>
        /// The Environment permissions the invitee will have
        /// </summary>
        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Permissions2 Permissions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1HubsCurrentInvitesRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1HubsCurrentInvitesRequest other &&                ((this.Recipient == null && other.Recipient == null) || (this.Recipient?.Equals(other.Recipient) == true)) &&
                ((this.RoleId == null && other.RoleId == null) || (this.RoleId?.Equals(other.RoleId) == true)) &&
                ((this.Permissions == null && other.Permissions == null) || (this.Permissions?.Equals(other.Permissions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Recipient = {(this.Recipient == null ? "null" : this.Recipient)}");
            toStringOutput.Add($"this.RoleId = {(this.RoleId == null ? "null" : this.RoleId)}");
            toStringOutput.Add($"this.Permissions = {(this.Permissions == null ? "null" : this.Permissions.ToString())}");
        }
    }
}