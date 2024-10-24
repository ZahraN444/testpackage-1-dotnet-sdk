// <copyright file="Type1Enum.cs" company="APIMatic">
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
    /// Type1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type1Enum
    {
        /// <summary>
        /// Password.
        /// </summary>
        [EnumMember(Value = "password")]
        Password,

        /// <summary>
        /// Employee.
        /// </summary>
        [EnumMember(Value = "employee")]
        Employee
    }
}