// <copyright file="StackContainerConfigRuntime.cs" company="APIMatic">
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
    /// StackContainerConfigRuntime.
    /// </summary>
    public class StackContainerConfigRuntime
    {
        private Models.Host host;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "host", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="StackContainerConfigRuntime"/> class.
        /// </summary>
        public StackContainerConfigRuntime()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StackContainerConfigRuntime"/> class.
        /// </summary>
        /// <param name="workdir">workdir.</param>
        /// <param name="command">command.</param>
        /// <param name="environmentVars">environment_vars.</param>
        /// <param name="namespaces">namespaces.</param>
        /// <param name="sysctl">sysctl.</param>
        /// <param name="rlimits">rlimits.</param>
        /// <param name="seccomp">seccomp.</param>
        /// <param name="host">host.</param>
        /// <param name="privileged">privileged.</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="rootfs">rootfs.</param>
        public StackContainerConfigRuntime(
            string workdir = null,
            Models.Command command = null,
            Dictionary<string, string> environmentVars = null,
            List<Models.NamespaceEnum> namespaces = null,
            Dictionary<string, string> sysctl = null,
            Dictionary<string, Models.Rlimits> rlimits = null,
            Models.Seccomp seccomp = null,
            Models.Host host = null,
            bool? privileged = null,
            List<Models.Capabilities4Enum> capabilities = null,
            Models.Rootfs rootfs = null)
        {
            this.Workdir = workdir;
            this.Command = command;
            this.EnvironmentVars = environmentVars;
            this.Namespaces = namespaces;
            this.Sysctl = sysctl;
            this.Rlimits = rlimits;
            this.Seccomp = seccomp;
            if (host != null)
            {
                this.Host = host;
            }

            this.Privileged = privileged;
            this.Capabilities = capabilities;
            this.Rootfs = rootfs;
        }

        /// <summary>
        /// Gets or sets Workdir.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter))]
        [JsonProperty("workdir", NullValueHandling = NullValueHandling.Ignore)]
        public string Workdir { get; set; }

        /// <summary>
        /// Gets or sets Command.
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Command Command { get; set; }

        /// <summary>
        /// Gets or sets EnvironmentVars.
        /// </summary>
        [JsonConverter(typeof(CoreMapConverter), typeof(JsonStringConverter))]
        [JsonProperty("environment_vars", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> EnvironmentVars { get; set; }

        /// <summary>
        /// Gets or sets Namespaces.
        /// </summary>
        [JsonProperty("namespaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.NamespaceEnum> Namespaces { get; set; }

        /// <summary>
        /// Gets or sets Sysctl.
        /// </summary>
        [JsonConverter(typeof(CoreMapConverter), typeof(JsonStringConverter))]
        [JsonProperty("sysctl", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Sysctl { get; set; }

        /// <summary>
        /// Gets or sets Rlimits.
        /// </summary>
        [JsonProperty("rlimits", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Rlimits> Rlimits { get; set; }

        /// <summary>
        /// Gets or sets Seccomp.
        /// </summary>
        [JsonProperty("seccomp", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Seccomp Seccomp { get; set; }

        /// <summary>
        /// Gets or sets Host.
        /// </summary>
        [JsonProperty("host")]
        public Models.Host Host
        {
            get
            {
                return this.host;
            }

            set
            {
                this.shouldSerialize["host"] = true;
                this.host = value;
            }
        }

        /// <summary>
        /// Gets or sets Privileged.
        /// </summary>
        [JsonProperty("privileged", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Privileged { get; set; }

        /// <summary>
        /// Gets or sets Capabilities.
        /// </summary>
        [JsonProperty("capabilities", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Capabilities4Enum> Capabilities { get; set; }

        /// <summary>
        /// Gets or sets Rootfs.
        /// </summary>
        [JsonProperty("rootfs", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Rootfs Rootfs { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StackContainerConfigRuntime : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHost()
        {
            this.shouldSerialize["host"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHost()
        {
            return this.shouldSerialize["host"];
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
            return obj is StackContainerConfigRuntime other &&                ((this.Workdir == null && other.Workdir == null) || (this.Workdir?.Equals(other.Workdir) == true)) &&
                ((this.Command == null && other.Command == null) || (this.Command?.Equals(other.Command) == true)) &&
                ((this.EnvironmentVars == null && other.EnvironmentVars == null) || (this.EnvironmentVars?.Equals(other.EnvironmentVars) == true)) &&
                ((this.Namespaces == null && other.Namespaces == null) || (this.Namespaces?.Equals(other.Namespaces) == true)) &&
                ((this.Sysctl == null && other.Sysctl == null) || (this.Sysctl?.Equals(other.Sysctl) == true)) &&
                ((this.Rlimits == null && other.Rlimits == null) || (this.Rlimits?.Equals(other.Rlimits) == true)) &&
                ((this.Seccomp == null && other.Seccomp == null) || (this.Seccomp?.Equals(other.Seccomp) == true)) &&
                ((this.Host == null && other.Host == null) || (this.Host?.Equals(other.Host) == true)) &&
                ((this.Privileged == null && other.Privileged == null) || (this.Privileged?.Equals(other.Privileged) == true)) &&
                ((this.Capabilities == null && other.Capabilities == null) || (this.Capabilities?.Equals(other.Capabilities) == true)) &&
                ((this.Rootfs == null && other.Rootfs == null) || (this.Rootfs?.Equals(other.Rootfs) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Workdir = {(this.Workdir == null ? "null" : this.Workdir)}");
            toStringOutput.Add($"this.Command = {(this.Command == null ? "null" : this.Command.ToString())}");
            toStringOutput.Add($"EnvironmentVars = {(this.EnvironmentVars == null ? "null" : this.EnvironmentVars.ToString())}");
            toStringOutput.Add($"this.Namespaces = {(this.Namespaces == null ? "null" : $"[{string.Join(", ", this.Namespaces)} ]")}");
            toStringOutput.Add($"Sysctl = {(this.Sysctl == null ? "null" : this.Sysctl.ToString())}");
            toStringOutput.Add($"Rlimits = {(this.Rlimits == null ? "null" : this.Rlimits.ToString())}");
            toStringOutput.Add($"this.Seccomp = {(this.Seccomp == null ? "null" : this.Seccomp.ToString())}");
            toStringOutput.Add($"this.Host = {(this.Host == null ? "null" : this.Host.ToString())}");
            toStringOutput.Add($"this.Privileged = {(this.Privileged == null ? "null" : this.Privileged.ToString())}");
            toStringOutput.Add($"this.Capabilities = {(this.Capabilities == null ? "null" : $"[{string.Join(", ", this.Capabilities)} ]")}");
            toStringOutput.Add($"this.Rootfs = {(this.Rootfs == null ? "null" : this.Rootfs.ToString())}");
        }
    }
}