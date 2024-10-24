// <copyright file="V1StacksRequest1.cs" company="APIMatic">
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
    /// V1StacksRequest1.
    /// </summary>
    public class V1StacksRequest1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1StacksRequest1"/> class.
        /// </summary>
        public V1StacksRequest1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1StacksRequest1"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="variables">variables.</param>
        /// <param name="source">source.</param>
        public V1StacksRequest1(
            string name = null,
            Dictionary<string, string> variables = null,
            StackSource source = null)
        {
            this.Name = name;
            this.Variables = variables;
            this.Source = source;
        }

        /// <summary>
        /// A name for the Stack.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// A map of default variable values used when building this Stack. A variable can be added anywhere in a Stack using the format `{{var}}` where `var` would be a key in this map.
        /// </summary>
        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Variables { get; set; }

        /// <summary>
        /// A source for a stack to be created from.
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public StackSource Source { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1StacksRequest1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1StacksRequest1 other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Variables == null && other.Variables == null) || (this.Variables?.Equals(other.Variables) == true)) &&
                ((this.Source == null && other.Source == null) || (this.Source?.Equals(other.Source) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"Variables = {(this.Variables == null ? "null" : this.Variables.ToString())}");
            toStringOutput.Add($"Source = {(this.Source == null ? "null" : this.Source.ToString())}");
        }
    }
}