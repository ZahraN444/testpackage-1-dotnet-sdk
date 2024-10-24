// <copyright file="ActionEnum.cs" company="APIMatic">
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
    /// ActionEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActionEnum
    {
        /// <summary>
        /// SCMPACTKILL.
        /// </summary>
        [EnumMember(Value = "SCMP_ACT_KILL")]
        SCMPACTKILL,

        /// <summary>
        /// SCMPACTKILLPROCESS.
        /// </summary>
        [EnumMember(Value = "SCMP_ACT_KILL_PROCESS")]
        SCMPACTKILLPROCESS,

        /// <summary>
        /// SCMPACTKILLTHREAD.
        /// </summary>
        [EnumMember(Value = "SCMP_ACT_KILL_THREAD")]
        SCMPACTKILLTHREAD,

        /// <summary>
        /// SCMPACTTRAP.
        /// </summary>
        [EnumMember(Value = "SCMP_ACT_TRAP")]
        SCMPACTTRAP,

        /// <summary>
        /// SCMPACTERRNO.
        /// </summary>
        [EnumMember(Value = "SCMP_ACT_ERRNO")]
        SCMPACTERRNO,

        /// <summary>
        /// SCMPACTTRACE.
        /// </summary>
        [EnumMember(Value = "SCMP_ACT_TRACE")]
        SCMPACTTRACE,

        /// <summary>
        /// SCMPACTALLOW.
        /// </summary>
        [EnumMember(Value = "SCMP_ACT_ALLOW")]
        SCMPACTALLOW,

        /// <summary>
        /// SCMPACTLOG.
        /// </summary>
        [EnumMember(Value = "SCMP_ACT_LOG")]
        SCMPACTLOG,

        /// <summary>
        /// SCMPACTNOTIFY.
        /// </summary>
        [EnumMember(Value = "SCMP_ACT_NOTIFY")]
        SCMPACTNOTIFY
    }
}