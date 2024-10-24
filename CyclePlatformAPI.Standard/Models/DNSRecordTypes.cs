// <copyright file="DNSRecordTypes.cs" company="APIMatic">
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
    /// DNSRecordTypes.
    /// </summary>
    public class DNSRecordTypes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DNSRecordTypes"/> class.
        /// </summary>
        public DNSRecordTypes()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DNSRecordTypes"/> class.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="aaaa">aaaa.</param>
        /// <param name="cname">cname.</param>
        /// <param name="ns">ns.</param>
        /// <param name="mx">mx.</param>
        /// <param name="txt">txt.</param>
        /// <param name="mAlias">alias.</param>
        /// <param name="srv">srv.</param>
        /// <param name="caa">caa.</param>
        /// <param name="linked">linked.</param>
        public DNSRecordTypes(
            Models.A a = null,
            Models.Aaaa aaaa = null,
            Models.Cname cname = null,
            Models.Ns ns = null,
            Models.Mx mx = null,
            Models.Txt txt = null,
            Models.Alias mAlias = null,
            Models.Srv srv = null,
            Models.Caa caa = null,
            Models.Linked linked = null)
        {
            this.A = a;
            this.Aaaa = aaaa;
            this.Cname = cname;
            this.Ns = ns;
            this.Mx = mx;
            this.Txt = txt;
            this.MAlias = mAlias;
            this.Srv = srv;
            this.Caa = caa;
            this.Linked = linked;
        }

        /// <summary>
        /// A DNS A record
        /// </summary>
        [JsonProperty("a", NullValueHandling = NullValueHandling.Ignore)]
        public Models.A A { get; set; }

        /// <summary>
        /// A DNS AAAA record
        /// </summary>
        [JsonProperty("aaaa", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Aaaa Aaaa { get; set; }

        /// <summary>
        /// A DNS CNAME record
        /// </summary>
        [JsonProperty("cname", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Cname Cname { get; set; }

        /// <summary>
        /// A DNS NS record
        /// </summary>
        [JsonProperty("ns", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Ns Ns { get; set; }

        /// <summary>
        /// A DNS MX record
        /// </summary>
        [JsonProperty("mx", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Mx Mx { get; set; }

        /// <summary>
        /// A DNS TXT record.
        /// </summary>
        [JsonProperty("txt", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Txt Txt { get; set; }

        /// <summary>
        /// A DNS ALIAS record.
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Alias MAlias { get; set; }

        /// <summary>
        /// A DNS SRV record.
        /// </summary>
        [JsonProperty("srv", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Srv Srv { get; set; }

        /// <summary>
        /// A DNS CAA record.
        /// </summary>
        [JsonProperty("caa", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Caa Caa { get; set; }

        /// <summary>
        /// A LINKED record is a record special to Cycle.  It represents a URL that points to a specific container or deployment of a container, however the IP address mapping in handled automatically by the platform.
        /// </summary>
        [JsonProperty("linked", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Linked Linked { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DNSRecordTypes : ({string.Join(", ", toStringOutput)})";
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
            return obj is DNSRecordTypes other &&                ((this.A == null && other.A == null) || (this.A?.Equals(other.A) == true)) &&
                ((this.Aaaa == null && other.Aaaa == null) || (this.Aaaa?.Equals(other.Aaaa) == true)) &&
                ((this.Cname == null && other.Cname == null) || (this.Cname?.Equals(other.Cname) == true)) &&
                ((this.Ns == null && other.Ns == null) || (this.Ns?.Equals(other.Ns) == true)) &&
                ((this.Mx == null && other.Mx == null) || (this.Mx?.Equals(other.Mx) == true)) &&
                ((this.Txt == null && other.Txt == null) || (this.Txt?.Equals(other.Txt) == true)) &&
                ((this.MAlias == null && other.MAlias == null) || (this.MAlias?.Equals(other.MAlias) == true)) &&
                ((this.Srv == null && other.Srv == null) || (this.Srv?.Equals(other.Srv) == true)) &&
                ((this.Caa == null && other.Caa == null) || (this.Caa?.Equals(other.Caa) == true)) &&
                ((this.Linked == null && other.Linked == null) || (this.Linked?.Equals(other.Linked) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.A = {(this.A == null ? "null" : this.A.ToString())}");
            toStringOutput.Add($"this.Aaaa = {(this.Aaaa == null ? "null" : this.Aaaa.ToString())}");
            toStringOutput.Add($"this.Cname = {(this.Cname == null ? "null" : this.Cname.ToString())}");
            toStringOutput.Add($"this.Ns = {(this.Ns == null ? "null" : this.Ns.ToString())}");
            toStringOutput.Add($"this.Mx = {(this.Mx == null ? "null" : this.Mx.ToString())}");
            toStringOutput.Add($"this.Txt = {(this.Txt == null ? "null" : this.Txt.ToString())}");
            toStringOutput.Add($"this.MAlias = {(this.MAlias == null ? "null" : this.MAlias.ToString())}");
            toStringOutput.Add($"this.Srv = {(this.Srv == null ? "null" : this.Srv.ToString())}");
            toStringOutput.Add($"this.Caa = {(this.Caa == null ? "null" : this.Caa.ToString())}");
            toStringOutput.Add($"this.Linked = {(this.Linked == null ? "null" : this.Linked.ToString())}");
        }
    }
}