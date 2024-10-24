// <copyright file="ActivityDetail.cs" company="APIMatic">
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
    /// ActivityDetail.
    /// </summary>
    public class ActivityDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityDetail"/> class.
        /// </summary>
        public ActivityDetail()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityDetail"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="number">number.</param>
        /// <param name="mString">string.</param>
        public ActivityDetail(
            string id = null,
            int? number = null,
            string mString = null)
        {
            this.Id = id;
            this.Number = number;
            this.MString = mString;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// A number describing the amount of the resource that exists.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public int? Number { get; set; }

        /// <summary>
        /// Additional information.
        /// </summary>
        [JsonProperty("string", NullValueHandling = NullValueHandling.Ignore)]
        public string MString { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ActivityDetail : ({string.Join(", ", toStringOutput)})";
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
            return obj is ActivityDetail other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.MString == null && other.MString == null) || (this.MString?.Equals(other.MString) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number.ToString())}");
            toStringOutput.Add($"this.MString = {(this.MString == null ? "null" : this.MString)}");
        }
    }
}