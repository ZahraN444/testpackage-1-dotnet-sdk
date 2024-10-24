// <copyright file="Job2.cs" company="APIMatic">
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
    /// Job2.
    /// </summary>
    public class Job2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Job2"/> class.
        /// </summary>
        public Job2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Job2"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="accepted">accepted.</param>
        /// <param name="queue">queue.</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="parallel">parallel.</param>
        /// <param name="tasks">tasks.</param>
        public Job2(
            string id,
            bool accepted,
            string queue,
            DateTime schedule,
            Models.Parallel parallel,
            List<Models.NewTask> tasks = null)
        {
            this.Id = id;
            this.Accepted = accepted;
            this.Queue = queue;
            this.Schedule = schedule;
            this.Parallel = parallel;
            this.Tasks = tasks;
        }

        /// <summary>
        /// The ID of the job
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Describes if the job has been accepted
        /// </summary>
        [JsonProperty("accepted")]
        public bool Accepted { get; set; }

        /// <summary>
        /// Describes the queue this job is a part of.
        /// </summary>
        [JsonProperty("queue")]
        public string Queue { get; set; }

        /// <summary>
        /// Gets or sets Schedule.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("schedule")]
        public DateTime Schedule { get; set; }

        /// <summary>
        /// Gets or sets Parallel.
        /// </summary>
        [JsonProperty("parallel")]
        public Models.Parallel Parallel { get; set; }

        /// <summary>
        /// Gets or sets Tasks.
        /// </summary>
        [JsonProperty("tasks", NullValueHandling = NullValueHandling.Include)]
        public List<Models.NewTask> Tasks { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Job2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Job2 other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                this.Accepted.Equals(other.Accepted) &&
                ((this.Queue == null && other.Queue == null) || (this.Queue?.Equals(other.Queue) == true)) &&
                this.Schedule.Equals(other.Schedule) &&
                ((this.Parallel == null && other.Parallel == null) || (this.Parallel?.Equals(other.Parallel) == true)) &&
                ((this.Tasks == null && other.Tasks == null) || (this.Tasks?.Equals(other.Tasks) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Accepted = {this.Accepted}");
            toStringOutput.Add($"this.Queue = {(this.Queue == null ? "null" : this.Queue)}");
            toStringOutput.Add($"this.Schedule = {this.Schedule}");
            toStringOutput.Add($"this.Parallel = {(this.Parallel == null ? "null" : this.Parallel.ToString())}");
            toStringOutput.Add($"this.Tasks = {(this.Tasks == null ? "null" : $"[{string.Join(", ", this.Tasks)} ]")}");
        }
    }
}