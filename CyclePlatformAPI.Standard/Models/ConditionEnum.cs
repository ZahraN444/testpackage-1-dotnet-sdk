// <copyright file="ConditionEnum.cs" company="APIMatic">
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
    /// ConditionEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConditionEnum
    {
        /// <summary>
        /// Always.
        /// </summary>
        [EnumMember(Value = "always")]
        Always,

        /// <summary>
        /// Never.
        /// </summary>
        [EnumMember(Value = "never")]
        Never,

        /// <summary>
        /// Failure.
        /// </summary>
        [EnumMember(Value = "failure")]
        Failure
    }
}