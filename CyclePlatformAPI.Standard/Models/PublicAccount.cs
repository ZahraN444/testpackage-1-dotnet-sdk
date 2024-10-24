// <copyright file="PublicAccount.cs" company="APIMatic">
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
    /// PublicAccount.
    /// </summary>
    public class PublicAccount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAccount"/> class.
        /// </summary>
        public PublicAccount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAccount"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="id">id.</param>
        /// <param name="events">events.</param>
        public PublicAccount(
            Models.AccountName name,
            Models.AccountEmail email,
            string id,
            Models.Events events = null)
        {
            this.Name = name;
            this.Email = email;
            this.Id = id;
            this.Events = events;
        }

        /// <summary>
        /// The first and last name of an account owner
        /// </summary>
        [JsonProperty("name")]
        public Models.AccountName Name { get; set; }

        /// <summary>
        /// Email information for an account
        /// </summary>
        [JsonProperty("email")]
        public Models.AccountEmail Email { get; set; }

        /// <summary>
        /// Id information for an account
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Events.
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Events Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PublicAccount : ({string.Join(", ", toStringOutput)})";
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
            return obj is PublicAccount other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Email == null && other.Email == null) || (this.Email?.Equals(other.Email) == true)) &&
                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name.ToString())}");
            toStringOutput.Add($"this.Email = {(this.Email == null ? "null" : this.Email.ToString())}");
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}