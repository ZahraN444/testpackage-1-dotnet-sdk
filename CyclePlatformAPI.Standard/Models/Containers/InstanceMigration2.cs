// <copyright file="InstanceMigration2.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace CyclePlatformAPI.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<InstanceMigration2>),
        new Type[] {
            typeof(InstanceMigrationCase)
        },
        false
    )]
    public abstract class InstanceMigration2
    {
        /// <summary>
        /// This is InstanceMigration case.
        /// </summary>
        /// <returns>
        /// The InstanceMigration2 instance, wrapping the provided InstanceMigration value.
        /// </returns>
        public static InstanceMigration2 FromInstanceMigration(InstanceMigration instanceMigration)
        {
            return new InstanceMigrationCase().Set(instanceMigration);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<InstanceMigration, T> instanceMigration);

        [JsonConverter(typeof(UnionTypeCaseConverter<InstanceMigrationCase, InstanceMigration>))]
        private sealed class InstanceMigrationCase : InstanceMigration2, ICaseValue<InstanceMigrationCase, InstanceMigration>
        {
            public InstanceMigration _value;

            public override T Match<T>(Func<InstanceMigration, T> instanceMigration)
            {
                return instanceMigration(_value);
            }

            public InstanceMigrationCase Set(InstanceMigration value)
            {
                _value = value;
                return this;
            }

            public InstanceMigration Get()
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