// <copyright file="Capabilities4Enum.cs" company="APIMatic">
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
    /// Capabilities4Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Capabilities4Enum
    {
        /// <summary>
        /// CAPCHOWN.
        /// </summary>
        [EnumMember(Value = "CAP_CHOWN")]
        CAPCHOWN,

        /// <summary>
        /// CAPFSETID.
        /// </summary>
        [EnumMember(Value = "CAP_FSETID")]
        CAPFSETID,

        /// <summary>
        /// CAPDACOVERRIDE.
        /// </summary>
        [EnumMember(Value = "CAP_DAC_OVERRIDE")]
        CAPDACOVERRIDE,

        /// <summary>
        /// CAPFOWNER.
        /// </summary>
        [EnumMember(Value = "CAP_FOWNER")]
        CAPFOWNER,

        /// <summary>
        /// CAPSETFCAP.
        /// </summary>
        [EnumMember(Value = "CAP_SETFCAP")]
        CAPSETFCAP,

        /// <summary>
        /// CAPSETGID.
        /// </summary>
        [EnumMember(Value = "CAP_SETGID")]
        CAPSETGID,

        /// <summary>
        /// CAPSETUID.
        /// </summary>
        [EnumMember(Value = "CAP_SETUID")]
        CAPSETUID,

        /// <summary>
        /// CAPKILL.
        /// </summary>
        [EnumMember(Value = "CAP_KILL")]
        CAPKILL,

        /// <summary>
        /// CAPMKNOD.
        /// </summary>
        [EnumMember(Value = "CAP_MKNOD")]
        CAPMKNOD,

        /// <summary>
        /// CAPNETBINDSERVICE.
        /// </summary>
        [EnumMember(Value = "CAP_NET_BIND_SERVICE")]
        CAPNETBINDSERVICE,

        /// <summary>
        /// CAPNETRAW.
        /// </summary>
        [EnumMember(Value = "CAP_NET_RAW")]
        CAPNETRAW,

        /// <summary>
        /// CAPAUDITWRITE.
        /// </summary>
        [EnumMember(Value = "CAP_AUDIT_WRITE")]
        CAPAUDITWRITE,

        /// <summary>
        /// CAPSYSCHROOT.
        /// </summary>
        [EnumMember(Value = "CAP_SYS_CHROOT")]
        CAPSYSCHROOT,

        /// <summary>
        /// CAPSETPCAP.
        /// </summary>
        [EnumMember(Value = "CAP_SETPCAP")]
        CAPSETPCAP,

        /// <summary>
        /// CAPDACREADSEARCH.
        /// </summary>
        [EnumMember(Value = "CAP_DAC_READ_SEARCH")]
        CAPDACREADSEARCH,

        /// <summary>
        /// CAPNETADMIN.
        /// </summary>
        [EnumMember(Value = "CAP_NET_ADMIN")]
        CAPNETADMIN,

        /// <summary>
        /// CAPNETBROADCAST.
        /// </summary>
        [EnumMember(Value = "CAP_NET_BROADCAST")]
        CAPNETBROADCAST,

        /// <summary>
        /// CAPSYSADMIN.
        /// </summary>
        [EnumMember(Value = "CAP_SYS_ADMIN")]
        CAPSYSADMIN,

        /// <summary>
        /// CAPSYSMODULE.
        /// </summary>
        [EnumMember(Value = "CAP_SYS_MODULE")]
        CAPSYSMODULE,

        /// <summary>
        /// CAPSYSNICE.
        /// </summary>
        [EnumMember(Value = "CAP_SYS_NICE")]
        CAPSYSNICE,

        /// <summary>
        /// CAPSYSPACCT.
        /// </summary>
        [EnumMember(Value = "CAP_SYS_PACCT")]
        CAPSYSPACCT,

        /// <summary>
        /// CAPSYSPTRACE.
        /// </summary>
        [EnumMember(Value = "CAP_SYS_PTRACE")]
        CAPSYSPTRACE,

        /// <summary>
        /// CAPSYSRAWIO.
        /// </summary>
        [EnumMember(Value = "CAP_SYS_RAWIO")]
        CAPSYSRAWIO,

        /// <summary>
        /// CAPSYSRESOURCE.
        /// </summary>
        [EnumMember(Value = "CAP_SYS_RESOURCE")]
        CAPSYSRESOURCE,

        /// <summary>
        /// CAPSYSBOOT.
        /// </summary>
        [EnumMember(Value = "CAP_SYS_BOOT")]
        CAPSYSBOOT,

        /// <summary>
        /// CAPSYSTIME.
        /// </summary>
        [EnumMember(Value = "CAP_SYS_TIME")]
        CAPSYSTIME,

        /// <summary>
        /// CAPSYSTTYCONFIG.
        /// </summary>
        [EnumMember(Value = "CAP_SYS_TTY_CONFIG")]
        CAPSYSTTYCONFIG,

        /// <summary>
        /// CAPSYSLOG.
        /// </summary>
        [EnumMember(Value = "CAP_SYSLOG")]
        CAPSYSLOG,

        /// <summary>
        /// CAPAUDITCONTROL.
        /// </summary>
        [EnumMember(Value = "CAP_AUDIT_CONTROL")]
        CAPAUDITCONTROL,

        /// <summary>
        /// CAPAUDITREAD.
        /// </summary>
        [EnumMember(Value = "CAP_AUDIT_READ")]
        CAPAUDITREAD,

        /// <summary>
        /// CAPIPCLOCK.
        /// </summary>
        [EnumMember(Value = "CAP_IPC_LOCK")]
        CAPIPCLOCK,

        /// <summary>
        /// CAPIPCOWNER.
        /// </summary>
        [EnumMember(Value = "CAP_IPC_OWNER")]
        CAPIPCOWNER,

        /// <summary>
        /// CAPLINUXIMMUTABLE.
        /// </summary>
        [EnumMember(Value = "CAP_LINUX_IMMUTABLE")]
        CAPLINUXIMMUTABLE,

        /// <summary>
        /// CAPMACADMIN.
        /// </summary>
        [EnumMember(Value = "CAP_MAC_ADMIN")]
        CAPMACADMIN,

        /// <summary>
        /// CAPMACOVERRIDE.
        /// </summary>
        [EnumMember(Value = "CAP_MAC_OVERRIDE")]
        CAPMACOVERRIDE,

        /// <summary>
        /// CAPBLOCKSUSPEND.
        /// </summary>
        [EnumMember(Value = "CAP_BLOCK_SUSPEND")]
        CAPBLOCKSUSPEND,

        /// <summary>
        /// CAPLEASE.
        /// </summary>
        [EnumMember(Value = "CAP_LEASE")]
        CAPLEASE,

        /// <summary>
        /// CAPWAKEALARM.
        /// </summary>
        [EnumMember(Value = "CAP_WAKE_ALARM")]
        CAPWAKEALARM
    }
}