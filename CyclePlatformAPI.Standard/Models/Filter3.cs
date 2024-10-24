// <copyright file="Filter3.cs" company="APIMatic">
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
    /// Filter3.
    /// </summary>
    public class Filter3
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter3"/> class.
        /// </summary>
        public Filter3()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter3"/> class.
        /// </summary>
        /// <param name="creator">creator.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="search">search.</param>
        /// <param name="state">state.</param>
        /// <param name="stackBuild">stack_build.</param>
        public Filter3(
            string creator = null,
            string identifier = null,
            string search = null,
            string state = null,
            string stackBuild = null)
        {
            this.Creator = creator;
            this.Identifier = identifier;
            this.Search = search;
            this.State = state;
            this.StackBuild = stackBuild;
        }

        /// <summary>
        /// `filter[creator]=account-ID` filter for environments matching a particular creator, such as `account-ID`.
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// `filter[identifier]=value` List only those environments matching this identifier. May return multiple results.
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// `filter[search]=value` search for a value associated with a field on the given environment(s).
        /// </summary>
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// `filter[state]=value1,value2` state filtering will allow you to filter by the environment's current state.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// `filter[stack_build]=ID` stack build filtering by ID.  Submit the ID of the stack build you wish to filter for and the return sill be any environments that have the stack build deployed to them.
        /// </summary>
        [JsonProperty("stack_build", NullValueHandling = NullValueHandling.Ignore)]
        public string StackBuild { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter3 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter3 other &&                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Search == null && other.Search == null) || (this.Search?.Equals(other.Search) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.StackBuild == null && other.StackBuild == null) || (this.StackBuild?.Equals(other.StackBuild) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator)}");
            toStringOutput.Add($"this.Identifier = {(this.Identifier == null ? "null" : this.Identifier)}");
            toStringOutput.Add($"this.Search = {(this.Search == null ? "null" : this.Search)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.StackBuild = {(this.StackBuild == null ? "null" : this.StackBuild)}");
        }
    }
}