// <copyright file="InstanceVolumeSFTP.cs" company="APIMatic">
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
    /// InstanceVolumeSFTP.
    /// </summary>
    public class InstanceVolumeSFTP
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceVolumeSFTP"/> class.
        /// </summary>
        public InstanceVolumeSFTP()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceVolumeSFTP"/> class.
        /// </summary>
        /// <param name="host">host.</param>
        /// <param name="port">port.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        public InstanceVolumeSFTP(
            string host,
            double port,
            string username,
            Models.Password1 password)
        {
            this.Host = host;
            this.Port = port;
            this.Username = username;
            this.Password = password;
        }

        /// <summary>
        /// The hostname for connecting to the volume over SFTP.
        /// </summary>
        [JsonProperty("host")]
        public string Host { get; set; }

        /// <summary>
        /// The port number to use when connecting.
        /// </summary>
        [JsonProperty("port")]
        public double Port { get; set; }

        /// <summary>
        /// The username to use when connecting.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Password configuration settings for the remote access of the container volume.
        /// </summary>
        [JsonProperty("password")]
        public Models.Password1 Password { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InstanceVolumeSFTP : ({string.Join(", ", toStringOutput)})";
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
            return obj is InstanceVolumeSFTP other &&                ((this.Host == null && other.Host == null) || (this.Host?.Equals(other.Host) == true)) &&
                this.Port.Equals(other.Port) &&
                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.Password == null && other.Password == null) || (this.Password?.Equals(other.Password) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Host = {(this.Host == null ? "null" : this.Host)}");
            toStringOutput.Add($"this.Port = {this.Port}");
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username)}");
            toStringOutput.Add($"this.Password = {(this.Password == null ? "null" : this.Password.ToString())}");
        }
    }
}