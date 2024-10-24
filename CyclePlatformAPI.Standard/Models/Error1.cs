// <copyright file="Error1.cs" company="APIMatic">
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
    /// Error1.
    /// </summary>
    public class Error1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error1"/> class.
        /// </summary>
        public Error1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error1"/> class.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="time">time.</param>
        public Error1(
            string message = null,
            DateTime? time = null)
        {
            this.Message = message;
            this.Time = time;
        }

        /// <summary>
        /// Details about the error that has occurred.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// The timestamp of when the error was encountered.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Time { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Error1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Error1 other &&                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.Time == null && other.Time == null) || (this.Time?.Equals(other.Time) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"this.Time = {(this.Time == null ? "null" : this.Time.ToString())}");
        }
    }
}