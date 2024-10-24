// <copyright file="StackContainerScaleThreshold.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<StackContainerScaleThreshold>),
        new Type[] {
            typeof(StackContainerScaleThresholdRamCase),
            typeof(StackContainerScaleThresholdCpuCase),
            typeof(StackContainerScaleThresholdNetworkConnectionsCase),
            typeof(StackContainerScaleThresholdNetworkRequestsCase),
            typeof(StackContainerScaleThresholdNetworkThroughputCase)
        },
        new string[] {
            "ram",
            "cpu",
            "network-connections",
            "network-requests",
            "network-throughput"
        },
        "type",
        true
    )]
    public abstract class StackContainerScaleThreshold
    {
        /// <summary>
        /// This is StackContainerScaleThresholdRam case.
        /// </summary>
        /// <returns>
        /// The StackContainerScaleThreshold instance, wrapping the provided StackContainerScaleThresholdRam value.
        /// </returns>
        public static StackContainerScaleThreshold FromStackContainerScaleThresholdRam(StackContainerScaleThresholdRam stackContainerScaleThresholdRam)
        {
            return new StackContainerScaleThresholdRamCase().Set(stackContainerScaleThresholdRam);
        }

        /// <summary>
        /// This is StackContainerScaleThresholdCpu case.
        /// </summary>
        /// <returns>
        /// The StackContainerScaleThreshold instance, wrapping the provided StackContainerScaleThresholdCpu value.
        /// </returns>
        public static StackContainerScaleThreshold FromStackContainerScaleThresholdCpu(StackContainerScaleThresholdCpu stackContainerScaleThresholdCpu)
        {
            return new StackContainerScaleThresholdCpuCase().Set(stackContainerScaleThresholdCpu);
        }

        /// <summary>
        /// This is StackContainerScaleThresholdNetworkConnections case.
        /// </summary>
        /// <returns>
        /// The StackContainerScaleThreshold instance, wrapping the provided StackContainerScaleThresholdNetworkConnections value.
        /// </returns>
        public static StackContainerScaleThreshold FromStackContainerScaleThresholdNetworkConnections(StackContainerScaleThresholdNetworkConnections stackContainerScaleThresholdNetworkConnections)
        {
            return new StackContainerScaleThresholdNetworkConnectionsCase().Set(stackContainerScaleThresholdNetworkConnections);
        }

        /// <summary>
        /// This is StackContainerScaleThresholdNetworkRequests case.
        /// </summary>
        /// <returns>
        /// The StackContainerScaleThreshold instance, wrapping the provided StackContainerScaleThresholdNetworkRequests value.
        /// </returns>
        public static StackContainerScaleThreshold FromStackContainerScaleThresholdNetworkRequests(StackContainerScaleThresholdNetworkRequests stackContainerScaleThresholdNetworkRequests)
        {
            return new StackContainerScaleThresholdNetworkRequestsCase().Set(stackContainerScaleThresholdNetworkRequests);
        }

        /// <summary>
        /// This is StackContainerScaleThresholdNetworkThroughput case.
        /// </summary>
        /// <returns>
        /// The StackContainerScaleThreshold instance, wrapping the provided StackContainerScaleThresholdNetworkThroughput value.
        /// </returns>
        public static StackContainerScaleThreshold FromStackContainerScaleThresholdNetworkThroughput(StackContainerScaleThresholdNetworkThroughput stackContainerScaleThresholdNetworkThroughput)
        {
            return new StackContainerScaleThresholdNetworkThroughputCase().Set(stackContainerScaleThresholdNetworkThroughput);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<StackContainerScaleThresholdRam, T> stackContainerScaleThresholdRam,
            Func<StackContainerScaleThresholdCpu, T> stackContainerScaleThresholdCpu,
            Func<StackContainerScaleThresholdNetworkConnections, T> stackContainerScaleThresholdNetworkConnections,
            Func<StackContainerScaleThresholdNetworkRequests, T> stackContainerScaleThresholdNetworkRequests,
            Func<StackContainerScaleThresholdNetworkThroughput, T> stackContainerScaleThresholdNetworkThroughput);

        [JsonConverter(typeof(UnionTypeCaseConverter<StackContainerScaleThresholdRamCase, StackContainerScaleThresholdRam>))]
        private sealed class StackContainerScaleThresholdRamCase : StackContainerScaleThreshold, ICaseValue<StackContainerScaleThresholdRamCase, StackContainerScaleThresholdRam>
        {
            public StackContainerScaleThresholdRam _value;

            public override T Match<T>(
                Func<StackContainerScaleThresholdRam, T> stackContainerScaleThresholdRam,
                Func<StackContainerScaleThresholdCpu, T> stackContainerScaleThresholdCpu,
                Func<StackContainerScaleThresholdNetworkConnections, T> stackContainerScaleThresholdNetworkConnections,
                Func<StackContainerScaleThresholdNetworkRequests, T> stackContainerScaleThresholdNetworkRequests,
                Func<StackContainerScaleThresholdNetworkThroughput, T> stackContainerScaleThresholdNetworkThroughput)
            {
                return stackContainerScaleThresholdRam(_value);
            }

            public StackContainerScaleThresholdRamCase Set(StackContainerScaleThresholdRam value)
            {
                _value = value;
                return this;
            }

            public StackContainerScaleThresholdRam Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<StackContainerScaleThresholdCpuCase, StackContainerScaleThresholdCpu>))]
        private sealed class StackContainerScaleThresholdCpuCase : StackContainerScaleThreshold, ICaseValue<StackContainerScaleThresholdCpuCase, StackContainerScaleThresholdCpu>
        {
            public StackContainerScaleThresholdCpu _value;

            public override T Match<T>(
                Func<StackContainerScaleThresholdRam, T> stackContainerScaleThresholdRam,
                Func<StackContainerScaleThresholdCpu, T> stackContainerScaleThresholdCpu,
                Func<StackContainerScaleThresholdNetworkConnections, T> stackContainerScaleThresholdNetworkConnections,
                Func<StackContainerScaleThresholdNetworkRequests, T> stackContainerScaleThresholdNetworkRequests,
                Func<StackContainerScaleThresholdNetworkThroughput, T> stackContainerScaleThresholdNetworkThroughput)
            {
                return stackContainerScaleThresholdCpu(_value);
            }

            public StackContainerScaleThresholdCpuCase Set(StackContainerScaleThresholdCpu value)
            {
                _value = value;
                return this;
            }

            public StackContainerScaleThresholdCpu Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<StackContainerScaleThresholdNetworkConnectionsCase, StackContainerScaleThresholdNetworkConnections>))]
        private sealed class StackContainerScaleThresholdNetworkConnectionsCase : StackContainerScaleThreshold, ICaseValue<StackContainerScaleThresholdNetworkConnectionsCase, StackContainerScaleThresholdNetworkConnections>
        {
            public StackContainerScaleThresholdNetworkConnections _value;

            public override T Match<T>(
                Func<StackContainerScaleThresholdRam, T> stackContainerScaleThresholdRam,
                Func<StackContainerScaleThresholdCpu, T> stackContainerScaleThresholdCpu,
                Func<StackContainerScaleThresholdNetworkConnections, T> stackContainerScaleThresholdNetworkConnections,
                Func<StackContainerScaleThresholdNetworkRequests, T> stackContainerScaleThresholdNetworkRequests,
                Func<StackContainerScaleThresholdNetworkThroughput, T> stackContainerScaleThresholdNetworkThroughput)
            {
                return stackContainerScaleThresholdNetworkConnections(_value);
            }

            public StackContainerScaleThresholdNetworkConnectionsCase Set(StackContainerScaleThresholdNetworkConnections value)
            {
                _value = value;
                return this;
            }

            public StackContainerScaleThresholdNetworkConnections Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<StackContainerScaleThresholdNetworkRequestsCase, StackContainerScaleThresholdNetworkRequests>))]
        private sealed class StackContainerScaleThresholdNetworkRequestsCase : StackContainerScaleThreshold, ICaseValue<StackContainerScaleThresholdNetworkRequestsCase, StackContainerScaleThresholdNetworkRequests>
        {
            public StackContainerScaleThresholdNetworkRequests _value;

            public override T Match<T>(
                Func<StackContainerScaleThresholdRam, T> stackContainerScaleThresholdRam,
                Func<StackContainerScaleThresholdCpu, T> stackContainerScaleThresholdCpu,
                Func<StackContainerScaleThresholdNetworkConnections, T> stackContainerScaleThresholdNetworkConnections,
                Func<StackContainerScaleThresholdNetworkRequests, T> stackContainerScaleThresholdNetworkRequests,
                Func<StackContainerScaleThresholdNetworkThroughput, T> stackContainerScaleThresholdNetworkThroughput)
            {
                return stackContainerScaleThresholdNetworkRequests(_value);
            }

            public StackContainerScaleThresholdNetworkRequestsCase Set(StackContainerScaleThresholdNetworkRequests value)
            {
                _value = value;
                return this;
            }

            public StackContainerScaleThresholdNetworkRequests Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<StackContainerScaleThresholdNetworkThroughputCase, StackContainerScaleThresholdNetworkThroughput>))]
        private sealed class StackContainerScaleThresholdNetworkThroughputCase : StackContainerScaleThreshold, ICaseValue<StackContainerScaleThresholdNetworkThroughputCase, StackContainerScaleThresholdNetworkThroughput>
        {
            public StackContainerScaleThresholdNetworkThroughput _value;

            public override T Match<T>(
                Func<StackContainerScaleThresholdRam, T> stackContainerScaleThresholdRam,
                Func<StackContainerScaleThresholdCpu, T> stackContainerScaleThresholdCpu,
                Func<StackContainerScaleThresholdNetworkConnections, T> stackContainerScaleThresholdNetworkConnections,
                Func<StackContainerScaleThresholdNetworkRequests, T> stackContainerScaleThresholdNetworkRequests,
                Func<StackContainerScaleThresholdNetworkThroughput, T> stackContainerScaleThresholdNetworkThroughput)
            {
                return stackContainerScaleThresholdNetworkThroughput(_value);
            }

            public StackContainerScaleThresholdNetworkThroughputCase Set(StackContainerScaleThresholdNetworkThroughput value)
            {
                _value = value;
                return this;
            }

            public StackContainerScaleThresholdNetworkThroughput Get()
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