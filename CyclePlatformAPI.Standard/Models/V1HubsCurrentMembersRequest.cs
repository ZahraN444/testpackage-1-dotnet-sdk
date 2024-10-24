// <copyright file="V1HubsCurrentMembersRequest.cs" company="APIMatic">
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
    /// V1HubsCurrentMembersRequest.
    /// </summary>
    public class V1HubsCurrentMembersRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1HubsCurrentMembersRequest"/> class.
        /// </summary>
        public V1HubsCurrentMembersRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1HubsCurrentMembersRequest"/> class.
        /// </summary>
        /// <param name="roleId">role_id.</param>
        /// <param name="permissions">permissions.</param>
        public V1HubsCurrentMembersRequest(
            string roleId = null,
            Models.Permissions permissions = null)
        {
            this.RoleId = roleId;
            this.Permissions = permissions;
        }

        /// <summary>
        /// The account role.
        /// </summary>
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleId { get; set; }

        /// <summary>
        /// Permissions information for an API Key
        /// </summary>
        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Permissions Permissions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1HubsCurrentMembersRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1HubsCurrentMembersRequest other &&                ((this.RoleId == null && other.RoleId == null) || (this.RoleId?.Equals(other.RoleId) == true)) &&
                ((this.Permissions == null && other.Permissions == null) || (this.Permissions?.Equals(other.Permissions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RoleId = {(this.RoleId == null ? "null" : this.RoleId)}");
            toStringOutput.Add($"this.Permissions = {(this.Permissions == null ? "null" : this.Permissions.ToString())}");
        }
    }
}