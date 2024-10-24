// <copyright file="Error2.cs" company="APIMatic">
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
    /// Error2.
    /// </summary>
    public class Error2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error2"/> class.
        /// </summary>
        public Error2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error2"/> class.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="messageInternal">message_internal.</param>
        /// <param name="stack">stack.</param>
        public Error2(
            string message,
            string messageInternal = null,
            List<Models.Stack2> stack = null)
        {
            this.Message = message;
            this.MessageInternal = messageInternal;
            this.Stack = stack;
        }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets MessageInternal.
        /// </summary>
        [JsonProperty("message_internal", NullValueHandling = NullValueHandling.Ignore)]
        public string MessageInternal { get; set; }

        /// <summary>
        /// Gets or sets Stack.
        /// </summary>
        [JsonProperty("stack", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Stack2> Stack { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Error2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Error2 other &&                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.MessageInternal == null && other.MessageInternal == null) || (this.MessageInternal?.Equals(other.MessageInternal) == true)) &&
                ((this.Stack == null && other.Stack == null) || (this.Stack?.Equals(other.Stack) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"this.MessageInternal = {(this.MessageInternal == null ? "null" : this.MessageInternal)}");
            toStringOutput.Add($"this.Stack = {(this.Stack == null ? "null" : $"[{string.Join(", ", this.Stack)} ]")}");
        }
    }
}