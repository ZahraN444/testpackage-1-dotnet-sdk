// <copyright file="Notificaitons.cs" company="APIMatic">
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
    /// Notificaitons.
    /// </summary>
    public class Notificaitons
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notificaitons"/> class.
        /// </summary>
        public Notificaitons()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notificaitons"/> class.
        /// </summary>
        /// <param name="server">server.</param>
        public Notificaitons(
            Models.Server2 server)
        {
            this.Server = server;
        }

        /// <summary>
        /// Gets or sets Server.
        /// </summary>
        [JsonProperty("server")]
        public Models.Server2 Server { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Notificaitons : ({string.Join(", ", toStringOutput)})";
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
            return obj is Notificaitons other &&                ((this.Server == null && other.Server == null) || (this.Server?.Equals(other.Server) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Server = {(this.Server == null ? "null" : this.Server.ToString())}");
        }
    }
}