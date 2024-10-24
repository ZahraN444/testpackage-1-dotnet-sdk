// <copyright file="InstanceVolume.cs" company="APIMatic">
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
    /// InstanceVolume.
    /// </summary>
    public class InstanceVolume
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceVolume"/> class.
        /// </summary>
        public InstanceVolume()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceVolume"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="config">config.</param>
        /// <param name="deployed">deployed.</param>
        /// <param name="sftp">sftp.</param>
        public InstanceVolume(
            string id,
            Models.ContainerVolume config,
            Models.DeployedVolume deployed,
            Models.InstanceVolumeSFTP sftp)
        {
            this.Id = id;
            this.Config = config;
            this.Deployed = deployed;
            this.Sftp = sftp;
        }

        /// <summary>
        /// A 24 character hex string used to identify a unique resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Configuration settings for container volumes.
        /// </summary>
        [JsonProperty("config")]
        public Models.ContainerVolume Config { get; set; }

        /// <summary>
        /// A deployed volume resource.
        /// </summary>
        [JsonProperty("deployed")]
        public Models.DeployedVolume Deployed { get; set; }

        /// <summary>
        /// Information about connecting to a instance volume over SFTP.
        /// </summary>
        [JsonProperty("sftp")]
        public Models.InstanceVolumeSFTP Sftp { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstanceVolume : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstanceVolume other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Config == null && other.Config == null) || (this.Config?.Equals(other.Config) == true)) &&
                ((this.Deployed == null && other.Deployed == null) || (this.Deployed?.Equals(other.Deployed) == true)) &&
                ((this.Sftp == null && other.Sftp == null) || (this.Sftp?.Equals(other.Sftp) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Config = {(this.Config == null ? "null" : this.Config.ToString())}");
            toStringOutput.Add($"this.Deployed = {(this.Deployed == null ? "null" : this.Deployed.ToString())}");
            toStringOutput.Add($"this.Sftp = {(this.Sftp == null ? "null" : this.Sftp.ToString())}");
        }
    }
}