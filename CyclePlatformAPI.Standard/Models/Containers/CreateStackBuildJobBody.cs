// <copyright file="CreateStackBuildJobBody.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<CreateStackBuildJobBody>),
        new Type[] {
            typeof(GenerateStackBuildCase),
            typeof(DeployStackBuildCase)
        },
        true
    )]
    public abstract class CreateStackBuildJobBody
    {
        /// <summary>
        /// This is GenerateStackBuild case.
        /// </summary>
        /// <returns>
        /// The CreateStackBuildJobBody instance, wrapping the provided GenerateStackBuild value.
        /// </returns>
        public static CreateStackBuildJobBody FromGenerateStackBuild(GenerateStackBuild generateStackBuild)
        {
            return new GenerateStackBuildCase().Set(generateStackBuild);
        }

        /// <summary>
        /// This is DeployStackBuild case.
        /// </summary>
        /// <returns>
        /// The CreateStackBuildJobBody instance, wrapping the provided DeployStackBuild value.
        /// </returns>
        public static CreateStackBuildJobBody FromDeployStackBuild(DeployStackBuild deployStackBuild)
        {
            return new DeployStackBuildCase().Set(deployStackBuild);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<GenerateStackBuild, T> generateStackBuild, Func<DeployStackBuild, T> deployStackBuild);

        [JsonConverter(typeof(UnionTypeCaseConverter<GenerateStackBuildCase, GenerateStackBuild>))]
        private sealed class GenerateStackBuildCase : CreateStackBuildJobBody, ICaseValue<GenerateStackBuildCase, GenerateStackBuild>
        {
            public GenerateStackBuild _value;

            public override T Match<T>(Func<GenerateStackBuild, T> generateStackBuild, Func<DeployStackBuild, T> deployStackBuild)
            {
                return generateStackBuild(_value);
            }

            public GenerateStackBuildCase Set(GenerateStackBuild value)
            {
                _value = value;
                return this;
            }

            public GenerateStackBuild Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DeployStackBuildCase, DeployStackBuild>))]
        private sealed class DeployStackBuildCase : CreateStackBuildJobBody, ICaseValue<DeployStackBuildCase, DeployStackBuild>
        {
            public DeployStackBuild _value;

            public override T Match<T>(Func<GenerateStackBuild, T> generateStackBuild, Func<DeployStackBuild, T> deployStackBuild)
            {
                return deployStackBuild(_value);
            }

            public DeployStackBuildCase Set(DeployStackBuild value)
            {
                _value = value;
                return this;
            }

            public DeployStackBuild Get()
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