// <copyright file="Email1.cs" company="APIMatic">
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
    /// Email1.
    /// </summary>
    public class Email1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Email1"/> class.
        /// </summary>
        public Email1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Email1"/> class.
        /// </summary>
        /// <param name="notificaitons">notificaitons.</param>
        public Email1(
            Models.Notificaitons notificaitons = null)
        {
            this.Notificaitons = notificaitons;
        }

        /// <summary>
        /// Gets or sets Notificaitons.
        /// </summary>
        [JsonProperty("notificaitons", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Notificaitons Notificaitons { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Email1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Email1 other &&                ((this.Notificaitons == null && other.Notificaitons == null) || (this.Notificaitons?.Equals(other.Notificaitons) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Notificaitons = {(this.Notificaitons == null ? "null" : this.Notificaitons.ToString())}");
        }
    }
}