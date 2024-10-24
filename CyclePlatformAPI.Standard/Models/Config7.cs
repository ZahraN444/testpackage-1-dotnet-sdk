// <copyright file="Config7.cs" company="APIMatic">
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
    /// Config7.
    /// </summary>
    public class Config7
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Config7"/> class.
        /// </summary>
        public Config7()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Config7"/> class.
        /// </summary>
        /// <param name="user">user.</param>
        /// <param name="ports">ports.</param>
        /// <param name="env">env.</param>
        /// <param name="labels">labels.</param>
        /// <param name="command">command.</param>
        /// <param name="entrypoint">entrypoint.</param>
        /// <param name="volumes">volumes.</param>
        /// <param name="workdir">workdir.</param>
        /// <param name="signalStop">signal_stop.</param>
        public Config7(
            string user,
            List<Models.Port> ports,
            Dictionary<string, string> env,
            Dictionary<string, string> labels,
            List<string> command,
            List<string> entrypoint,
            List<Models.Volume> volumes,
            string workdir,
            string signalStop)
        {
            this.User = user;
            this.Ports = ports;
            this.Env = env;
            this.Labels = labels;
            this.Command = command;
            this.Entrypoint = entrypoint;
            this.Volumes = volumes;
            this.Workdir = workdir;
            this.SignalStop = signalStop;
        }

        /// <summary>
        /// The linux user this image runs its processes as.
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// The port settings for the image.
        /// </summary>
        [JsonProperty("ports")]
        public List<Models.Port> Ports { get; set; }

        /// <summary>
        /// Image defined environment variables for the image.
        /// </summary>
        [JsonProperty("env")]
        public Dictionary<string, string> Env { get; set; }

        /// <summary>
        /// Image labels.
        /// </summary>
        [JsonProperty("labels")]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The CMD array used to start the container.
        /// </summary>
        [JsonProperty("command")]
        public List<string> Command { get; set; }

        /// <summary>
        /// An entrypoint command.
        /// </summary>
        [JsonProperty("entrypoint")]
        public List<string> Entrypoint { get; set; }

        /// <summary>
        /// Volumes information for the given image.
        /// </summary>
        [JsonProperty("volumes")]
        public List<Models.Volume> Volumes { get; set; }

        /// <summary>
        /// The working directory for the image.
        /// </summary>
        [JsonProperty("workdir")]
        public string Workdir { get; set; }

        /// <summary>
        /// A set command to be run if a signal is called.
        /// </summary>
        [JsonProperty("signal_stop")]
        public string SignalStop { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Config7 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Config7 other &&                ((this.User == null && other.User == null) || (this.User?.Equals(other.User) == true)) &&
                ((this.Ports == null && other.Ports == null) || (this.Ports?.Equals(other.Ports) == true)) &&
                ((this.Env == null && other.Env == null) || (this.Env?.Equals(other.Env) == true)) &&
                ((this.Labels == null && other.Labels == null) || (this.Labels?.Equals(other.Labels) == true)) &&
                ((this.Command == null && other.Command == null) || (this.Command?.Equals(other.Command) == true)) &&
                ((this.Entrypoint == null && other.Entrypoint == null) || (this.Entrypoint?.Equals(other.Entrypoint) == true)) &&
                ((this.Volumes == null && other.Volumes == null) || (this.Volumes?.Equals(other.Volumes) == true)) &&
                ((this.Workdir == null && other.Workdir == null) || (this.Workdir?.Equals(other.Workdir) == true)) &&
                ((this.SignalStop == null && other.SignalStop == null) || (this.SignalStop?.Equals(other.SignalStop) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.User = {(this.User == null ? "null" : this.User)}");
            toStringOutput.Add($"this.Ports = {(this.Ports == null ? "null" : $"[{string.Join(", ", this.Ports)} ]")}");
            toStringOutput.Add($"Env = {(this.Env == null ? "null" : this.Env.ToString())}");
            toStringOutput.Add($"Labels = {(this.Labels == null ? "null" : this.Labels.ToString())}");
            toStringOutput.Add($"this.Command = {(this.Command == null ? "null" : $"[{string.Join(", ", this.Command)} ]")}");
            toStringOutput.Add($"this.Entrypoint = {(this.Entrypoint == null ? "null" : $"[{string.Join(", ", this.Entrypoint)} ]")}");
            toStringOutput.Add($"this.Volumes = {(this.Volumes == null ? "null" : $"[{string.Join(", ", this.Volumes)} ]")}");
            toStringOutput.Add($"this.Workdir = {(this.Workdir == null ? "null" : this.Workdir)}");
            toStringOutput.Add($"this.SignalStop = {(this.SignalStop == null ? "null" : this.SignalStop)}");
        }
    }
}