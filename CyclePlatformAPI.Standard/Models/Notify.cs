// <copyright file="Notify.cs" company="APIMatic">
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
    /// Notify.
    /// </summary>
    public class Notify
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notify"/> class.
        /// </summary>
        public Notify()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notify"/> class.
        /// </summary>
        /// <param name="emails">emails.</param>
        /// <param name="webHook">web_hook.</param>
        public Notify(
            List<string> emails = null,
            string webHook = null)
        {
            this.Emails = emails;
            this.WebHook = webHook;
        }

        /// <summary>
        /// Gets or sets Emails.
        /// </summary>
        [JsonProperty("emails", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Emails { get; set; }

        /// <summary>
        /// Gets or sets WebHook.
        /// </summary>
        [JsonProperty("web_hook", NullValueHandling = NullValueHandling.Ignore)]
        public string WebHook { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Notify : ({string.Join(", ", toStringOutput)})";
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
            return obj is Notify other &&                ((this.Emails == null && other.Emails == null) || (this.Emails?.Equals(other.Emails) == true)) &&
                ((this.WebHook == null && other.WebHook == null) || (this.WebHook?.Equals(other.WebHook) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Emails = {(this.Emails == null ? "null" : $"[{string.Join(", ", this.Emails)} ]")}");
            toStringOutput.Add($"this.WebHook = {(this.WebHook == null ? "null" : this.WebHook)}");
        }
    }
}