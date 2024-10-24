// <copyright file="Senders.cs" company="APIMatic">
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
    /// Senders.
    /// </summary>
    public class Senders
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Senders"/> class.
        /// </summary>
        public Senders()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Senders"/> class.
        /// </summary>
        /// <param name="accounts">accounts.</param>
        public Senders(
            Dictionary<string, Models.PublicAccount> accounts = null)
        {
            this.Accounts = accounts;
        }

        /// <summary>
        /// A record with an ID mapped to a public account.
        /// </summary>
        [JsonProperty("accounts", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.PublicAccount> Accounts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Senders : ({string.Join(", ", toStringOutput)})";
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
            return obj is Senders other &&                ((this.Accounts == null && other.Accounts == null) || (this.Accounts?.Equals(other.Accounts) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accounts = {(this.Accounts == null ? "null" : this.Accounts.ToString())}");
        }
    }
}