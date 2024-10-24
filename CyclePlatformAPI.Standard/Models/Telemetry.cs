// <copyright file="Telemetry.cs" company="APIMatic">
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
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// Telemetry.
    /// </summary>
    public class Telemetry
    {
        private int? maxTrackableUrls;
        private bool? trackInvalidRequests;
        private Dictionary<string, string> groupPaths;
        private List<string> ignorePaths;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "max_trackable_urls", false },
            { "track_invalid_requests", false },
            { "group_paths", false },
            { "ignore_paths", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Telemetry"/> class.
        /// </summary>
        public Telemetry()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Telemetry"/> class.
        /// </summary>
        /// <param name="disableUrlTracking">disable_url_tracking.</param>
        /// <param name="disableRouterMetrics">disable_router_metrics.</param>
        /// <param name="maxTrackableUrls">max_trackable_urls.</param>
        /// <param name="trackingWindow">tracking_window.</param>
        /// <param name="trackInvalidRequests">track_invalid_requests.</param>
        /// <param name="groupPaths">group_paths.</param>
        /// <param name="ignorePaths">ignore_paths.</param>
        public Telemetry(
            bool disableUrlTracking,
            bool disableRouterMetrics,
            int? maxTrackableUrls = null,
            TelemetryTrackingWindow trackingWindow = null,
            bool? trackInvalidRequests = null,
            Dictionary<string, string> groupPaths = null,
            List<string> ignorePaths = null)
        {
            this.DisableUrlTracking = disableUrlTracking;
            this.DisableRouterMetrics = disableRouterMetrics;
            if (maxTrackableUrls != null)
            {
                this.MaxTrackableUrls = maxTrackableUrls;
            }

            this.TrackingWindow = trackingWindow;
            if (trackInvalidRequests != null)
            {
                this.TrackInvalidRequests = trackInvalidRequests;
            }

            if (groupPaths != null)
            {
                this.GroupPaths = groupPaths;
            }

            if (ignorePaths != null)
            {
                this.IgnorePaths = ignorePaths;
            }

        }

        /// <summary>
        /// Determines if the load balancer will track url metrics. Defaults to false.
        /// </summary>
        [JsonProperty("disable_url_tracking")]
        public bool DisableUrlTracking { get; set; }

        /// <summary>
        /// Determines if the load balancer will track router metrics. Defaults to false.
        /// </summary>
        [JsonProperty("disable_router_metrics")]
        public bool DisableRouterMetrics { get; set; }

        /// <summary>
        /// Determines how many URLs the load balancer will track at one time. Defaults to 150.
        /// </summary>
        [JsonProperty("max_trackable_urls")]
        public int? MaxTrackableUrls
        {
            get
            {
                return this.maxTrackableUrls;
            }

            set
            {
                this.shouldSerialize["max_trackable_urls"] = true;
                this.maxTrackableUrls = value;
            }
        }

        /// <summary>
        /// Determines how long the load balancer will track a URL from its last hit. Helps reduce noise by not tracking URLs that are occasionally hit. Defaults to 8h.
        /// </summary>
        [JsonProperty("tracking_window", NullValueHandling = NullValueHandling.Ignore)]
        public TelemetryTrackingWindow TrackingWindow { get; set; }

        /// <summary>
        /// Whether or not to track invalid requests. An invalid request is a request that came in that no router existed for. Usually this means bot requests. Defaults to false.
        /// </summary>
        [JsonProperty("track_invalid_requests")]
        public bool? TrackInvalidRequests
        {
            get
            {
                return this.trackInvalidRequests;
            }

            set
            {
                this.shouldSerialize["track_invalid_requests"] = true;
                this.trackInvalidRequests = value;
            }
        }

        /// <summary>
        /// Group paths is used to group URLs.  The key is the URL and the value is the regex used to match URLs.
        /// </summary>
        [JsonProperty("group_paths")]
        public Dictionary<string, string> GroupPaths
        {
            get
            {
                return this.groupPaths;
            }

            set
            {
                this.shouldSerialize["group_paths"] = true;
                this.groupPaths = value;
            }
        }

        /// <summary>
        /// An array of paths to exclude from tracking.
        /// </summary>
        [JsonProperty("ignore_paths")]
        public List<string> IgnorePaths
        {
            get
            {
                return this.ignorePaths;
            }

            set
            {
                this.shouldSerialize["ignore_paths"] = true;
                this.ignorePaths = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Telemetry : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMaxTrackableUrls()
        {
            this.shouldSerialize["max_trackable_urls"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTrackInvalidRequests()
        {
            this.shouldSerialize["track_invalid_requests"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetGroupPaths()
        {
            this.shouldSerialize["group_paths"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIgnorePaths()
        {
            this.shouldSerialize["ignore_paths"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMaxTrackableUrls()
        {
            return this.shouldSerialize["max_trackable_urls"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTrackInvalidRequests()
        {
            return this.shouldSerialize["track_invalid_requests"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGroupPaths()
        {
            return this.shouldSerialize["group_paths"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIgnorePaths()
        {
            return this.shouldSerialize["ignore_paths"];
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
            return obj is Telemetry other &&                this.DisableUrlTracking.Equals(other.DisableUrlTracking) &&
                this.DisableRouterMetrics.Equals(other.DisableRouterMetrics) &&
                ((this.MaxTrackableUrls == null && other.MaxTrackableUrls == null) || (this.MaxTrackableUrls?.Equals(other.MaxTrackableUrls) == true)) &&
                ((this.TrackingWindow == null && other.TrackingWindow == null) || (this.TrackingWindow?.Equals(other.TrackingWindow) == true)) &&
                ((this.TrackInvalidRequests == null && other.TrackInvalidRequests == null) || (this.TrackInvalidRequests?.Equals(other.TrackInvalidRequests) == true)) &&
                ((this.GroupPaths == null && other.GroupPaths == null) || (this.GroupPaths?.Equals(other.GroupPaths) == true)) &&
                ((this.IgnorePaths == null && other.IgnorePaths == null) || (this.IgnorePaths?.Equals(other.IgnorePaths) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DisableUrlTracking = {this.DisableUrlTracking}");
            toStringOutput.Add($"this.DisableRouterMetrics = {this.DisableRouterMetrics}");
            toStringOutput.Add($"this.MaxTrackableUrls = {(this.MaxTrackableUrls == null ? "null" : this.MaxTrackableUrls.ToString())}");
            toStringOutput.Add($"TrackingWindow = {(this.TrackingWindow == null ? "null" : this.TrackingWindow.ToString())}");
            toStringOutput.Add($"this.TrackInvalidRequests = {(this.TrackInvalidRequests == null ? "null" : this.TrackInvalidRequests.ToString())}");
            toStringOutput.Add($"GroupPaths = {(this.GroupPaths == null ? "null" : this.GroupPaths.ToString())}");
            toStringOutput.Add($"this.IgnorePaths = {(this.IgnorePaths == null ? "null" : $"[{string.Join(", ", this.IgnorePaths)} ]")}");
        }
    }
}