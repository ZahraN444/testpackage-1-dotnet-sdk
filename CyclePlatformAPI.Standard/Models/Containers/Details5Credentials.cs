// <copyright file="Details5Credentials.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CyclePlatformAPI.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<Details5Credentials>),
        new Type[] {
            typeof(ListOfDockerfileCredentailCase)
        },
        false
    )]
    public abstract class Details5Credentials
    {
        /// <summary>
        /// This is List of DockerfileCredentail case.
        /// </summary>
        /// <returns>
        /// The Details5Credentials instance, wrapping the provided List&lt;DockerfileCredentail&gt; value.
        /// </returns>
        public static Details5Credentials FromListOfDockerfileCredentail(List<DockerfileCredentail> listOfDockerfileCredentail)
        {
            return new ListOfDockerfileCredentailCase().Set(listOfDockerfileCredentail);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<List<DockerfileCredentail>, T> listOfDockerfileCredentail);

        [JsonConverter(typeof(UnionTypeCaseConverter<ListOfDockerfileCredentailCase, List<DockerfileCredentail>>))]
        private sealed class ListOfDockerfileCredentailCase : Details5Credentials, ICaseValue<ListOfDockerfileCredentailCase, List<DockerfileCredentail>>
        {
            public List<DockerfileCredentail> _value;

            public override T Match<T>(Func<List<DockerfileCredentail>, T> listOfDockerfileCredentail)
            {
                return listOfDockerfileCredentail(_value);
            }

            public ListOfDockerfileCredentailCase Set(List<DockerfileCredentail> value)
            {
                _value = value;
                return this;
            }

            public List<DockerfileCredentail> Get()
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