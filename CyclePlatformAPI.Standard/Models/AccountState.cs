// <copyright file="AccountState.cs" company="APIMatic">
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
    /// AccountState.
    /// </summary>
    public class AccountState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountState"/> class.
        /// </summary>
        public AccountState()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountState"/> class.
        /// </summary>
        /// <param name="current">current.</param>
        /// <param name="changed">changed.</param>
        /// <param name="error">error.</param>
        public AccountState(
            Models.CurrentEnum current,
            DateTime changed,
            Models.Error1 error = null)
        {
            this.Current = current;
            this.Changed = changed;
            this.Error = error;
        }

        /// <summary>
        /// The current state of the account.
        /// </summary>
        [JsonProperty("current")]
        public Models.CurrentEnum Current { get; set; }

        /// <summary>
        /// Gets or sets Changed.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("changed")]
        public DateTime Changed { get; set; }

        /// <summary>
        /// An error, if any, that has occurred for this resource.
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Error1 Error { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AccountState : ({string.Join(", ", toStringOutput)})";
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
            return obj is AccountState other &&                this.Current.Equals(other.Current) &&
                this.Changed.Equals(other.Changed) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Current = {this.Current}");
            toStringOutput.Add($"this.Changed = {this.Changed}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}