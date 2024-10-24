// <copyright file="Tags1.cs" company="APIMatic">
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
    /// Tags1.
    /// </summary>
    public class Tags1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tags1"/> class.
        /// </summary>
        public Tags1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tags1"/> class.
        /// </summary>
        /// <param name="any">any.</param>
        /// <param name="all">all.</param>
        public Tags1(
            List<string> any = null,
            List<string> all = null)
        {
            this.Any = any;
            this.All = all;
        }

        /// <summary>
        /// A list of tags where a server matching any tags from the list is qualified as a deployment target.
        /// </summary>
        [JsonProperty("any", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Any { get; set; }

        /// <summary>
        /// A list of tags where a server matching all tags from the list is the only scenario where the server is qualified as a deployment target.
        /// </summary>
        [JsonProperty("all", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> All { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Tags1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Tags1 other &&                ((this.Any == null && other.Any == null) || (this.Any?.Equals(other.Any) == true)) &&
                ((this.All == null && other.All == null) || (this.All?.Equals(other.All) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Any = {(this.Any == null ? "null" : $"[{string.Join(", ", this.Any)} ]")}");
            toStringOutput.Add($"this.All = {(this.All == null ? "null" : $"[{string.Join(", ", this.All)} ]")}");
        }
    }
}