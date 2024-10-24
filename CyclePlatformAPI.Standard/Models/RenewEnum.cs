// <copyright file="RenewEnum.cs" company="APIMatic">
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
    /// RenewEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RenewEnum
    {
        /// <summary>
        /// Once.
        /// </summary>
        [EnumMember(Value = "once")]
        Once,

        /// <summary>
        /// Monthly.
        /// </summary>
        [EnumMember(Value = "monthly")]
        Monthly,

        /// <summary>
        /// Yearly.
        /// </summary>
        [EnumMember(Value = "yearly")]
        Yearly
    }
}