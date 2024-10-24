// <copyright file="Type12Enum.cs" company="APIMatic">
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
    /// Type12Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type12Enum
    {
        /// <summary>
        /// Account.
        /// </summary>
        [EnumMember(Value = "account")]
        Account,

        /// <summary>
        /// Environment.
        /// </summary>
        [EnumMember(Value = "environment")]
        Environment,

        /// <summary>
        /// Platform.
        /// </summary>
        [EnumMember(Value = "platform")]
        Platform,

        /// <summary>
        /// Platformpipeline.
        /// </summary>
        [EnumMember(Value = "platform-pipeline")]
        Platformpipeline,

        /// <summary>
        /// Employee.
        /// </summary>
        [EnumMember(Value = "employee")]
        Employee,

        /// <summary>
        /// Apikey.
        /// </summary>
        [EnumMember(Value = "api-key")]
        Apikey,

        /// <summary>
        /// Visitor.
        /// </summary>
        [EnumMember(Value = "visitor")]
        Visitor
    }
}