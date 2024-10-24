// <copyright file="ProviderLocationGeography.cs" company="APIMatic">
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
    /// ProviderLocationGeography.
    /// </summary>
    public class ProviderLocationGeography
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderLocationGeography"/> class.
        /// </summary>
        public ProviderLocationGeography()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderLocationGeography"/> class.
        /// </summary>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="country">country.</param>
        /// <param name="region">region.</param>
        public ProviderLocationGeography(
            int latitude,
            int longitude,
            string city,
            string state,
            string country,
            string region)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.Region = region;
        }

        /// <summary>
        /// The latitude of the given provider datacenter.
        /// </summary>
        [JsonProperty("latitude")]
        [JsonRequired]
        public int Latitude { get; set; }

        /// <summary>
        /// The longitude of the given provider datacenter.
        /// </summary>
        [JsonProperty("longitude")]
        [JsonRequired]
        public int Longitude { get; set; }

        /// <summary>
        /// The city the datacenter resides in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("city")]
        [JsonRequired]
        public string City { get; set; }

        /// <summary>
        /// The state the datacenter resides in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("state")]
        [JsonRequired]
        public string State { get; set; }

        /// <summary>
        /// The country the datacenter resides in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("country")]
        [JsonRequired]
        public string Country { get; set; }

        /// <summary>
        /// The region the datacenter resides in.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("region")]
        [JsonRequired]
        public string Region { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProviderLocationGeography : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProviderLocationGeography other &&                this.Latitude.Equals(other.Latitude) &&
                this.Longitude.Equals(other.Longitude) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.Region == null && other.Region == null) || (this.Region?.Equals(other.Region) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Latitude = {this.Latitude}");
            toStringOutput.Add($"this.Longitude = {this.Longitude}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.Region = {(this.Region == null ? "null" : this.Region)}");
        }
    }
}