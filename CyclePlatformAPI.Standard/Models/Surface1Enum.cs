// <copyright file="Surface1Enum.cs" company="APIMatic">
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
    /// Surface1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Surface1Enum
    {
        /// <summary>
        /// Network.
        /// </summary>
        [EnumMember(Value = "network")]
        Network,

        /// <summary>
        /// Service.
        /// </summary>
        [EnumMember(Value = "service")]
        Service,

        /// <summary>
        /// Fs.
        /// </summary>
        [EnumMember(Value = "fs")]
        Fs,

        /// <summary>
        /// Api.
        /// </summary>
        [EnumMember(Value = "api")]
        Api
    }
}