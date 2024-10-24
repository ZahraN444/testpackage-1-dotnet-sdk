// <copyright file="Details15.cs" company="APIMatic">
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
    /// Details15.
    /// </summary>
    public class Details15
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Details15"/> class.
        /// </summary>
        public Details15()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details15"/> class.
        /// </summary>
        /// <param name="used">used.</param>
        public Details15(
            string used)
        {
            this.Used = used;
        }

        /// <summary>
        /// The limit (maximum) amount of RAM each instance of the given container can use before triggering a scaling event.
        /// </summary>
        [JsonProperty("used")]
        public string Used { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details15 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Details15 other &&                ((this.Used == null && other.Used == null) || (this.Used?.Equals(other.Used) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Used = {(this.Used == null ? "null" : this.Used)}");
        }
    }
}