// <copyright file="LoadBalancerTelemetryControllerDisconnectsMetrics.cs" company="APIMatic">
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
    /// LoadBalancerTelemetryControllerDisconnectsMetrics.
    /// </summary>
    public class LoadBalancerTelemetryControllerDisconnectsMetrics
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerTelemetryControllerDisconnectsMetrics"/> class.
        /// </summary>
        public LoadBalancerTelemetryControllerDisconnectsMetrics()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadBalancerTelemetryControllerDisconnectsMetrics"/> class.
        /// </summary>
        /// <param name="noError">no_error.</param>
        /// <param name="requestInvalid">request_invalid.</param>
        /// <param name="timeoutIdle">timeout_idle.</param>
        /// <param name="routerNone">router_none.</param>
        /// <param name="routerNomatch">router_nomatch.</param>
        /// <param name="destinationUnavailable">destination_unavailable.</param>
        /// <param name="unknownError">unknown_error.</param>
        public LoadBalancerTelemetryControllerDisconnectsMetrics(
            int noError,
            int requestInvalid,
            int timeoutIdle,
            int routerNone,
            int routerNomatch,
            int destinationUnavailable,
            int unknownError)
        {
            this.NoError = noError;
            this.RequestInvalid = requestInvalid;
            this.TimeoutIdle = timeoutIdle;
            this.RouterNone = routerNone;
            this.RouterNomatch = routerNomatch;
            this.DestinationUnavailable = destinationUnavailable;
            this.UnknownError = unknownError;
        }

        /// <summary>
        /// Gets or sets NoError.
        /// </summary>
        [JsonProperty("no_error")]
        public int NoError { get; set; }

        /// <summary>
        /// Gets or sets RequestInvalid.
        /// </summary>
        [JsonProperty("request_invalid")]
        public int RequestInvalid { get; set; }

        /// <summary>
        /// Gets or sets TimeoutIdle.
        /// </summary>
        [JsonProperty("timeout_idle")]
        public int TimeoutIdle { get; set; }

        /// <summary>
        /// Gets or sets RouterNone.
        /// </summary>
        [JsonProperty("router_none")]
        public int RouterNone { get; set; }

        /// <summary>
        /// Gets or sets RouterNomatch.
        /// </summary>
        [JsonProperty("router_nomatch")]
        public int RouterNomatch { get; set; }

        /// <summary>
        /// Gets or sets DestinationUnavailable.
        /// </summary>
        [JsonProperty("destination_unavailable")]
        public int DestinationUnavailable { get; set; }

        /// <summary>
        /// Gets or sets UnknownError.
        /// </summary>
        [JsonProperty("unknown_error")]
        public int UnknownError { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LoadBalancerTelemetryControllerDisconnectsMetrics : ({string.Join(", ", toStringOutput)})";
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
            return obj is LoadBalancerTelemetryControllerDisconnectsMetrics other &&                this.NoError.Equals(other.NoError) &&
                this.RequestInvalid.Equals(other.RequestInvalid) &&
                this.TimeoutIdle.Equals(other.TimeoutIdle) &&
                this.RouterNone.Equals(other.RouterNone) &&
                this.RouterNomatch.Equals(other.RouterNomatch) &&
                this.DestinationUnavailable.Equals(other.DestinationUnavailable) &&
                this.UnknownError.Equals(other.UnknownError);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.NoError = {this.NoError}");
            toStringOutput.Add($"this.RequestInvalid = {this.RequestInvalid}");
            toStringOutput.Add($"this.TimeoutIdle = {this.TimeoutIdle}");
            toStringOutput.Add($"this.RouterNone = {this.RouterNone}");
            toStringOutput.Add($"this.RouterNomatch = {this.RouterNomatch}");
            toStringOutput.Add($"this.DestinationUnavailable = {this.DestinationUnavailable}");
            toStringOutput.Add($"this.UnknownError = {this.UnknownError}");
        }
    }
}