// <copyright file="StackGitCommit.cs" company="APIMatic">
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
    /// StackGitCommit.
    /// </summary>
    public class StackGitCommit
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackGitCommit"/> class.
        /// </summary>
        public StackGitCommit()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackGitCommit"/> class.
        /// </summary>
        /// <param name="hash">hash.</param>
        /// <param name="message">message.</param>
        /// <param name="time">time.</param>
        /// <param name="author">author.</param>
        public StackGitCommit(
            string hash,
            string message,
            DateTime time,
            Models.Author author)
        {
            this.Hash = hash;
            this.Message = message;
            this.Time = time;
            this.Author = author;
        }

        /// <summary>
        /// The commit hash for the given stack build.
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// The commit message for the given stack build hash.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// The time the commit was made.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <summary>
        /// Inforamtion about the author of the commit.
        /// </summary>
        [JsonProperty("author")]
        public Models.Author Author { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackGitCommit : ({string.Join(", ", toStringOutput)})";
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
            return obj is StackGitCommit other &&                ((this.Hash == null && other.Hash == null) || (this.Hash?.Equals(other.Hash) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                this.Time.Equals(other.Time) &&
                ((this.Author == null && other.Author == null) || (this.Author?.Equals(other.Author) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Hash = {(this.Hash == null ? "null" : this.Hash)}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"this.Time = {this.Time}");
            toStringOutput.Add($"this.Author = {(this.Author == null ? "null" : this.Author.ToString())}");
        }
    }
}