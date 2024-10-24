// <copyright file="Config5.cs" company="APIMatic">
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
    /// Config5.
    /// </summary>
    public class Config5
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Config5"/> class.
        /// </summary>
        public Config5()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Config5"/> class.
        /// </summary>
        /// <param name="runtime">runtime.</param>
        /// <param name="resources">resources.</param>
        public Config5(
            Config5Runtime runtime = null,
            Config5Resources resources = null)
        {
            this.Runtime = runtime;
            this.Resources = resources;
        }

        /// <summary>
        /// Gets or sets Runtime.
        /// </summary>
        [JsonProperty("runtime", NullValueHandling = NullValueHandling.Ignore)]
        public Config5Runtime Runtime { get; set; }

        /// <summary>
        /// Gets or sets Resources.
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public Config5Resources Resources { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Config5 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Config5 other &&                ((this.Runtime == null && other.Runtime == null) || (this.Runtime?.Equals(other.Runtime) == true)) &&
                ((this.Resources == null && other.Resources == null) || (this.Resources?.Equals(other.Resources) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Runtime = {(this.Runtime == null ? "null" : this.Runtime.ToString())}");
            toStringOutput.Add($"Resources = {(this.Resources == null ? "null" : this.Resources.ToString())}");
        }
    }
}