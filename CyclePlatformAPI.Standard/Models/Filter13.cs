// <copyright file="Filter13.cs" company="APIMatic">
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
    /// Filter13.
    /// </summary>
    public class Filter13
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter13"/> class.
        /// </summary>
        public Filter13()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter13"/> class.
        /// </summary>
        /// <param name="state">state.</param>
        public Filter13(
            string state = null)
        {
            this.State = state;
        }

        /// <summary>
        /// `filter[state]=value1,value2` state filtering will allow you to filter by the DNS record's current state.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter13 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter13 other &&                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
        }
    }
}