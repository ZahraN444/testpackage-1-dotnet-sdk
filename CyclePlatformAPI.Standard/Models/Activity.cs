// <copyright file="Activity.cs" company="APIMatic">
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
    /// Activity.
    /// </summary>
    public class Activity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Activity"/> class.
        /// </summary>
        public Activity()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Activity"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="user">user.</param>
        /// <param name="verbosity">verbosity.</param>
        /// <param name="context">context.</param>
        /// <param name="session">session.</param>
        /// <param name="changes">changes.</param>
        /// <param name="annotations">annotations.</param>
        /// <param name="status">status.</param>
        /// <param name="mEvent">event.</param>
        /// <param name="time">time.</param>
        /// <param name="error">error.</param>
        /// <param name="component">component.</param>
        /// <param name="tags">tags.</param>
        /// <param name="security">security.</param>
        /// <param name="monitor">monitor.</param>
        public Activity(
            string id,
            string hubId,
            Models.User user,
            int verbosity,
            Models.ActivityContext context,
            ActivitySession2 session,
            List<Models.ActivityChange> changes,
            object annotations,
            Models.Status1Enum status,
            Models.Event2Enum mEvent,
            DateTime time,
            Models.Error3 error = null,
            Models.Component component = null,
            List<string> tags = null,
            Models.ActivitySecurity security = null,
            Models.ActivityMonitor monitor = null)
        {
            this.Id = id;
            this.HubId = hubId;
            this.User = user;
            this.Verbosity = verbosity;
            this.Context = context;
            this.Session = session;
            this.Changes = changes;
            this.Annotations = annotations;
            this.Error = error;
            this.Component = component;
            this.Tags = tags;
            this.Status = status;
            this.Security = security;
            this.Monitor = monitor;
            this.MEvent = mEvent;
            this.Time = time;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The unique ID of the Hub this resource was created in.
        /// </summary>
        [JsonProperty("hub_id")]
        public string HubId { get; set; }

        /// <summary>
        /// Userscope
        /// </summary>
        [JsonProperty("user")]
        public Models.User User { get; set; }

        /// <summary>
        /// A number representing the detail level (verbosity) of this activity.
        /// ## Levels
        /// - 0: activity that other users would find useful
        /// - 1: activity that can be useful in tracking down how a user did something
        /// - 2: full activity, can be useful in debugging problems
        /// </summary>
        [JsonProperty("verbosity")]
        public int Verbosity { get; set; }

        /// <summary>
        /// ID context for resources associated with an activity.
        /// </summary>
        [JsonProperty("context")]
        public Models.ActivityContext Context { get; set; }

        /// <summary>
        /// Gets or sets Session.
        /// </summary>
        [JsonProperty("session")]
        public ActivitySession2 Session { get; set; }

        /// <summary>
        /// An array of changes.
        /// </summary>
        [JsonProperty("changes")]
        public List<Models.ActivityChange> Changes { get; set; }

        /// <summary>
        /// A record of additional annotations for the activity.
        /// </summary>
        [JsonProperty("annotations")]
        public object Annotations { get; set; }

        /// <summary>
        /// An object describing a given activity error.
        /// </summary>
        [JsonProperty("error", NullValueHandling = NullValueHandling.Include)]
        public Models.Error3 Error { get; set; }

        /// <summary>
        /// An object holding information about a component.
        /// </summary>
        [JsonProperty("component", NullValueHandling = NullValueHandling.Include)]
        public Models.Component Component { get; set; }

        /// <summary>
        /// An array of tags that denote things such as a type of security event, or can be user-provided.
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// A status for the given activity.
        /// </summary>
        [JsonProperty("status")]
        public Models.Status1Enum Status { get; set; }

        /// <summary>
        /// Security information pertaining to this activity.
        /// </summary>
        [JsonProperty("security", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ActivitySecurity Security { get; set; }

        /// <summary>
        /// Details related to the monitor that raised this activity event.
        /// </summary>
        [JsonProperty("monitor", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ActivityMonitor Monitor { get; set; }

        /// <summary>
        /// The activity event.
        /// </summary>
        [JsonProperty("event")]
        public Models.Event2Enum MEvent { get; set; }

        /// <summary>
        /// A timestamp for when the activity took place.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Activity : ({string.Join(", ", toStringOutput)})";
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
            return obj is Activity other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.User == null && other.User == null) || (this.User?.Equals(other.User) == true)) &&
                this.Verbosity.Equals(other.Verbosity) &&
                ((this.Context == null && other.Context == null) || (this.Context?.Equals(other.Context) == true)) &&
                ((this.Session == null && other.Session == null) || (this.Session?.Equals(other.Session) == true)) &&
                ((this.Changes == null && other.Changes == null) || (this.Changes?.Equals(other.Changes) == true)) &&
                ((this.Annotations == null && other.Annotations == null) || (this.Annotations?.Equals(other.Annotations) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true)) &&
                ((this.Component == null && other.Component == null) || (this.Component?.Equals(other.Component) == true)) &&
                ((this.Tags == null && other.Tags == null) || (this.Tags?.Equals(other.Tags) == true)) &&
                this.Status.Equals(other.Status) &&
                ((this.Security == null && other.Security == null) || (this.Security?.Equals(other.Security) == true)) &&
                ((this.Monitor == null && other.Monitor == null) || (this.Monitor?.Equals(other.Monitor) == true)) &&
                this.MEvent.Equals(other.MEvent) &&
                this.Time.Equals(other.Time);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.User = {(this.User == null ? "null" : this.User.ToString())}");
            toStringOutput.Add($"this.Verbosity = {this.Verbosity}");
            toStringOutput.Add($"this.Context = {(this.Context == null ? "null" : this.Context.ToString())}");
            toStringOutput.Add($"Session = {(this.Session == null ? "null" : this.Session.ToString())}");
            toStringOutput.Add($"this.Changes = {(this.Changes == null ? "null" : $"[{string.Join(", ", this.Changes)} ]")}");
            toStringOutput.Add($"Annotations = {(this.Annotations == null ? "null" : this.Annotations.ToString())}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"this.Component = {(this.Component == null ? "null" : this.Component.ToString())}");
            toStringOutput.Add($"this.Tags = {(this.Tags == null ? "null" : $"[{string.Join(", ", this.Tags)} ]")}");
            toStringOutput.Add($"this.Status = {this.Status}");
            toStringOutput.Add($"this.Security = {(this.Security == null ? "null" : this.Security.ToString())}");
            toStringOutput.Add($"this.Monitor = {(this.Monitor == null ? "null" : this.Monitor.ToString())}");
            toStringOutput.Add($"this.MEvent = {this.MEvent}");
            toStringOutput.Add($"this.Time = {this.Time}");
        }
    }
}