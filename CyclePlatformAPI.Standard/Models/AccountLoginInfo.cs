// <copyright file="AccountLoginInfo.cs" company="APIMatic">
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
    /// AccountLoginInfo.
    /// </summary>
    public class AccountLoginInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLoginInfo"/> class.
        /// </summary>
        public AccountLoginInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLoginInfo"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="ip">ip.</param>
        public AccountLoginInfo(
            string id,
            string ip)
        {
            this.Id = id;
            this.Ip = ip;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The IP of the request used during login.
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountLoginInfo : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountLoginInfo other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Ip == null && other.Ip == null) || (this.Ip?.Equals(other.Ip) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Ip = {(this.Ip == null ? "null" : this.Ip)}");
        }
    }
}