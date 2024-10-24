// <copyright file="Filter8.cs" company="APIMatic">
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
    /// Filter8.
    /// </summary>
    public class Filter8
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter8"/> class.
        /// </summary>
        public Filter8()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter8"/> class.
        /// </summary>
        /// <param name="creator">creator.</param>
        /// <param name="identifier">identifier.</param>
        /// <param name="search">search.</param>
        /// <param name="state">state.</param>
        /// <param name="service">service.</param>
        /// <param name="publicNetwork">public_network.</param>
        /// <param name="image">image.</param>
        /// <param name="environment">environment.</param>
        /// <param name="tags">tags.</param>
        /// <param name="stack">stack.</param>
        /// <param name="deployment">deployment.</param>
        /// <param name="rangeStart">range-start.</param>
        /// <param name="rangeEnd">range-end.</param>
        public Filter8(
            string creator = null,
            string identifier = null,
            string search = null,
            string state = null,
            string service = null,
            string publicNetwork = null,
            string image = null,
            string environment = null,
            string tags = null,
            string stack = null,
            string deployment = null,
            DateTime? rangeStart = null,
            DateTime? rangeEnd = null)
        {
            this.Creator = creator;
            this.Identifier = identifier;
            this.Search = search;
            this.State = state;
            this.Service = service;
            this.PublicNetwork = publicNetwork;
            this.Image = image;
            this.Environment = environment;
            this.Tags = tags;
            this.Stack = stack;
            this.Deployment = deployment;
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
        }

        /// <summary>
        /// `filter[creator]=account-ID` filter for containers matching a particular creator, such as `account-ID` or `environment-ID`
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// `filter[identifier]=value` List only those containers matching this identifier. May return multiple results.
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>
        /// `filter[search]=value` search containers for a value associated with a field on the given container(s).
        /// </summary>
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// `filter[state]=value1,value2` state filtering will allow you to filter by the container's current state.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// `filter[service]=value` service filtering will allow you to filter by service type: `loadbalancer`, `discovery`, `vpn`.
        /// </summary>
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }

        /// <summary>
        /// `filter[public_network]=value` public network filtering will allow you to filter by the containers network settings: `enabled`, `disabled`, `egress-only`.
        /// </summary>
        [JsonProperty("public_network", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicNetwork { get; set; }

        /// <summary>
        /// `filter[image]=ID` image filtering by ID.  Submit the ID of the image you wish to filter for and the return will be any containers currently using the image.
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public string Image { get; set; }

        /// <summary>
        /// `filter[environment]=ID` environment filtering by ID.  Submit the ID of the environment you wish to filter for and the return will be any containers in that environment.
        /// </summary>
        [JsonProperty("environment", NullValueHandling = NullValueHandling.Ignore)]
        public string Environment { get; set; }

        /// <summary>
        /// `filter[tags]=tagone,tagtwo,tagthree` container filtering using server tags. If the container has the tags you submit it will be part of the return.
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// `filter[stack]=ID` stack filtering by ID.  Submit the ID of the stack you wish to filter for and the return will be any containers deployed associated with 'containers' from the stack.
        /// </summary>
        [JsonProperty("stack", NullValueHandling = NullValueHandling.Ignore)]
        public string Stack { get; set; }

        /// <summary>
        /// `filter[deployment]=v1,v2` filter containers by deployment(s).
        /// </summary>
        [JsonProperty("deployment", NullValueHandling = NullValueHandling.Ignore)]
        public string Deployment { get; set; }

        /// <summary>
        /// The start date from when to pull the containers
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("range-start", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RangeStart { get; set; }

        /// <summary>
        /// The end date from when to pull the containers
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("range-end", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? RangeEnd { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter8 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter8 other &&                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.Identifier == null && other.Identifier == null) || (this.Identifier?.Equals(other.Identifier) == true)) &&
                ((this.Search == null && other.Search == null) || (this.Search?.Equals(other.Search) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Service == null && other.Service == null) || (this.Service?.Equals(other.Service) == true)) &&
                ((this.PublicNetwork == null && other.PublicNetwork == null) || (this.PublicNetwork?.Equals(other.PublicNetwork) == true)) &&
                ((this.Image == null && other.Image == null) || (this.Image?.Equals(other.Image) == true)) &&
                ((this.Environment == null && other.Environment == null) || (this.Environment?.Equals(other.Environment) == true)) &&
                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true)) &&
                ((this.Stack == null && other.Stack == null) || (this.Stack?.Equals(other.Stack) == true)) &&
                ((this.Deployment == null && other.Deployment == null) || (this.Deployment?.Equals(other.Deployment) == true)) &&
                ((this.RangeStart == null && other.RangeStart == null) || (this.RangeStart?.Equals(other.RangeStart) == true)) &&
                ((this.RangeEnd == null && other.RangeEnd == null) || (this.RangeEnd?.Equals(other.RangeEnd) == true));
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
            toStringOutput.Add($"this.Service = {(this.Service == null ? "null" : this.Service)}");
            toStringOutput.Add($"this.PublicNetwork = {(this.PublicNetwork == null ? "null" : this.PublicNetwork)}");
            toStringOutput.Add($"this.Image = {(this.Image == null ? "null" : this.Image)}");
            toStringOutput.Add($"this.Environment = {(this.Environment == null ? "null" : this.Environment)}");
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : this.Tags)}");
            toStringOutput.Add($"this.Stack = {(this.Stack == null ? "null" : this.Stack)}");
            toStringOutput.Add($"this.Deployment = {(this.Deployment == null ? "null" : this.Deployment)}");
            toStringOutput.Add($"this.RangeStart = {(this.RangeStart == null ? "null" : this.RangeStart.ToString())}");
            toStringOutput.Add($"this.RangeEnd = {(this.RangeEnd == null ? "null" : this.RangeEnd.ToString())}");
        }
    }
}