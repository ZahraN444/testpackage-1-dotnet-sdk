// <copyright file="Current8Enum.cs" company="APIMatic">
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
    /// Current8Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Current8Enum
    {
        /// <summary>
        /// New.
        /// </summary>
        [EnumMember(Value = "new")]
        New,

        /// <summary>
        /// Billing.
        /// </summary>
        [EnumMember(Value = "billing")]
        Billing,

        /// <summary>
        /// Billed.
        /// </summary>
        [EnumMember(Value = "billed")]
        Billed,

        /// <summary>
        /// Processing.
        /// </summary>
        [EnumMember(Value = "processing")]
        Processing,

        /// <summary>
        /// Partiallypaid.
        /// </summary>
        [EnumMember(Value = "partially-paid")]
        Partiallypaid,

        /// <summary>
        /// Paid.
        /// </summary>
        [EnumMember(Value = "paid")]
        Paid,

        /// <summary>
        /// Refunding.
        /// </summary>
        [EnumMember(Value = "refunding")]
        Refunding,

        /// <summary>
        /// Refunded.
        /// </summary>
        [EnumMember(Value = "refunded")]
        Refunded,

        /// <summary>
        /// Crediting.
        /// </summary>
        [EnumMember(Value = "crediting")]
        Crediting,

        /// <summary>
        /// Credited.
        /// </summary>
        [EnumMember(Value = "credited")]
        Credited,

        /// <summary>
        /// Voiding.
        /// </summary>
        [EnumMember(Value = "voiding")]
        Voiding,

        /// <summary>
        /// Voided.
        /// </summary>
        [EnumMember(Value = "voided")]
        Voided,

        /// <summary>
        /// Uncollectible.
        /// </summary>
        [EnumMember(Value = "uncollectible")]
        Uncollectible
    }
}