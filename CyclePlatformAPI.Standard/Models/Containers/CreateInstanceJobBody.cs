// <copyright file="CreateInstanceJobBody.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<CreateInstanceJobBody>),
        new Type[] {
            typeof(RevertMigrationActionCase),
            typeof(MigrateActionCase)
        },
        true
    )]
    public abstract class CreateInstanceJobBody
    {
        /// <summary>
        /// This is RevertMigrationAction case.
        /// </summary>
        /// <returns>
        /// The CreateInstanceJobBody instance, wrapping the provided RevertMigrationAction value.
        /// </returns>
        public static CreateInstanceJobBody FromRevertMigrationAction(RevertMigrationAction revertMigrationAction)
        {
            return new RevertMigrationActionCase().Set(revertMigrationAction);
        }

        /// <summary>
        /// This is MigrateAction case.
        /// </summary>
        /// <returns>
        /// The CreateInstanceJobBody instance, wrapping the provided MigrateAction value.
        /// </returns>
        public static CreateInstanceJobBody FromMigrateAction(MigrateAction migrateAction)
        {
            return new MigrateActionCase().Set(migrateAction);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<RevertMigrationAction, T> revertMigrationAction, Func<MigrateAction, T> migrateAction);

        [JsonConverter(typeof(UnionTypeCaseConverter<RevertMigrationActionCase, RevertMigrationAction>))]
        private sealed class RevertMigrationActionCase : CreateInstanceJobBody, ICaseValue<RevertMigrationActionCase, RevertMigrationAction>
        {
            public RevertMigrationAction _value;

            public override T Match<T>(Func<RevertMigrationAction, T> revertMigrationAction, Func<MigrateAction, T> migrateAction)
            {
                return revertMigrationAction(_value);
            }

            public RevertMigrationActionCase Set(RevertMigrationAction value)
            {
                _value = value;
                return this;
            }

            public RevertMigrationAction Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MigrateActionCase, MigrateAction>))]
        private sealed class MigrateActionCase : CreateInstanceJobBody, ICaseValue<MigrateActionCase, MigrateAction>
        {
            public MigrateAction _value;

            public override T Match<T>(Func<RevertMigrationAction, T> revertMigrationAction, Func<MigrateAction, T> migrateAction)
            {
                return migrateAction(_value);
            }

            public MigrateActionCase Set(MigrateAction value)
            {
                _value = value;
                return this;
            }

            public MigrateAction Get()
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