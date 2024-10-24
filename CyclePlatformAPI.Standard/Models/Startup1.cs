// <copyright file="Startup1.cs" company="APIMatic">
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
    /// Startup1.
    /// </summary>
    public class Startup1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup1"/> class.
        /// </summary>
        public Startup1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Startup1"/> class.
        /// </summary>
        /// <param name="delay">delay.</param>
        public Startup1(
            string delay = null)
        {
            this.Delay = delay;
        }

        /// <summary>
        /// How long the platform will wait before sending the start signal to the given container.
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public string Delay { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Startup1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Startup1 other &&                ((this.Delay == null && other.Delay == null) || (this.Delay?.Equals(other.Delay) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Delay = {(this.Delay == null ? "null" : this.Delay)}");
        }
    }
}