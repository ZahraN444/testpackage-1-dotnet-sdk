// <copyright file="Include5Enum.cs" company="APIMatic">
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
    /// Include5Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Include5Enum
    {
        /// <summary>
        /// Creators.
        /// </summary>
        [EnumMember(Value = "creators")]
        Creators,

        /// <summary>
        /// Images.
        /// </summary>
        [EnumMember(Value = "images")]
        Images,

        /// <summary>
        /// StackBuilds.
        /// </summary>
        [EnumMember(Value = "stack_builds")]
        StackBuilds,

        /// <summary>
        /// Stacks.
        /// </summary>
        [EnumMember(Value = "stacks")]
        Stacks,

        /// <summary>
        /// Environments.
        /// </summary>
        [EnumMember(Value = "environments")]
        Environments
    }
}