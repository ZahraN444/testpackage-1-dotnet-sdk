// <copyright file="ReadyStateEnum.cs" company="APIMatic">
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
    /// ReadyStateEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReadyStateEnum
    {
        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Purge.
        /// </summary>
        [EnumMember(Value = "purge")]
        Purge,

        /// <summary>
        /// Hibernate.
        /// </summary>
        [EnumMember(Value = "hibernate")]
        Hibernate,

        /// <summary>
        /// Configuring.
        /// </summary>
        [EnumMember(Value = "configuring")]
        Configuring
    }
}