// <copyright file="ActivityChange.cs" company="APIMatic">
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
    /// ActivityChange.
    /// </summary>
    public class ActivityChange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityChange"/> class.
        /// </summary>
        public ActivityChange()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityChange"/> class.
        /// </summary>
        /// <param name="component">component.</param>
        /// <param name="before">before.</param>
        /// <param name="after">after.</param>
        public ActivityChange(
            string component,
            Models.ActivityDetail before = null,
            Models.ActivityDetail after = null)
        {
            this.Component = component;
            this.Before = before;
            this.After = after;
        }

        /// <summary>
        /// A description of the resource that was changed.
        /// </summary>
        [JsonProperty("component")]
        public string Component { get; set; }

        /// <summary>
        /// Details about a given event that is part of an activity.
        /// </summary>
        [JsonProperty("before", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ActivityDetail Before { get; set; }

        /// <summary>
        /// Details about a given event that is part of an activity.
        /// </summary>
        [JsonProperty("after", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ActivityDetail After { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ActivityChange : ({string.Join(", ", toStringOutput)})";
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
            return obj is ActivityChange other &&                ((this.Component == null && other.Component == null) || (this.Component?.Equals(other.Component) == true)) &&
                ((this.Before == null && other.Before == null) || (this.Before?.Equals(other.Before) == true)) &&
                ((this.After == null && other.After == null) || (this.After?.Equals(other.After) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Component = {(this.Component == null ? "null" : this.Component)}");
            toStringOutput.Add($"this.Before = {(this.Before == null ? "null" : this.Before.ToString())}");
            toStringOutput.Add($"this.After = {(this.After == null ? "null" : this.After.ToString())}");
        }
    }
}