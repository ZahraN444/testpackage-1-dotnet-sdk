// <copyright file="V1AccountPasswordRequest.cs" company="APIMatic">
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
    /// V1AccountPasswordRequest.
    /// </summary>
    public class V1AccountPasswordRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1AccountPasswordRequest"/> class.
        /// </summary>
        public V1AccountPasswordRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1AccountPasswordRequest"/> class.
        /// </summary>
        /// <param name="current">current.</param>
        /// <param name="mNew">new.</param>
        public V1AccountPasswordRequest(
            string current,
            string mNew)
        {
            this.Current = current;
            this.MNew = mNew;
        }

        /// <summary>
        /// Current Password
        /// </summary>
        [JsonProperty("current")]
        public string Current { get; set; }

        /// <summary>
        /// New Password
        /// </summary>
        [JsonProperty("new")]
        public string MNew { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1AccountPasswordRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1AccountPasswordRequest other &&                ((this.Current == null && other.Current == null) || (this.Current?.Equals(other.Current) == true)) &&
                ((this.MNew == null && other.MNew == null) || (this.MNew?.Equals(other.MNew) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Current = {(this.Current == null ? "null" : this.Current)}");
            toStringOutput.Add($"this.MNew = {(this.MNew == null ? "null" : this.MNew)}");
        }
    }
}