// <copyright file="VPNUser.cs" company="APIMatic">
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
    /// VPNUser.
    /// </summary>
    public class VPNUser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VPNUser"/> class.
        /// </summary>
        public VPNUser()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VPNUser"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="username">username.</param>
        /// <param name="creator">creator.</param>
        /// <param name="lastLogin">last_login.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="environmentId">environment_id.</param>
        /// <param name="events">events.</param>
        public VPNUser(
            string id,
            string username,
            Models.CreatorScope creator,
            DateTime lastLogin,
            string hubId,
            string environmentId,
            Models.VPNUserEvents events)
        {
            this.Id = id;
            this.Username = username;
            this.Creator = creator;
            this.LastLogin = lastLogin;
            this.HubId = hubId;
            this.EnvironmentId = environmentId;
            this.Events = events;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The username for the login.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator")]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// A timestamp of the last time the user logged into the VPN.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("last_login")]
        public DateTime LastLogin { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonProperty("hub_id")]
        public string HubId { get; set; }

        /// <summary>
        /// An identifier for the environment the VPN service is associated with.
        /// </summary>
        [JsonProperty("environment_id")]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the VPN user's lifetime.
        /// </summary>
        [JsonProperty("events")]
        public Models.VPNUserEvents Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VPNUser : ({string.Join(", ", toStringOutput)})";
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
            return obj is VPNUser other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                this.LastLogin.Equals(other.LastLogin) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.EnvironmentId == null && other.EnvironmentId == null) || (this.EnvironmentId?.Equals(other.EnvironmentId) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username)}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.LastLogin = {this.LastLogin}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.EnvironmentId = {(this.EnvironmentId == null ? "null" : this.EnvironmentId)}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}