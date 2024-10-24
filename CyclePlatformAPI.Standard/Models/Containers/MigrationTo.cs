// <copyright file="MigrationTo.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<MigrationTo>),
        new Type[] {
            typeof(MigrationInstanceCase)
        },
        false
    )]
    public abstract class MigrationTo
    {
        /// <summary>
        /// This is MigrationInstance case.
        /// </summary>
        /// <returns>
        /// The MigrationTo instance, wrapping the provided MigrationInstance value.
        /// </returns>
        public static MigrationTo FromMigrationInstance(MigrationInstance migrationInstance)
        {
            return new MigrationInstanceCase().Set(migrationInstance);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<MigrationInstance, T> migrationInstance);

        [JsonConverter(typeof(UnionTypeCaseConverter<MigrationInstanceCase, MigrationInstance>))]
        private sealed class MigrationInstanceCase : MigrationTo, ICaseValue<MigrationInstanceCase, MigrationInstance>
        {
            public MigrationInstance _value;

            public override T Match<T>(Func<MigrationInstance, T> migrationInstance)
            {
                return migrationInstance(_value);
            }

            public MigrationInstanceCase Set(MigrationInstance value)
            {
                _value = value;
                return this;
            }

            public MigrationInstance Get()
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