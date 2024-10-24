// <copyright file="Auth.cs" company="APIMatic">
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
    /// Auth.
    /// </summary>
    public class Auth
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth"/> class.
        /// </summary>
        public Auth()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Auth"/> class.
        /// </summary>
        /// <param name="cycleAccounts">cycle_accounts.</param>
        /// <param name="webhook">webhook.</param>
        /// <param name="vpnAccounts">vpn_accounts.</param>
        public Auth(
            bool cycleAccounts,
            string webhook = null,
            bool? vpnAccounts = null)
        {
            this.Webhook = webhook;
            this.CycleAccounts = cycleAccounts;
            this.VpnAccounts = vpnAccounts;
        }

        /// <summary>
        /// A webhook endpoint to hit. Will be passed the login credentials provided to the user, and should return a 200 status if the login is permitted.
        /// </summary>
        [JsonProperty("webhook", NullValueHandling = NullValueHandling.Include)]
        public string Webhook { get; set; }

        /// <summary>
        /// If true, allows any Cycle account with access to the environment to log in to the VPN using their Cycle email and password.
        /// </summary>
        [JsonProperty("cycle_accounts")]
        public bool CycleAccounts { get; set; }

        /// <summary>
        /// If true, allows the custom VPN accounts to log in to the VPN.
        /// </summary>
        [JsonProperty("vpn_accounts", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VpnAccounts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Auth : ({string.Join(", ", toStringOutput)})";
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
            return obj is Auth other &&                ((this.Webhook == null && other.Webhook == null) || (this.Webhook?.Equals(other.Webhook) == true)) &&
                this.CycleAccounts.Equals(other.CycleAccounts) &&
                ((this.VpnAccounts == null && other.VpnAccounts == null) || (this.VpnAccounts?.Equals(other.VpnAccounts) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Webhook = {(this.Webhook == null ? "null" : this.Webhook)}");
            toStringOutput.Add($"this.CycleAccounts = {this.CycleAccounts}");
            toStringOutput.Add($"this.VpnAccounts = {(this.VpnAccounts == null ? "null" : this.VpnAccounts.ToString())}");
        }
    }
}