// <copyright file="SignalEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using CyclePlatformAPI.Standard;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json;

namespace CyclePlatformAPI.Standard.Models
{
    /// <summary>
    /// SignalEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SignalEnum
    {
        /// <summary>
        /// SIGTERM.
        /// </summary>
        [EnumMember(Value = "SIGTERM")]
        SIGTERM,

        /// <summary>
        /// SIGINT.
        /// </summary>
        [EnumMember(Value = "SIGINT")]
        SIGINT,

        /// <summary>
        /// SIGUSR1.
        /// </summary>
        [EnumMember(Value = "SIGUSR1")]
        SIGUSR1,

        /// <summary>
        /// SIGUSR2.
        /// </summary>
        [EnumMember(Value = "SIGUSR2")]
        SIGUSR2,

        /// <summary>
        /// SIGHUP.
        /// </summary>
        [EnumMember(Value = "SIGHUP")]
        SIGHUP,

        /// <summary>
        /// SIGQUIT.
        /// </summary>
        [EnumMember(Value = "SIGQUIT")]
        SIGQUIT
    }
}