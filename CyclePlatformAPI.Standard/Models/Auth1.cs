// <copyright file="Auth1.cs" company="APIMatic">
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
    /// Auth1.
    /// </summary>
    public class Auth1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1"/> class.
        /// </summary>
        public Auth1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Auth1"/> class.
        /// </summary>
        /// <param name="cycleAccounts">cycle_accounts.</param>
        /// <param name="vpnAccounts">vpn_accounts.</param>
        /// <param name="webhook">webhook.</param>
        public Auth1(
            bool cycleAccounts,
            bool vpnAccounts,
            string webhook = null)
        {
            this.Webhook = webhook;
            this.CycleAccounts = cycleAccounts;
            this.VpnAccounts = vpnAccounts;
        }

        /// <summary>
        /// Gets or sets Webhook.
        /// </summary>
        [JsonProperty("webhook", NullValueHandling = NullValueHandling.Ignore)]
        public string Webhook { get; set; }

        /// <summary>
        /// Gets or sets CycleAccounts.
        /// </summary>
        [JsonProperty("cycle_accounts")]
        public bool CycleAccounts { get; set; }

        /// <summary>
        /// Gets or sets VpnAccounts.
        /// </summary>
        [JsonProperty("vpn_accounts")]
        public bool VpnAccounts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Auth1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Auth1 other &&                ((this.Webhook == null && other.Webhook == null) || (this.Webhook?.Equals(other.Webhook) == true)) &&
                this.CycleAccounts.Equals(other.CycleAccounts) &&
                this.VpnAccounts.Equals(other.VpnAccounts);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Webhook = {(this.Webhook == null ? "null" : this.Webhook)}");
            toStringOutput.Add($"this.CycleAccounts = {this.CycleAccounts}");
            toStringOutput.Add($"this.VpnAccounts = {this.VpnAccounts}");
        }
    }
}