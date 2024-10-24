// <copyright file="Credentials1.cs" company="APIMatic">
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
    /// Credentials1.
    /// </summary>
    public class Credentials1
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Credentials1"/> class.
        /// </summary>
        public Credentials1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Credentials1"/> class.
        /// </summary>
        /// <param name="username">username.</param>
        /// <param name="passphrase">passphrase.</param>
        /// <param name="privateKey">private_key.</param>
        public Credentials1(
            string username,
            string passphrase,
            string privateKey)
        {
            this.Username = username;
            this.Passphrase = passphrase;
            this.PrivateKey = privateKey;
        }

        /// <summary>
        /// The username for the repo service, that is used to authenticate an ssh key.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// The passphrase used for the key.
        /// </summary>
        [JsonProperty("passphrase")]
        public string Passphrase { get; set; }

        /// <summary>
        /// A pem encoded private key.
        /// </summary>
        [JsonProperty("private_key")]
        public string PrivateKey { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Credentials1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Credentials1 other &&                ((this.Username == null && other.Username == null) || (this.Username?.Equals(other.Username) == true)) &&
                ((this.Passphrase == null && other.Passphrase == null) || (this.Passphrase?.Equals(other.Passphrase) == true)) &&
                ((this.PrivateKey == null && other.PrivateKey == null) || (this.PrivateKey?.Equals(other.PrivateKey) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Username = {(this.Username == null ? "null" : this.Username)}");
            toStringOutput.Add($"this.Passphrase = {(this.Passphrase == null ? "null" : this.Passphrase)}");
            toStringOutput.Add($"this.PrivateKey = {(this.PrivateKey == null ? "null" : this.PrivateKey)}");
        }
    }
}