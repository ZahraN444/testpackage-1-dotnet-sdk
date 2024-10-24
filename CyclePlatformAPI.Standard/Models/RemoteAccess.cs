// <copyright file="RemoteAccess.cs" company="APIMatic">
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
    /// RemoteAccess.
    /// </summary>
    public class RemoteAccess
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteAccess"/> class.
        /// </summary>
        public RemoteAccess()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteAccess"/> class.
        /// </summary>
        /// <param name="enable">enable.</param>
        /// <param name="password">password.</param>
        /// <param name="ips">ips.</param>
        /// <param name="webHook">web_hook.</param>
        public RemoteAccess(
            bool enable,
            Models.Password password,
            List<string> ips = null,
            string webHook = null)
        {
            this.Enable = enable;
            this.Ips = ips;
            this.WebHook = webHook;
            this.Password = password;
        }

        /// <summary>
        /// Gets or sets Enable.
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// Gets or sets Ips.
        /// </summary>
        [JsonProperty("ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ips { get; set; }

        /// <summary>
        /// Gets or sets WebHook.
        /// </summary>
        [JsonProperty("web_hook", NullValueHandling = NullValueHandling.Ignore)]
        public string WebHook { get; set; }

        /// <summary>
        /// Gets or sets Password.
        /// </summary>
        [JsonProperty("password")]
        public Models.Password Password { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RemoteAccess : ({string.Join(", ", toStringOutput)})";
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
            return obj is RemoteAccess other &&                this.Enable.Equals(other.Enable) &&
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