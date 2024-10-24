// <copyright file="CreateVPNServiceJobBody.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace CyclePlatformAPI.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<CreateVPNServiceJobBody>),
        new Type[] {
            typeof(VpnResetTaskCase),
            typeof(VpnReconfigureTaskCase)
        },
        true
    )]
    public abstract class CreateVPNServiceJobBody
    {
        /// <summary>
        /// This is VpnResetTask case.
        /// </summary>
        /// <returns>
        /// The CreateVPNServiceJobBody instance, wrapping the provided VpnResetTask value.
        /// </returns>
        public static CreateVPNServiceJobBody FromVpnResetTask(VpnResetTask vpnResetTask)
        {
            return new VpnResetTaskCase().Set(vpnResetTask);
        }

        /// <summary>
        /// This is VpnReconfigureTask case.
        /// </summary>
        /// <returns>
        /// The CreateVPNServiceJobBody instance, wrapping the provided VpnReconfigureTask value.
        /// </returns>
        public static CreateVPNServiceJobBody FromVpnReconfigureTask(VpnReconfigureTask vpnReconfigureTask)
        {
            return new VpnReconfigureTaskCase().Set(vpnReconfigureTask);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<VpnResetTask, T> vpnResetTask, Func<VpnReconfigureTask, T> vpnReconfigureTask);

        [JsonConverter(typeof(UnionTypeCaseConverter<VpnResetTaskCase, VpnResetTask>))]
        private sealed class VpnResetTaskCase : CreateVPNServiceJobBody, ICaseValue<VpnResetTaskCase, VpnResetTask>
        {
            public VpnResetTask _value;

            public override T Match<T>(Func<VpnResetTask, T> vpnResetTask, Func<VpnReconfigureTask, T> vpnReconfigureTask)
            {
                return vpnResetTask(_value);
            }

            public VpnResetTaskCase Set(VpnResetTask value)
            {
                _value = value;
                return this;
            }

            public VpnResetTask Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<VpnReconfigureTaskCase, VpnReconfigureTask>))]
        private sealed class VpnReconfigureTaskCase : CreateVPNServiceJobBody, ICaseValue<VpnReconfigureTaskCase, VpnReconfigureTask>
        {
            public VpnReconfigureTask _value;

            public override T Match<T>(Func<VpnResetTask, T> vpnResetTask, Func<VpnReconfigureTask, T> vpnReconfigureTask)
            {
                return vpnReconfigureTask(_value);
            }

            public VpnReconfigureTaskCase Set(VpnReconfigureTask value)
            {
                _value = value;
                return this;
            }

            public VpnReconfigureTask Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }
    }
}