// <copyright file="V1EnvironmentsScopedVariablesRequest1.cs" company="APIMatic">
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
    /// V1EnvironmentsScopedVariablesRequest1.
    /// </summary>
    public class V1EnvironmentsScopedVariablesRequest1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsScopedVariablesRequest1"/> class.
        /// </summary>
        public V1EnvironmentsScopedVariablesRequest1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="V1EnvironmentsScopedVariablesRequest1"/> class.
        /// </summary>
        /// <param name="identifier">identifier.</param>
        /// <param name="scope">scope.</param>
        /// <param name="access">access.</param>
        /// <param name="source">source.</param>
        public V1EnvironmentsScopedVariablesRequest1(
            string identifier = null,
            Models.ScopedVariableScope scope = null,
            Models.ScopedVariableAccess access = null,
            V1EnvironmentsScopedVariablesRequest1Source source = null)
        {
            this.Identifier = identifier;
            this.Scope = scope;
            this.Access = access;
            this.Source = source;
        }

        /// <summary>
        /// An identifier, similar to a key in an Environment variable.  Its used when envoking the Scoped Variable.
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// Information about the assignment of the scoped variable and how it is invoked.
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ScopedVariableScope Scope { get; set; }

        /// <summary>
        /// The way the scoped variable is accessed.
        /// </summary>
        [JsonProperty("access", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ScopedVariableAccess Access { get; set; }

        /// <summary>
        /// The source or value of the Scoped Variable.
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public V1EnvironmentsScopedVariablesRequest1Source Source { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"V1EnvironmentsScopedVariablesRequest1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is V1EnvironmentsScopedVariablesRequest1 other &&                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
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