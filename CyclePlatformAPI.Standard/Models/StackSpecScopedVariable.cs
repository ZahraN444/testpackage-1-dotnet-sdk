// <copyright file="StackSpecScopedVariable.cs" company="APIMatic">
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
    /// StackSpecScopedVariable.
    /// </summary>
    public class StackSpecScopedVariable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackSpecScopedVariable"/> class.
        /// </summary>
        public StackSpecScopedVariable()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackSpecScopedVariable"/> class.
        /// </summary>
        /// <param name="identifier">identifier.</param>
        /// <param name="scope">scope.</param>
        /// <param name="access">access.</param>
        /// <param name="source">source.</param>
        public StackSpecScopedVariable(
            string identifier,
            Models.Scope scope,
            Models.Access access,
            StackSpecScopedVariableSource source = null)
        {
            this.Identifier = identifier;
            this.Scope = scope;
            this.Access = access;
            this.Source = source;
        }

        /// <summary>
        /// A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.
        /// The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will
        /// have the identifier of `my-container` and is automatically created by the platform.
        /// The identifier does not have to be unique.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets Scope.
        /// </summary>
        [JsonProperty("scope")]
        public Models.Scope Scope { get; set; }

        /// <summary>
        /// Gets or sets Access.
        /// </summary>
        [JsonProperty("access")]
        public Models.Access Access { get; set; }

        /// <summary>
        /// The source or value of the scoped variable.
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Include)]
        public StackSpecScopedVariableSource Source { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackSpecScopedVariable : ({string.Join(", ", toStringOutput)})";
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
            return obj is StackSpecScopedVariable other &&                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Scope == null && other.Scope == null) || (this.Scope?.Equals(other.Scope) == true)) &&
                ((this.Access == null && other.Access == null) || (this.Access?.Equals(other.Access) == true)) &&
                ((this.Source == null && other.Source == null) || (this.Source?.Equals(other.Source) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Scope = {(this.Scope == null ? "null" : this.Scope.ToString())}");
            toStringOutput.Add($"this.Access = {(this.Access == null ? "null" : this.Access.ToString())}");
            toStringOutput.Add($"Source = {(this.Source == null ? "null" : this.Source.ToString())}");
        }
    }
}