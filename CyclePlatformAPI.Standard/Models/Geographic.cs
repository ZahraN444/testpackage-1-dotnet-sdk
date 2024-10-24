// <copyright file="Geographic.cs" company="APIMatic">
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
    /// Geographic.
    /// </summary>
    public class Geographic
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Geographic"/> class.
        /// </summary>
        public Geographic()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Geographic"/> class.
        /// </summary>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="country">country.</param>
        /// <param name="region">region.</param>
        public Geographic(
            int? latitude = null,
            int? longitude = null,
            string city = null,
            string state = null,
            string country = null,
            string region = null)
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
        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public int? Latitude { get; set; }

        /// <summary>
        /// The longitude of the given provider datacenter.
        /// </summary>
        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public int? Longitude { get; set; }

        /// <summary>
        /// The city the datacenter resides in.
        /// </summary>
        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string City { get; set; }

        /// <summary>
        /// The state the datacenter resides in.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// The country the datacenter resides in.
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// The region the datacenter resides in.
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Geographic : ({string.Join(", ", toStringOutput)})";
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
            return obj is Geographic other &&                ((this.Latitude == null && other.Latitude == null) || (this.Latitude?.Equals(other.Latitude) == true)) &&
                ((this.Longitude == null && other.Longitude == null) || (this.Longitude?.Equals(other.Longitude) == true)) &&
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
            toStringOutput.Add($"this.Latitude = {(this.Latitude == null ? "null" : this.Latitude.ToString())}");
            toStringOutput.Add($"this.Longitude = {(this.Longitude == null ? "null" : this.Longitude.ToString())}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.Region = {(this.Region == null ? "null" : this.Region)}");
        }
    }
}