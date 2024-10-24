// <copyright file="Scope1Enum.cs" company="APIMatic">
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
    /// Scope1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Scope1Enum
    {
        /// <summary>
        /// Public.
        /// </summary>
        [EnumMember(Value = "public")]
        Public,

        /// <summary>
        /// Private.
        /// </summary>
        [EnumMember(Value = "private")]
        Private,

        /// <summary>
        /// Shared.
        /// </summary>
        [EnumMember(Value = "shared")]
        Shared
    }
}