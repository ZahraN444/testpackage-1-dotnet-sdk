// <copyright file="FeaturesServerSpec.cs" company="APIMatic">
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
    /// FeaturesServerSpec.
    /// </summary>
    public class FeaturesServerSpec
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturesServerSpec"/> class.
        /// </summary>
        public FeaturesServerSpec()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeaturesServerSpec"/> class.
        /// </summary>
        /// <param name="raid">raid.</param>
        /// <param name="aws">aws.</param>
        public FeaturesServerSpec(
            string raid = null,
            Models.Aws aws = null)
        {
            this.Raid = raid;
            this.Aws = aws;
        }

        /// <summary>
        /// The type of RAID supported, if any.
        /// </summary>
        [JsonProperty("raid", NullValueHandling = NullValueHandling.Include)]
        public string Raid { get; set; }

        /// <summary>
        /// Features specific to AWS.
        /// </summary>
        [JsonProperty("aws", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Aws Aws { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FeaturesServerSpec : ({string.Join(", ", toStringOutput)})";
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
            return obj is FeaturesServerSpec other &&                ((this.Raid == null && other.Raid == null) || (this.Raid?.Equals(other.Raid) == true)) &&
                ((this.Aws == null && other.Aws == null) || (this.Aws?.Equals(other.Aws) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Raid = {(this.Raid == null ? "null" : this.Raid)}");
            toStringOutput.Add($"this.Aws = {(this.Aws == null ? "null" : this.Aws.ToString())}");
        }
    }
}