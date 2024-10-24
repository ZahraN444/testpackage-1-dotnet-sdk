// <copyright file="ContainerRuntime.cs" company="APIMatic">
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
    /// ContainerRuntime.
    /// </summary>
    public class ContainerRuntime
    {
        private Models.Command1 command;
        private Models.Seccomp1 seccomp;
        private Models.Host host;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "command", false },
            { "seccomp", false },
            { "host", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRuntime"/> class.
        /// </summary>
        public ContainerRuntime()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerRuntime"/> class.
        /// </summary>
        /// <param name="privileged">privileged.</param>
        /// <param name="command">command.</param>
        /// <param name="namespaces">namespaces.</param>
        /// <param name="environmentVars">environment_vars.</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="workdir">workdir.</param>
        /// <param name="sysctl">sysctl.</param>
        /// <param name="rlimits">rlimits.</param>
        /// <param name="seccomp">seccomp.</param>
        /// <param name="host">host.</param>
        /// <param name="rootfs">rootfs.</param>
        public ContainerRuntime(
            bool privileged,
            Models.Command1 command = null,
            List<Models.NamespaceEnum> namespaces = null,
            Dictionary<string, string> environmentVars = null,
            List<Models.Capabilities4Enum> capabilities = null,
            string workdir = null,
            Dictionary<string, string> sysctl = null,
            Dictionary<string, Models.Rlimits1> rlimits = null,
            Models.Seccomp1 seccomp = null,
            Models.Host host = null,
            Models.Rootfs1 rootfs = null)
        {
            if (command != null)
            {
                this.Command = command;
            }

            this.Namespaces = namespaces;
            this.EnvironmentVars = environmentVars;
            this.Privileged = privileged;
            this.Capabilities = capabilities;
            this.Workdir = workdir;
            this.Sysctl = sysctl;
            this.Rlimits = rlimits;
            if (seccomp != null)
            {
                this.Seccomp = seccomp;
            }

            if (host != null)
            {
                this.Host = host;
            }

            this.Rootfs = rootfs;
        }

        /// <summary>
        /// A command that will be run in place of the images defined startup command.
        /// </summary>
        [JsonProperty("command")]
        public Models.Command1 Command
        {
            get
            {
                return this.command;
            }

            set
            {
                this.shouldSerialize["command"] = true;
                this.command = value;
            }
        }

        /// <summary>
        /// Namespaces the given container will have access to.
        /// </summary>
        [JsonProperty("namespaces", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.NamespaceEnum> Namespaces { get; set; }

        /// <summary>
        /// A record of environment variables for the given container.
        /// </summary>
        [JsonProperty("environment_vars", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> EnvironmentVars { get; set; }

        /// <summary>
        /// Selecting this option will give this container full permissions on the server. This is not recommended and increases the likelihood of your server being compromised.
        /// </summary>
        [JsonProperty("privileged")]
        public bool Privileged { get; set; }

        /// <summary>
        /// A list of linux kernel capabilites for the given container.
        /// </summary>
        [JsonProperty("capabilities", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Capabilities4Enum> Capabilities { get; set; }

        /// <summary>
        /// Configure the working directory for the given container.
        /// </summary>
        [JsonProperty("workdir", NullValueHandling = NullValueHandling.Ignore)]
        public string Workdir { get; set; }

        /// <summary>
        /// A record of sysctl fields and values for a given container.
        /// </summary>
        [JsonProperty("sysctl", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Sysctl { get; set; }

        /// <summary>
        /// A record of rlimits and their values.
        /// </summary>
        [JsonProperty("rlimits", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Rlimits1> Rlimits { get; set; }

        /// <summary>
        /// Gets or sets Seccomp.
        /// </summary>
        [JsonProperty("seccomp")]
        public Models.Seccomp1 Seccomp
        {
            get
            {
                return this.seccomp;
            }

            set
            {
                this.shouldSerialize["seccomp"] = true;
                this.seccomp = value;
            }
        }

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
        /// Gets or sets Rootfs.
        /// </summary>
        [JsonProperty("rootfs", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Rootfs1 Rootfs { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ContainerRuntime : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCommand()
        {
            this.shouldSerialize["command"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSeccomp()
        {
            this.shouldSerialize["seccomp"] = false;
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
        public bool ShouldSerializeCommand()
        {
            return this.shouldSerialize["command"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSeccomp()
        {
            return this.shouldSerialize["seccomp"];
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
            return obj is ContainerRuntime other &&                ((this.Command == null && other.Command == null) || (this.Command?.Equals(other.Command) == true)) &&
                ((this.Namespaces == null && other.Namespaces == null) || (this.Namespaces?.Equals(other.Namespaces) == true)) &&
                ((this.EnvironmentVars == null && other.EnvironmentVars == null) || (this.EnvironmentVars?.Equals(other.EnvironmentVars) == true)) &&
                this.Privileged.Equals(other.Privileged) &&
                ((this.Capabilities == null && other.Capabilities == null) || (this.Capabilities?.Equals(other.Capabilities) == true)) &&
                ((this.Workdir == null && other.Workdir == null) || (this.Workdir?.Equals(other.Workdir) == true)) &&
                ((this.Sysctl == null && other.Sysctl == null) || (this.Sysctl?.Equals(other.Sysctl) == true)) &&
                ((this.Rlimits == null && other.Rlimits == null) || (this.Rlimits?.Equals(other.Rlimits) == true)) &&
                ((this.Seccomp == null && other.Seccomp == null) || (this.Seccomp?.Equals(other.Seccomp) == true)) &&
                ((this.Host == null && other.Host == null) || (this.Host?.Equals(other.Host) == true)) &&
                ((this.Rootfs == null && other.Rootfs == null) || (this.Rootfs?.Equals(other.Rootfs) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Command = {(this.Command == null ? "null" : this.Command.ToString())}");
            toStringOutput.Add($"this.Namespaces = {(this.Namespaces == null ? "null" : $"[{string.Join(", ", this.Namespaces)} ]")}");
            toStringOutput.Add($"EnvironmentVars = {(this.EnvironmentVars == null ? "null" : this.EnvironmentVars.ToString())}");
            toStringOutput.Add($"this.Privileged = {this.Privileged}");
            toStringOutput.Add($"this.Capabilities = {(this.Capabilities == null ? "null" : $"[{string.Join(", ", this.Capabilities)} ]")}");
            toStringOutput.Add($"this.Workdir = {(this.Workdir == null ? "null" : this.Workdir)}");
            toStringOutput.Add($"Sysctl = {(this.Sysctl == null ? "null" : this.Sysctl.ToString())}");
            toStringOutput.Add($"Rlimits = {(this.Rlimits == null ? "null" : this.Rlimits.ToString())}");
            toStringOutput.Add($"this.Seccomp = {(this.Seccomp == null ? "null" : this.Seccomp.ToString())}");
            toStringOutput.Add($"this.Host = {(this.Host == null ? "null" : this.Host.ToString())}");
            toStringOutput.Add($"this.Rootfs = {(this.Rootfs == null ? "null" : this.Rootfs.ToString())}");
        }
    }
}