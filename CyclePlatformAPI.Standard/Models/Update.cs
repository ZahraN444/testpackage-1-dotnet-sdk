// <copyright file="Update.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// Update.
    /// </summary>
    public class Update
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Update"/> class.
        /// </summary>
        public Update()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Update"/> class.
        /// </summary>
        /// <param name="stagger">stagger.</param>
        public Update(
            UpdateStagger stagger = null)
        {
            this.Stagger = stagger;
        }

        /// <summary>
        /// When set, Cycle will pick a random time from `0 - this duration`, and stagger the instances so they all start at different times (up to the time specified here).
        /// </summary>
        [JsonProperty("stagger", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateStagger Stagger { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Update : ({string.Join(", ", toStringOutput)})";
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
            return obj is Update other &&                ((this.Stagger == null && other.Stagger == null) || (this.Stagger?.Equals(other.Stagger) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Stagger = {(this.Stagger == null ? "null" : this.Stagger.ToString())}");
        }
    }
}