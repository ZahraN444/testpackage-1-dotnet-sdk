// <copyright file="Details5Repo.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<Details5Repo>),
        new Type[] {
            typeof(RepoSourceTypeCase)
        },
        false
    )]
    public abstract class Details5Repo
    {
        /// <summary>
        /// This is RepoSourceType case.
        /// </summary>
        /// <returns>
        /// The Details5Repo instance, wrapping the provided RepoSourceType value.
        /// </returns>
        public static Details5Repo FromRepoSourceType(RepoSourceType repoSourceType)
        {
            return new RepoSourceTypeCase().Set(repoSourceType);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<RepoSourceType, T> repoSourceType);

        [JsonConverter(typeof(UnionTypeCaseConverter<RepoSourceTypeCase, RepoSourceType>))]
        private sealed class RepoSourceTypeCase : Details5Repo, ICaseValue<RepoSourceTypeCase, RepoSourceType>
        {
            public RepoSourceType _value;

            public override T Match<T>(Func<RepoSourceType, T> repoSourceType)
            {
                return repoSourceType(_value);
            }

            public RepoSourceTypeCase Set(RepoSourceType value)
            {
                _value = value;
                return this;
            }

            public RepoSourceType Get()
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