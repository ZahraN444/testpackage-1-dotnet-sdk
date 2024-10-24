// <copyright file="Details55.cs" company="APIMatic">
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
    /// Details55.
    /// </summary>
    public class Details55
    {
        private Models.Criteria criteria;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "criteria", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Details55"/> class.
        /// </summary>
        public Details55()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Details55"/> class.
        /// </summary>
        /// <param name="stack">stack.</param>
        /// <param name="criteria">criteria.</param>
        public Details55(
            string stack,
            Models.Criteria criteria = null)
        {
            this.Stack = stack;
            if (criteria != null)
            {
                this.Criteria = criteria;
            }

        }

        /// <summary>
        /// <![CDATA[
        /// An identifier used in pipelines to refer to different kinds of resources across Cycle.
        /// ## Types:
        /// - `id:<mongo id>`: A raw resource ID
        /// - `resource:<a resource identifier>`: A compound identifier pointing to a resource.
        /// - `from:<stage/step>`: For referencing a previous pipeline step.
        /// ]]>
        /// </summary>
        [JsonProperty("stack")]
        public string Stack { get; set; }

        /// <summary>
        /// Gets or sets Criteria.
        /// </summary>
        [JsonProperty("criteria")]
        public Models.Criteria Criteria
        {
            get
            {
                return this.criteria;
            }

            set
            {
                this.shouldSerialize["criteria"] = true;
                this.criteria = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Details55 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCriteria()
        {
            this.shouldSerialize["criteria"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCriteria()
        {
            return this.shouldSerialize["criteria"];
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
            return obj is Details55 other &&                ((this.Stack == null && other.Stack == null) || (this.Stack?.Equals(other.Stack) == true)) &&
                ((this.Criteria == null && other.Criteria == null) || (this.Criteria?.Equals(other.Criteria) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Stack = {(this.Stack == null ? "null" : this.Stack)}");
            toStringOutput.Add($"this.Criteria = {(this.Criteria == null ? "null" : this.Criteria.ToString())}");
        }
    }
}