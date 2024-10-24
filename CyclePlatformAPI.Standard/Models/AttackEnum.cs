// <copyright file="AttackEnum.cs" company="APIMatic">
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
    /// AttackEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AttackEnum
    {
        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Authfailure.
        /// </summary>
        [EnumMember(Value = "auth-failure")]
        Authfailure,

        /// <summary>
        /// Bruteforce.
        /// </summary>
        [EnumMember(Value = "brute-force")]
        Bruteforce,

        /// <summary>
        /// Exploitvulnerability.
        /// </summary>
        [EnumMember(Value = "exploit-vulnerability")]
        Exploitvulnerability,

        /// <summary>
        /// Socialengineer.
        /// </summary>
        [EnumMember(Value = "social-engineer")]
        Socialengineer,

        /// <summary>
        /// Serviceinterruption.
        /// </summary>
        [EnumMember(Value = "service-interruption")]
        Serviceinterruption,

        /// <summary>
        /// Accesselevation.
        /// </summary>
        [EnumMember(Value = "access-elevation")]
        Accesselevation
    }
}