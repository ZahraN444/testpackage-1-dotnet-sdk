// <copyright file="Autoscale1.cs" company="APIMatic">
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
    /// Autoscale1.
    /// </summary>
    public class Autoscale1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Autoscale1"/> class.
        /// </summary>
        public Autoscale1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Autoscale1"/> class.
        /// </summary>
        /// <param name="groupId">group_id.</param>
        public Autoscale1(
            string groupId)
        {
            this.GroupId = groupId;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("group_id")]
        public string GroupId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Autoscale1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Autoscale1 other &&                ((this.GroupId == null && other.GroupId == null) || (this.GroupId?.Equals(other.GroupId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.GroupId = {(this.GroupId == null ? "null" : this.GroupId)}");
        }
    }
}