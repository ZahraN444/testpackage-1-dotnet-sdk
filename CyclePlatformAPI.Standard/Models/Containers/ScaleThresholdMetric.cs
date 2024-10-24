// <copyright file="ScaleThresholdMetric.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<ScaleThresholdMetric>),
        new Type[] {
            typeof(ScaleThresholdMetricRamCase),
            typeof(ScaleThresholdMetricCpuCase),
            typeof(ScaleThresholdMetricNetworkConnectionsCase),
            typeof(ScaleThresholdMetricNetworkRequestsCase),
            typeof(ScaleThresholdMetricNetworkThroughputCase)
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
    public abstract class ScaleThresholdMetric
    {
        /// <summary>
        /// This is ScaleThresholdMetricRam case.
        /// </summary>
        /// <returns>
        /// The ScaleThresholdMetric instance, wrapping the provided ScaleThresholdMetricRam value.
        /// </returns>
        public static ScaleThresholdMetric FromScaleThresholdMetricRam(ScaleThresholdMetricRam scaleThresholdMetricRam)
        {
            return new ScaleThresholdMetricRamCase().Set(scaleThresholdMetricRam);
        }

        /// <summary>
        /// This is ScaleThresholdMetricCpu case.
        /// </summary>
        /// <returns>
        /// The ScaleThresholdMetric instance, wrapping the provided ScaleThresholdMetricCpu value.
        /// </returns>
        public static ScaleThresholdMetric FromScaleThresholdMetricCpu(ScaleThresholdMetricCpu scaleThresholdMetricCpu)
        {
            return new ScaleThresholdMetricCpuCase().Set(scaleThresholdMetricCpu);
        }

        /// <summary>
        /// This is ScaleThresholdMetricNetworkConnections case.
        /// </summary>
        /// <returns>
        /// The ScaleThresholdMetric instance, wrapping the provided ScaleThresholdMetricNetworkConnections value.
        /// </returns>
        public static ScaleThresholdMetric FromScaleThresholdMetricNetworkConnections(ScaleThresholdMetricNetworkConnections scaleThresholdMetricNetworkConnections)
        {
            return new ScaleThresholdMetricNetworkConnectionsCase().Set(scaleThresholdMetricNetworkConnections);
        }

        /// <summary>
        /// This is ScaleThresholdMetricNetworkRequests case.
        /// </summary>
        /// <returns>
        /// The ScaleThresholdMetric instance, wrapping the provided ScaleThresholdMetricNetworkRequests value.
        /// </returns>
        public static ScaleThresholdMetric FromScaleThresholdMetricNetworkRequests(ScaleThresholdMetricNetworkRequests scaleThresholdMetricNetworkRequests)
        {
            return new ScaleThresholdMetricNetworkRequestsCase().Set(scaleThresholdMetricNetworkRequests);
        }

        /// <summary>
        /// This is ScaleThresholdMetricNetworkThroughput case.
        /// </summary>
        /// <returns>
        /// The ScaleThresholdMetric instance, wrapping the provided ScaleThresholdMetricNetworkThroughput value.
        /// </returns>
        public static ScaleThresholdMetric FromScaleThresholdMetricNetworkThroughput(ScaleThresholdMetricNetworkThroughput scaleThresholdMetricNetworkThroughput)
        {
            return new ScaleThresholdMetricNetworkThroughputCase().Set(scaleThresholdMetricNetworkThroughput);
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
            Func<ScaleThresholdMetricRam, T> scaleThresholdMetricRam,
            Func<ScaleThresholdMetricCpu, T> scaleThresholdMetricCpu,
            Func<ScaleThresholdMetricNetworkConnections, T> scaleThresholdMetricNetworkConnections,
            Func<ScaleThresholdMetricNetworkRequests, T> scaleThresholdMetricNetworkRequests,
            Func<ScaleThresholdMetricNetworkThroughput, T> scaleThresholdMetricNetworkThroughput);

        [JsonConverter(typeof(UnionTypeCaseConverter<ScaleThresholdMetricRamCase, ScaleThresholdMetricRam>))]
        private sealed class ScaleThresholdMetricRamCase : ScaleThresholdMetric, ICaseValue<ScaleThresholdMetricRamCase, ScaleThresholdMetricRam>
        {
            public ScaleThresholdMetricRam _value;

            public override T Match<T>(
                Func<ScaleThresholdMetricRam, T> scaleThresholdMetricRam,
                Func<ScaleThresholdMetricCpu, T> scaleThresholdMetricCpu,
                Func<ScaleThresholdMetricNetworkConnections, T> scaleThresholdMetricNetworkConnections,
                Func<ScaleThresholdMetricNetworkRequests, T> scaleThresholdMetricNetworkRequests,
                Func<ScaleThresholdMetricNetworkThroughput, T> scaleThresholdMetricNetworkThroughput)
            {
                return scaleThresholdMetricRam(_value);
            }

            public ScaleThresholdMetricRamCase Set(ScaleThresholdMetricRam value)
            {
                _value = value;
                return this;
            }

            public ScaleThresholdMetricRam Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ScaleThresholdMetricCpuCase, ScaleThresholdMetricCpu>))]
        private sealed class ScaleThresholdMetricCpuCase : ScaleThresholdMetric, ICaseValue<ScaleThresholdMetricCpuCase, ScaleThresholdMetricCpu>
        {
            public ScaleThresholdMetricCpu _value;

            public override T Match<T>(
                Func<ScaleThresholdMetricRam, T> scaleThresholdMetricRam,
                Func<ScaleThresholdMetricCpu, T> scaleThresholdMetricCpu,
                Func<ScaleThresholdMetricNetworkConnections, T> scaleThresholdMetricNetworkConnections,
                Func<ScaleThresholdMetricNetworkRequests, T> scaleThresholdMetricNetworkRequests,
                Func<ScaleThresholdMetricNetworkThroughput, T> scaleThresholdMetricNetworkThroughput)
            {
                return scaleThresholdMetricCpu(_value);
            }

            public ScaleThresholdMetricCpuCase Set(ScaleThresholdMetricCpu value)
            {
                _value = value;
                return this;
            }

            public ScaleThresholdMetricCpu Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ScaleThresholdMetricNetworkConnectionsCase, ScaleThresholdMetricNetworkConnections>))]
        private sealed class ScaleThresholdMetricNetworkConnectionsCase : ScaleThresholdMetric, ICaseValue<ScaleThresholdMetricNetworkConnectionsCase, ScaleThresholdMetricNetworkConnections>
        {
            public ScaleThresholdMetricNetworkConnections _value;

            public override T Match<T>(
                Func<ScaleThresholdMetricRam, T> scaleThresholdMetricRam,
                Func<ScaleThresholdMetricCpu, T> scaleThresholdMetricCpu,
                Func<ScaleThresholdMetricNetworkConnections, T> scaleThresholdMetricNetworkConnections,
                Func<ScaleThresholdMetricNetworkRequests, T> scaleThresholdMetricNetworkRequests,
                Func<ScaleThresholdMetricNetworkThroughput, T> scaleThresholdMetricNetworkThroughput)
            {
                return scaleThresholdMetricNetworkConnections(_value);
            }

            public ScaleThresholdMetricNetworkConnectionsCase Set(ScaleThresholdMetricNetworkConnections value)
            {
                _value = value;
                return this;
            }

            public ScaleThresholdMetricNetworkConnections Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ScaleThresholdMetricNetworkRequestsCase, ScaleThresholdMetricNetworkRequests>))]
        private sealed class ScaleThresholdMetricNetworkRequestsCase : ScaleThresholdMetric, ICaseValue<ScaleThresholdMetricNetworkRequestsCase, ScaleThresholdMetricNetworkRequests>
        {
            public ScaleThresholdMetricNetworkRequests _value;

            public override T Match<T>(
                Func<ScaleThresholdMetricRam, T> scaleThresholdMetricRam,
                Func<ScaleThresholdMetricCpu, T> scaleThresholdMetricCpu,
                Func<ScaleThresholdMetricNetworkConnections, T> scaleThresholdMetricNetworkConnections,
                Func<ScaleThresholdMetricNetworkRequests, T> scaleThresholdMetricNetworkRequests,
                Func<ScaleThresholdMetricNetworkThroughput, T> scaleThresholdMetricNetworkThroughput)
            {
                return scaleThresholdMetricNetworkRequests(_value);
            }

            public ScaleThresholdMetricNetworkRequestsCase Set(ScaleThresholdMetricNetworkRequests value)
            {
                _value = value;
                return this;
            }

            public ScaleThresholdMetricNetworkRequests Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ScaleThresholdMetricNetworkThroughputCase, ScaleThresholdMetricNetworkThroughput>))]
        private sealed class ScaleThresholdMetricNetworkThroughputCase : ScaleThresholdMetric, ICaseValue<ScaleThresholdMetricNetworkThroughputCase, ScaleThresholdMetricNetworkThroughput>
        {
            public ScaleThresholdMetricNetworkThroughput _value;

            public override T Match<T>(
                Func<ScaleThresholdMetricRam, T> scaleThresholdMetricRam,
                Func<ScaleThresholdMetricCpu, T> scaleThresholdMetricCpu,
                Func<ScaleThresholdMetricNetworkConnections, T> scaleThresholdMetricNetworkConnections,
                Func<ScaleThresholdMetricNetworkRequests, T> scaleThresholdMetricNetworkRequests,
                Func<ScaleThresholdMetricNetworkThroughput, T> scaleThresholdMetricNetworkThroughput)
            {
                return scaleThresholdMetricNetworkThroughput(_value);
            }

            public ScaleThresholdMetricNetworkThroughputCase Set(ScaleThresholdMetricNetworkThroughput value)
            {
                _value = value;
                return this;
            }

            public ScaleThresholdMetricNetworkThroughput Get()
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