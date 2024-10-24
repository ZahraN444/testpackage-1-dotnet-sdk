// <copyright file="ServerStatsCpuUsage.cs" company="APIMatic">
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
    /// ServerStatsCpuUsage.
    /// </summary>
    public class ServerStatsCpuUsage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsCpuUsage"/> class.
        /// </summary>
        public ServerStatsCpuUsage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerStatsCpuUsage"/> class.
        /// </summary>
        /// <param name="user">user.</param>
        /// <param name="nice">nice.</param>
        /// <param name="mSystem">system.</param>
        /// <param name="idle">idle.</param>
        /// <param name="iowait">iowait.</param>
        /// <param name="irq">irq.</param>
        /// <param name="softIrq">soft_irq.</param>
        /// <param name="steal">steal.</param>
        /// <param name="guest">guest.</param>
        /// <param name="guestNice">guest_nice.</param>
        public ServerStatsCpuUsage(
            int? user = null,
            int? nice = null,
            int? mSystem = null,
            int? idle = null,
            int? iowait = null,
            int? irq = null,
            int? softIrq = null,
            int? steal = null,
            int? guest = null,
            int? guestNice = null)
        {
            this.User = user;
            this.Nice = nice;
            this.MSystem = mSystem;
            this.Idle = idle;
            this.Iowait = iowait;
            this.Irq = irq;
            this.SoftIrq = softIrq;
            this.Steal = steal;
            this.Guest = guest;
            this.GuestNice = guestNice;
        }

        /// <summary>
        /// Gets or sets User.
        /// </summary>
        [JsonProperty("user", NullValueHandling = NullValueHandling.Ignore)]
        public int? User { get; set; }

        /// <summary>
        /// Gets or sets Nice.
        /// </summary>
        [JsonProperty("nice", NullValueHandling = NullValueHandling.Ignore)]
        public int? Nice { get; set; }

        /// <summary>
        /// Gets or sets MSystem.
        /// </summary>
        [JsonProperty("system", NullValueHandling = NullValueHandling.Ignore)]
        public int? MSystem { get; set; }

        /// <summary>
        /// Gets or sets Idle.
        /// </summary>
        [JsonProperty("idle", NullValueHandling = NullValueHandling.Ignore)]
        public int? Idle { get; set; }

        /// <summary>
        /// Gets or sets Iowait.
        /// </summary>
        [JsonProperty("iowait", NullValueHandling = NullValueHandling.Ignore)]
        public int? Iowait { get; set; }

        /// <summary>
        /// Gets or sets Irq.
        /// </summary>
        [JsonProperty("irq", NullValueHandling = NullValueHandling.Ignore)]
        public int? Irq { get; set; }

        /// <summary>
        /// Gets or sets SoftIrq.
        /// </summary>
        [JsonProperty("soft_irq", NullValueHandling = NullValueHandling.Ignore)]
        public int? SoftIrq { get; set; }

        /// <summary>
        /// Gets or sets Steal.
        /// </summary>
        [JsonProperty("steal", NullValueHandling = NullValueHandling.Ignore)]
        public int? Steal { get; set; }

        /// <summary>
        /// Gets or sets Guest.
        /// </summary>
        [JsonProperty("guest", NullValueHandling = NullValueHandling.Ignore)]
        public int? Guest { get; set; }

        /// <summary>
        /// Gets or sets GuestNice.
        /// </summary>
        [JsonProperty("guest_nice", NullValueHandling = NullValueHandling.Ignore)]
        public int? GuestNice { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ServerStatsCpuUsage : ({string.Join(", ", toStringOutput)})";
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
            return obj is ServerStatsCpuUsage other &&                ((this.User == null && other.User == null) || (this.User?.Equals(other.User) == true)) &&
                ((this.Nice == null && other.Nice == null) || (this.Nice?.Equals(other.Nice) == true)) &&
                ((this.MSystem == null && other.MSystem == null) || (this.MSystem?.Equals(other.MSystem) == true)) &&
                ((this.Idle == null && other.Idle == null) || (this.Idle?.Equals(other.Idle) == true)) &&
                ((this.Iowait == null && other.Iowait == null) || (this.Iowait?.Equals(other.Iowait) == true)) &&
                ((this.Irq == null && other.Irq == null) || (this.Irq?.Equals(other.Irq) == true)) &&
                ((this.SoftIrq == null && other.SoftIrq == null) || (this.SoftIrq?.Equals(other.SoftIrq) == true)) &&
                ((this.Steal == null && other.Steal == null) || (this.Steal?.Equals(other.Steal) == true)) &&
                ((this.Guest == null && other.Guest == null) || (this.Guest?.Equals(other.Guest) == true)) &&
                ((this.GuestNice == null && other.GuestNice == null) || (this.GuestNice?.Equals(other.GuestNice) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.User = {(this.User == null ? "null" : this.User.ToString())}");
            toStringOutput.Add($"this.Nice = {(this.Nice == null ? "null" : this.Nice.ToString())}");
            toStringOutput.Add($"this.MSystem = {(this.MSystem == null ? "null" : this.MSystem.ToString())}");
            toStringOutput.Add($"this.Idle = {(this.Idle == null ? "null" : this.Idle.ToString())}");
            toStringOutput.Add($"this.Iowait = {(this.Iowait == null ? "null" : this.Iowait.ToString())}");
            toStringOutput.Add($"this.Irq = {(this.Irq == null ? "null" : this.Irq.ToString())}");
            toStringOutput.Add($"this.SoftIrq = {(this.SoftIrq == null ? "null" : this.SoftIrq.ToString())}");
            toStringOutput.Add($"this.Steal = {(this.Steal == null ? "null" : this.Steal.ToString())}");
            toStringOutput.Add($"this.Guest = {(this.Guest == null ? "null" : this.Guest.ToString())}");
            toStringOutput.Add($"this.GuestNice = {(this.GuestNice == null ? "null" : this.GuestNice.ToString())}");
        }
    }
}