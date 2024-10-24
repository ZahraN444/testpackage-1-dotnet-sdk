// <copyright file="Filter16.cs" company="APIMatic">
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
    /// Filter16.
    /// </summary>
    public class Filter16
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Filter16"/> class.
        /// </summary>
        public Filter16()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Filter16"/> class.
        /// </summary>
        /// <param name="search">search.</param>
        /// <param name="state">state.</param>
        /// <param name="user">user.</param>
        /// <param name="environment">environment.</param>
        /// <param name="container">container.</param>
        /// <param name="instance">instance.</param>
        /// <param name="server">server.</param>
        /// <param name="events">events.</param>
        /// <param name="verbosity">verbosity.</param>
        public Filter16(
            string search = null,
            string state = null,
            string user = null,
            string environment = null,
            string container = null,
            string instance = null,
            string server = null,
            string events = null,
            int? verbosity = null)
        {
            this.Search = search;
            this.State = state;
            this.User = user;
            this.Environment = environment;
            this.Container = container;
            this.Instance = instance;
            this.Server = server;
            this.Events = events;
            this.Verbosity = verbosity;
        }

        /// <summary>
        /// `filter[search]=value` search activities for a value associated with a field on the given activity(s).
        /// </summary>
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// `filter[state]=value1,value2` state filtering will allow you to filter by the activity's current state.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// `filter[user]=ID` user filtering by ID. Submit the ID of the user you wish to filter for and the return will be any activity from that user.
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public string User { get; set; }

        /// <summary>
        /// `filter[environment]=ID` environment filtering by ID. Submit the ID of the environment you wish to filter for and the return will be any activity from that environment.
        /// </summary>
        [JsonProperty("environment", NullValueHandling = NullValueHandling.Ignore)]
        public string Environment { get; set; }

        /// <summary>
        /// `filter[container]=ID` container filtering by ID. Submit the ID of the container you wish to filter for and the return will be any activity from that container.
        /// </summary>
        [JsonProperty("container", NullValueHandling = NullValueHandling.Ignore)]
        public string Container { get; set; }

        /// <summary>
        /// `filter[instance]=ID` instance filtering by ID. Submit the ID of the instance you wish to filter for and the return will be any activity from that instance.
        /// </summary>
        [JsonProperty("instance", NullValueHandling = NullValueHandling.Ignore)]
        public string Instance { get; set; }

        /// <summary>
        /// `filter[server]=ID` server filtering by ID. Submit the ID of the server you wish to filter for and the return will be any activity from that server.
        /// </summary>
        [JsonProperty("server", NullValueHandling = NullValueHandling.Ignore)]
        public string Server { get; set; }

        /// <summary>
        /// `filter[events]=value` filter by event names. Example: `filter[events]=environment.services.vpn.login`
        /// </summary>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public string Events { get; set; }

        /// <summary>
        /// `filter[verbosity]=integer` filter the activity return by verbosity. The verbosity can be:
        ///   `0` - Activity that users would find useful.
        ///   `1` - Activity that can be useful when tracking down how something happened.
        ///   `2` - Full activity, can be useful in debugging problems.
        /// </summary>
        [JsonProperty("verbosity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Verbosity { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Filter16 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Filter16 other &&                ((this.Search == null && other.Search == null) || (this.Search?.Equals(other.Search) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.User == null && other.User == null) || (this.User?.Equals(other.User) == true)) &&
                ((this.Environment == null && other.Environment == null) || (this.Environment?.Equals(other.Environment) == true)) &&
                ((this.Container == null && other.Container == null) || (this.Container?.Equals(other.Container) == true)) &&
                ((this.Instance == null && other.Instance == null) || (this.Instance?.Equals(other.Instance) == true)) &&
                ((this.Server == null && other.Server == null) || (this.Server?.Equals(other.Server) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                ((this.Verbosity == null && other.Verbosity == null) || (this.Verbosity?.Equals(other.Verbosity) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Search = {(this.Search == null ? "null" : this.Search)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.User = {(this.User == null ? "null" : this.User)}");
            toStringOutput.Add($"this.Environment = {(this.Environment == null ? "null" : this.Environment)}");
            toStringOutput.Add($"this.Container = {(this.Container == null ? "null" : this.Container)}");
            toStringOutput.Add($"this.Instance = {(this.Instance == null ? "null" : this.Instance)}");
            toStringOutput.Add($"this.Server = {(this.Server == null ? "null" : this.Server)}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events)}");
            toStringOutput.Add($"this.Verbosity = {(this.Verbosity == null ? "null" : this.Verbosity.ToString())}");
        }
    }
}