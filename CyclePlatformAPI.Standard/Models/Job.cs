// <copyright file="Job.cs" company="APIMatic">
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
    /// Job.
    /// </summary>
    public class Job
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Job"/> class.
        /// </summary>
        public Job()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Job"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="hubId">hub_id.</param>
        /// <param name="queue">queue.</param>
        /// <param name="caption">caption.</param>
        /// <param name="events">events.</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="tasks">tasks.</param>
        /// <param name="expires">expires.</param>
        /// <param name="hash">hash.</param>
        /// <param name="limitDuplicates">limit_duplicates.</param>
        /// <param name="creator">creator.</param>
        /// <param name="state">state.</param>
        public Job(
            string id,
            string hubId,
            string queue,
            string caption,
            Models.JobEvents events,
            DateTime schedule,
            List<Models.JobTask> tasks,
            DateTime expires,
            string hash,
            bool limitDuplicates,
            Models.CreatorScope creator,
            Models.JobState state)
        {
            this.Id = id;
            this.HubId = hubId;
            this.Queue = queue;
            this.Caption = caption;
            this.Events = events;
            this.Schedule = schedule;
            this.Tasks = tasks;
            this.Expires = expires;
            this.Hash = hash;
            this.LimitDuplicates = limitDuplicates;
            this.Creator = creator;
            this.State = state;
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
        /// A dash separated string showing the environment_id where the job is taking place.
        /// </summary>
        [JsonProperty("queue")]
        public string Queue { get; set; }

        /// <summary>
        /// A short description of the job.
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }

        /// <summary>
        /// A collection of timestamps for each event in the job's lifetime.
        /// </summary>
        [JsonProperty("events")]
        public Models.JobEvents Events { get; set; }

        /// <summary>
        /// A timestamp of when the job was scheduled.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("schedule")]
        public DateTime Schedule { get; set; }

        /// <summary>
        /// An array of job tasks.
        /// </summary>
        [JsonProperty("tasks")]
        public List<Models.JobTask> Tasks { get; set; }

        /// <summary>
        /// A timestamp for when the job expires.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires")]
        public DateTime Expires { get; set; }

        /// <summary>
        /// A combination of the individual task details and job details.
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// A boolean where true represents the job is set to prevent duplicates of itself quickly after creation.
        /// </summary>
        [JsonProperty("limit_duplicates")]
        public bool LimitDuplicates { get; set; }

        /// <summary>
        /// The creator scope is embedded in resource objects to describe who created them
        /// </summary>
        [JsonProperty("creator")]
        public Models.CreatorScope Creator { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public Models.JobState State { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Job : ({string.Join(", ", toStringOutput)})";
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
            return obj is Job other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.HubId == null && other.HubId == null) || (this.HubId?.Equals(other.HubId) == true)) &&
                ((this.Queue == null && other.Queue == null) || (this.Queue?.Equals(other.Queue) == true)) &&
                ((this.Caption == null && other.Caption == null) || (this.Caption?.Equals(other.Caption) == true)) &&
                ((this.Events == null && other.Events == null) || (this.Events?.Equals(other.Events) == true)) &&
                this.Schedule.Equals(other.Schedule) &&
                ((this.Tasks == null && other.Tasks == null) || (this.Tasks?.Equals(other.Tasks) == true)) &&
                this.Expires.Equals(other.Expires) &&
                ((this.Hash == null && other.Hash == null) || (this.Hash?.Equals(other.Hash) == true)) &&
                this.LimitDuplicates.Equals(other.LimitDuplicates) &&
                ((this.Creator == null && other.Creator == null) || (this.Creator?.Equals(other.Creator) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.HubId = {(this.HubId == null ? "null" : this.HubId)}");
            toStringOutput.Add($"this.Queue = {(this.Queue == null ? "null" : this.Queue)}");
            toStringOutput.Add($"this.Caption = {(this.Caption == null ? "null" : this.Caption)}");
            toStringOutput.Add($"this.Events = {(this.Events == null ? "null" : this.Events.ToString())}");
            toStringOutput.Add($"this.Schedule = {this.Schedule}");
            toStringOutput.Add($"this.Tasks = {(this.Tasks == null ? "null" : $"[{string.Join(", ", this.Tasks)} ]")}");
            toStringOutput.Add($"this.Expires = {this.Expires}");
            toStringOutput.Add($"this.Hash = {(this.Hash == null ? "null" : this.Hash)}");
            toStringOutput.Add($"this.LimitDuplicates = {this.LimitDuplicates}");
            toStringOutput.Add($"this.Creator = {(this.Creator == null ? "null" : this.Creator.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
        }
    }
}