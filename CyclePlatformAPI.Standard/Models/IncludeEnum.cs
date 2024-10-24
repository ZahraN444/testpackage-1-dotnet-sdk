// <copyright file="IncludeEnum.cs" company="APIMatic">
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
    /// IncludeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IncludeEnum
    {
        /// <summary>
        /// Senders.
        /// </summary>
        [EnumMember(Value = "senders")]
        Senders,

        /// <summary>
        /// Hubs.
        /// </summary>
        [EnumMember(Value = "hubs")]
        Hubs,

        /// <summary>
        /// Accounts.
        /// </summary>
        [EnumMember(Value = "accounts")]
        Accounts,

        /// <summary>
        /// Roles.
        /// </summary>
        [EnumMember(Value = "roles")]
        Roles
    }
}