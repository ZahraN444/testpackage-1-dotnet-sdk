// <copyright file="BillingBuilds.cs" company="APIMatic">
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
    /// BillingBuilds.
    /// </summary>
    public class BillingBuilds
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingBuilds"/> class.
        /// </summary>
        public BillingBuilds()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingBuilds"/> class.
        /// </summary>
        /// <param name="parallel">parallel.</param>
        /// <param name="cpuCores">cpu_cores.</param>
        /// <param name="ramGb">ram_gb.</param>
        /// <param name="maxDailyBuilds">max_daily_builds.</param>
        public BillingBuilds(
            double parallel,
            double cpuCores,
            double ramGb,
            int? maxDailyBuilds = null)
        {
            this.Parallel = parallel;
            this.CpuCores = cpuCores;
            this.RamGb = ramGb;
            this.MaxDailyBuilds = maxDailyBuilds;
        }

        /// <summary>
        /// Gets or sets Parallel.
        /// </summary>
        [JsonProperty("parallel")]
        public double Parallel { get; set; }

        /// <summary>
        /// The number of CPU Cores availiable for builds
        /// </summary>
        [JsonProperty("cpu_cores")]
        public double CpuCores { get; set; }

        /// <summary>
        /// The amount of RAM availiable for builds
        /// </summary>
        [JsonProperty("ram_gb")]
        public double RamGb { get; set; }

        /// <summary>
        /// The maximum number of builds processed per day
        /// </summary>
        [JsonProperty("max_daily_builds", NullValueHandling = NullValueHandling.Include)]
        public int? MaxDailyBuilds { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BillingBuilds : ({string.Join(", ", toStringOutput)})";
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
            return obj is BillingBuilds other &&                this.Parallel.Equals(other.Parallel) &&
                this.CpuCores.Equals(other.CpuCores) &&
                this.RamGb.Equals(other.RamGb) &&
                ((this.MaxDailyBuilds == null && other.MaxDailyBuilds == null) || (this.MaxDailyBuilds?.Equals(other.MaxDailyBuilds) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Parallel = {this.Parallel}");
            toStringOutput.Add($"this.CpuCores = {this.CpuCores}");
            toStringOutput.Add($"this.RamGb = {this.RamGb}");
            toStringOutput.Add($"this.MaxDailyBuilds = {(this.MaxDailyBuilds == null ? "null" : this.MaxDailyBuilds.ToString())}");
        }
    }
}