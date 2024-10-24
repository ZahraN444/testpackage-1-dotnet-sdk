// <copyright file="Announcement.cs" company="APIMatic">
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
    /// Announcement.
    /// </summary>
    public class Announcement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Announcement"/> class.
        /// </summary>
        public Announcement()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Announcement"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="title">title.</param>
        /// <param name="description">description.</param>
        /// <param name="updates">updates.</param>
        /// <param name="creator">creator.</param>
        /// <param name="state">state.</param>
        /// <param name="priority">priority.</param>
        /// <param name="events">events.</param>
        /// <param name="affectedIntegrations">affected_integrations.</param>
        public Announcement(
            string id,
            string title,
            string description,
            List<Models.AnnoucementUpdate> updates,
            Models.CreatorScope creator,
            Models.State2 state,
            Models.PriorityEnum priority,
            Models.AnnouncementEvents events,
            List<string> affectedIntegrations = null)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.Updates = updates;
            this.AffectedIntegrations = affectedIntegrations;
            this.Creator = creator;
            this.State = state;
            this.Priority = priority;
            this.Events = events;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// A description of the event being announced.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// A description of the announcement
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Updates.
        /// </summary>
        [JsonProperty("updates")]
        public List<Models.AnnoucementUpdate> Updates { get; set; }

        /// <summary>
        /// Gets or sets AffectedIntegrations.
        /// </summary>
        [JsonProperty("affected_integrations", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AffectedIntegrations { get; set; }

        /// <summary>
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator")]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.State2 State { get; set; }

        /// <summary>
        /// The priority or severity of the announcement.
        /// </summary>
        [JsonProperty("priority")]
        public Models.PriorityEnum Priority { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the announcement's lifetime.
        /// </summary>
        [JsonProperty("events")]
        public Models.AnnouncementEvents Events { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Announcement : ({string.Join(", ", toStringOutput)})";
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
            return obj is Announcement other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Updates == null && other.Updates == null) || (this.Updates?.Equals(other.Updates) == true)) &&
                ((this.AffectedIntegrations == null && other.AffectedIntegrations == null) || (this.AffectedIntegrations?.Equals(other.AffectedIntegrations) == true)) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                this.Priority.Equals(other.Priority) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Updates = {(this.Updates == null ? "null" : $"[{string.Join(", ", this.Updates)} ]")}");
            toStringOutput.Add($"this.AffectedIntegrations = {(this.AffectedIntegrations == null ? "null" : $"[{string.Join(", ", this.AffectedIntegrations)} ]")}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.Priority = {this.Priority}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
        }
    }
}