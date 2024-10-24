// <copyright file="Syscall.cs" company="APIMatic">
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
    /// Syscall.
    /// </summary>
    public class Syscall
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Syscall"/> class.
        /// </summary>
        public Syscall()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Syscall"/> class.
        /// </summary>
        /// <param name="names">names.</param>
        /// <param name="action">action.</param>
        /// <param name="errnoRet">errnoRet.</param>
        /// <param name="args">args.</param>
        public Syscall(
            List<string> names,
            Models.ActionEnum action,
            int? errnoRet = null,
            List<Models.Arg> args = null)
        {
            this.Names = names;
            this.Action = action;
            this.ErrnoRet = errnoRet;
            this.Args = args;
        }

        /// <summary>
        /// Gets or sets Names.
        /// </summary>
        [JsonProperty("names")]
        public List<string> Names { get; set; }

        /// <summary>
        /// Gets or sets Action.
        /// </summary>
        [JsonProperty("action")]
        public Models.ActionEnum Action { get; set; }

        /// <summary>
        /// Gets or sets ErrnoRet.
        /// </summary>
        [JsonProperty("errnoRet", NullValueHandling = NullValueHandling.Ignore)]
        public int? ErrnoRet { get; set; }

        /// <summary>
        /// Gets or sets Args.
        /// </summary>
        [JsonProperty("args", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Arg> Args { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Syscall : ({string.Join(", ", toStringOutput)})";
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
            return obj is Syscall other &&                ((this.Names == null && other.Names == null) || (this.Names?.Equals(other.Names) == true)) &&
                this.Action.Equals(other.Action) &&
                ((this.ErrnoRet == null && other.ErrnoRet == null) || (this.ErrnoRet?.Equals(other.ErrnoRet) == true)) &&
                ((this.Args == null && other.Args == null) || (this.Args?.Equals(other.Args) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Names = {(this.Names == null ? "null" : $"[{string.Join(", ", this.Names)} ]")}");
            toStringOutput.Add($"this.Action = {this.Action}");
            toStringOutput.Add($"this.ErrnoRet = {(this.ErrnoRet == null ? "null" : this.ErrnoRet.ToString())}");
            toStringOutput.Add($"this.Args = {(this.Args == null ? "null" : $"[{string.Join(", ", this.Args)} ]")}");
        }
    }
}