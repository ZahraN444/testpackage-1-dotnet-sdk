// <copyright file="VPNLogin.cs" company="APIMatic">
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
    /// VPNLogin.
    /// </summary>
    public class VPNLogin
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VPNLogin"/> class.
        /// </summary>
        public VPNLogin()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VPNLogin"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="username">username.</param>
        /// <param name="environmentId">environment_id.</param>
        /// <param name="ip">ip.</param>
        /// <param name="time">time.</param>
        /// <param name="success">success.</param>
        public VPNLogin(
            string id,
            string username,
            string environmentId,
            string ip,
            DateTime time,
            bool success)
        {
            this.Id = id;
            this.Username = username;
            this.EnvironmentId = environmentId;
            this.Ip = ip;
            this.Time = time;
            this.Success = success;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The username used when logging in.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// The ID of the environment the VPN service is in.
        /// </summary>
        [JsonProperty("environment_id")]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// The IP address of the machine the user has logged in from.
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// The timestamp for when the login occured.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// A boolean where true means the login attempt was successful.
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VPNLogin : ({string.Join(", ", toStringOutput)})";
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
            return obj is VPNLogin other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.EnvironmentId == null && other.EnvironmentId == null) || (this.EnvironmentId?.Equals(other.EnvironmentId) == true)) &&
                ((this.Ip == null && other.Ip == null) || (this.Ip?.Equals(other.Ip) == true)) &&
                this.Time.Equals(other.Time) &&
                this.Success.Equals(other.Success);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username)}");
            toStringOutput.Add($"this.EnvironmentId = {(this.EnvironmentId == null ? "null" : this.EnvironmentId)}");
            toStringOutput.Add($"this.Ip = {(this.Ip == null ? "null" : this.Ip)}");
            toStringOutput.Add($"this.Time = {this.Time}");
            toStringOutput.Add($"this.Success = {this.Success}");
        }
    }
}