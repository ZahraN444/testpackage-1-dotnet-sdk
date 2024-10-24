// <copyright file="RemoteAccess1.cs" company="APIMatic">
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
    /// RemoteAccess1.
    /// </summary>
    public class RemoteAccess1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteAccess1"/> class.
        /// </summary>
        public RemoteAccess1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteAccess1"/> class.
        /// </summary>
        /// <param name="enable">enable.</param>
        /// <param name="ips">ips.</param>
        /// <param name="webHook">web_hook.</param>
        /// <param name="password">password.</param>
        public RemoteAccess1(
            bool enable,
            List<string> ips = null,
            string webHook = null,
            Models.Password1 password = null)
        {
            this.Enable = enable;
            this.Ips = ips;
            this.WebHook = webHook;
            this.Password = password;
        }

        /// <summary>
        /// A boolean where true represents this container volume being open to remote access connections over SFTP.
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// Gets or sets Ips.
        /// </summary>
        [JsonProperty("ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ips { get; set; }

        /// <summary>
        /// Call out to a webhook to authenticate usernames/passwords if an organization manages their own accounts
        /// </summary>
        [JsonProperty("web_hook", NullValueHandling = NullValueHandling.Ignore)]
        public string WebHook { get; set; }

        /// <summary>
        /// Password configuration settings for the remote access of the container volume.
        /// </summary>
        [JsonProperty("password", NullValueHandling = NullValueHandling.Include)]
        public Models.Password1 Password { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RemoteAccess1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is RemoteAccess1 other &&                this.Enable.Equals(other.Enable) &&
                ((this.Ips == null && other.Ips == null) || (this.Ips?.Equals(other.Ips) == true)) &&
                ((this.WebHook == null && other.WebHook == null) || (this.WebHook?.Equals(other.WebHook) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Enable = {this.Enable}");
            toStringOutput.Add($"this.Ips = {(this.Ips == null ? "null" : $"[{string.Join(", ", this.Ips)} ]")}");
            toStringOutput.Add($"this.WebHook = {(this.WebHook == null ? "null" : this.WebHook)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password.ToString())}");
        }
    }
}