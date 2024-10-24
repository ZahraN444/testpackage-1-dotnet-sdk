// <copyright file="Attack2.cs" company="APIMatic">
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
    /// Attack2.
    /// </summary>
    public class Attack2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attack2"/> class.
        /// </summary>
        public Attack2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Attack2"/> class.
        /// </summary>
        /// <param name="none">none.</param>
        /// <param name="authFailure">auth-failure.</param>
        /// <param name="bruteForce">brute-force.</param>
        /// <param name="exploitVulnerability">exploit-vulnerability.</param>
        /// <param name="socialEngineer">social-engineer.</param>
        /// <param name="serviceInterruption">service-interruption.</param>
        /// <param name="accessElevation">access-elevation.</param>
        public Attack2(
            int? none = null,
            int? authFailure = null,
            int? bruteForce = null,
            int? exploitVulnerability = null,
            int? socialEngineer = null,
            int? serviceInterruption = null,
            int? accessElevation = null)
        {
            this.None = none;
            this.AuthFailure = authFailure;
            this.BruteForce = bruteForce;
            this.ExploitVulnerability = exploitVulnerability;
            this.SocialEngineer = socialEngineer;
            this.ServiceInterruption = serviceInterruption;
            this.AccessElevation = accessElevation;
        }

        /// <summary>
        /// Gets or sets None.
        /// </summary>
        [JsonProperty("none", NullValueHandling = NullValueHandling.Ignore)]
        public int? None { get; set; }

        /// <summary>
        /// Gets or sets AuthFailure.
        /// </summary>
        [JsonProperty("auth-failure", NullValueHandling = NullValueHandling.Ignore)]
        public int? AuthFailure { get; set; }

        /// <summary>
        /// Gets or sets BruteForce.
        /// </summary>
        [JsonProperty("brute-force", NullValueHandling = NullValueHandling.Ignore)]
        public int? BruteForce { get; set; }

        /// <summary>
        /// Gets or sets ExploitVulnerability.
        /// </summary>
        [JsonProperty("exploit-vulnerability", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExploitVulnerability { get; set; }

        /// <summary>
        /// Gets or sets SocialEngineer.
        /// </summary>
        [JsonProperty("social-engineer", NullValueHandling = NullValueHandling.Ignore)]
        public int? SocialEngineer { get; set; }

        /// <summary>
        /// Gets or sets ServiceInterruption.
        /// </summary>
        [JsonProperty("service-interruption", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceInterruption { get; set; }

        /// <summary>
        /// Gets or sets AccessElevation.
        /// </summary>
        [JsonProperty("access-elevation", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessElevation { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Attack2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is Attack2 other &&                ((this.None == null && other.None == null) || (this.None?.Equals(other.None) == true)) &&
                ((this.AuthFailure == null && other.AuthFailure == null) || (this.AuthFailure?.Equals(other.AuthFailure) == true)) &&
                ((this.BruteForce == null && other.BruteForce == null) || (this.BruteForce?.Equals(other.BruteForce) == true)) &&
                ((this.ExploitVulnerability == null && other.ExploitVulnerability == null) || (this.ExploitVulnerability?.Equals(other.ExploitVulnerability) == true)) &&
                ((this.SocialEngineer == null && other.SocialEngineer == null) || (this.SocialEngineer?.Equals(other.SocialEngineer) == true)) &&
                ((this.ServiceInterruption == null && other.ServiceInterruption == null) || (this.ServiceInterruption?.Equals(other.ServiceInterruption) == true)) &&
                ((this.AccessElevation == null && other.AccessElevation == null) || (this.AccessElevation?.Equals(other.AccessElevation) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.None = {(this.None == null ? "null" : this.None.ToString())}");
            toStringOutput.Add($"this.AuthFailure = {(this.AuthFailure == null ? "null" : this.AuthFailure.ToString())}");
            toStringOutput.Add($"this.BruteForce = {(this.BruteForce == null ? "null" : this.BruteForce.ToString())}");
            toStringOutput.Add($"this.ExploitVulnerability = {(this.ExploitVulnerability == null ? "null" : this.ExploitVulnerability.ToString())}");
            toStringOutput.Add($"this.SocialEngineer = {(this.SocialEngineer == null ? "null" : this.SocialEngineer.ToString())}");
            toStringOutput.Add($"this.ServiceInterruption = {(this.ServiceInterruption == null ? "null" : this.ServiceInterruption.ToString())}");
            toStringOutput.Add($"this.AccessElevation = {(this.AccessElevation == null ? "null" : this.AccessElevation.ToString())}");
        }
    }
}