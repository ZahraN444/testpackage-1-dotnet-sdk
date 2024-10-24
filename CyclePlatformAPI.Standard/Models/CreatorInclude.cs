// <copyright file="CreatorInclude.cs" company="APIMatic">
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
    /// CreatorInclude.
    /// </summary>
    public class CreatorInclude
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatorInclude"/> class.
        /// </summary>
        public CreatorInclude()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatorInclude"/> class.
        /// </summary>
        /// <param name="accounts">accounts.</param>
        /// <param name="employees">employees.</param>
        /// <param name="visitors">visitors.</param>
        /// <param name="environments">environments.</param>
        /// <param name="apiKeys">api_keys.</param>
        public CreatorInclude(
            Dictionary<string, Models.PublicAccount> accounts = null,
            Dictionary<string, Models.PublicAccount> employees = null,
            Dictionary<string, Models.PublicAccount> visitors = null,
            Dictionary<string, Models.Environment> environments = null,
            Dictionary<string, Models.ApiKeyCreator> apiKeys = null)
        {
            this.Accounts = accounts;
            this.Employees = employees;
            this.Visitors = visitors;
            this.Environments = environments;
            this.ApiKeys = apiKeys;
        }

        /// <summary>
        /// Included creators that are public accounts, keyed by ID.
        /// </summary>
        [JsonProperty("accounts", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.PublicAccount> Accounts { get; set; }

        /// <summary>
        /// Included creators that are employees of Cycle, keyed by ID.
        /// </summary>
        [JsonProperty("employees", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.PublicAccount> Employees { get; set; }

        /// <summary>
        /// Included creators that are not Cycle accounts, keyed by ID.
        /// </summary>
        [JsonProperty("visitors", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.PublicAccount> Visitors { get; set; }

        /// <summary>
        /// Included creators that are Cycle environments (usually automatically created resources), keyed by ID.
        /// </summary>
        [JsonProperty("environments", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.Environment> Environments { get; set; }

        /// <summary>
        /// Included creators that are Cycle API Keys, keyed by ID.
        /// </summary>
        [JsonProperty("api_keys", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.ApiKeyCreator> ApiKeys { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreatorInclude : ({string.Join(", ", toStringOutput)})";
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
            return obj is CreatorInclude other &&                ((this.Accounts == null && other.Accounts == null) || (this.Accounts?.Equals(other.Accounts) == true)) &&
                ((this.Employees == null && other.Employees == null) || (this.Employees?.Equals(other.Employees) == true)) &&
                ((this.Visitors == null && other.Visitors == null) || (this.Visitors?.Equals(other.Visitors) == true)) &&
                ((this.Environments == null && other.Environments == null) || (this.Environments?.Equals(other.Environments) == true)) &&
                ((this.ApiKeys == null && other.ApiKeys == null) || (this.ApiKeys?.Equals(other.ApiKeys) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Accounts = {(this.Accounts == null ? "null" : this.Accounts.ToString())}");
            toStringOutput.Add($"Employees = {(this.Employees == null ? "null" : this.Employees.ToString())}");
            toStringOutput.Add($"Visitors = {(this.Visitors == null ? "null" : this.Visitors.ToString())}");
            toStringOutput.Add($"Environments = {(this.Environments == null ? "null" : this.Environments.ToString())}");
            toStringOutput.Add($"ApiKeys = {(this.ApiKeys == null ? "null" : this.ApiKeys.ToString())}");
        }
    }
}