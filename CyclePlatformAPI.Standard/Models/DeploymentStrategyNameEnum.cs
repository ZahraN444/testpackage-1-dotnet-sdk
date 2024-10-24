// <copyright file="DeploymentStrategyNameEnum.cs" company="APIMatic">
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
    /// DeploymentStrategyNameEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeploymentStrategyNameEnum
    {
        /// <summary>
        /// Resourcedensity.
        /// </summary>
        [EnumMember(Value = "resource-density")]
        Resourcedensity,

        /// <summary>
        /// Highavailability.
        /// </summary>
        [EnumMember(Value = "high-availability")]
        Highavailability,

        /// <summary>
        /// Firstavailable.
        /// </summary>
        [EnumMember(Value = "first-available")]
        Firstavailable,

        /// <summary>
        /// Node.
        /// </summary>
        [EnumMember(Value = "node")]
        Node,

        /// <summary>
        /// Edge.
        /// </summary>
        [EnumMember(Value = "edge")]
        Edge,

        /// <summary>
        /// Manual.
        /// </summary>
        [EnumMember(Value = "manual")]
        Manual,

        /// <summary>
        /// Function.
        /// </summary>
        [EnumMember(Value = "function")]
        Function
    }
}