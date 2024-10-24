// <copyright file="PipelineIncludesComponents.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<PipelineIncludesComponents>),
        new Type[] {
            typeof(ContainerCase),
            typeof(EnvironmentCase),
            typeof(StackCase),
            typeof(StackBuildCase),
            typeof(ImageCase),
            typeof(ImageSourceCase)
        },
        true
    )]
    public abstract class PipelineIncludesComponents
    {
        /// <summary>
        /// This is Container case.
        /// </summary>
        /// <returns>
        /// The PipelineIncludesComponents instance, wrapping the provided Container value.
        /// </returns>
        public static PipelineIncludesComponents FromContainer(Container container)
        {
            return new ContainerCase().Set(container);
        }

        /// <summary>
        /// This is Environment case.
        /// </summary>
        /// <returns>
        /// The PipelineIncludesComponents instance, wrapping the provided Environment value.
        /// </returns>
        public static PipelineIncludesComponents FromEnvironment(Environment environment)
        {
            return new EnvironmentCase().Set(environment);
        }

        /// <summary>
        /// This is Stack case.
        /// </summary>
        /// <returns>
        /// The PipelineIncludesComponents instance, wrapping the provided Stack value.
        /// </returns>
        public static PipelineIncludesComponents FromStack(Stack stack)
        {
            return new StackCase().Set(stack);
        }

        /// <summary>
        /// This is StackBuild case.
        /// </summary>
        /// <returns>
        /// The PipelineIncludesComponents instance, wrapping the provided StackBuild value.
        /// </returns>
        public static PipelineIncludesComponents FromStackBuild(StackBuild stackBuild)
        {
            return new StackBuildCase().Set(stackBuild);
        }

        /// <summary>
        /// This is Image case.
        /// </summary>
        /// <returns>
        /// The PipelineIncludesComponents instance, wrapping the provided Image value.
        /// </returns>
        public static PipelineIncludesComponents FromImage(Image image)
        {
            return new ImageCase().Set(image);
        }

        /// <summary>
        /// This is ImageSource case.
        /// </summary>
        /// <returns>
        /// The PipelineIncludesComponents instance, wrapping the provided ImageSource value.
        /// </returns>
        public static PipelineIncludesComponents FromImageSource(ImageSource imageSource)
        {
            return new ImageSourceCase().Set(imageSource);
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
            Func<Container, T> container,
            Func<Environment, T> environment,
            Func<Stack, T> stack,
            Func<StackBuild, T> stackBuild,
            Func<Image, T> image,
            Func<ImageSource, T> imageSource);

        [JsonConverter(typeof(UnionTypeCaseConverter<ContainerCase, Container>))]
        private sealed class ContainerCase : PipelineIncludesComponents, ICaseValue<ContainerCase, Container>
        {
            public Container _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Environment, T> environment,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource)
            {
                return container(_value);
            }

            public ContainerCase Set(Container value)
            {
                _value = value;
                return this;
            }

            public Container Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<EnvironmentCase, Environment>))]
        private sealed class EnvironmentCase : PipelineIncludesComponents, ICaseValue<EnvironmentCase, Environment>
        {
            public Environment _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Environment, T> environment,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource)
            {
                return environment(_value);
            }

            public EnvironmentCase Set(Environment value)
            {
                _value = value;
                return this;
            }

            public Environment Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<StackCase, Stack>))]
        private sealed class StackCase : PipelineIncludesComponents, ICaseValue<StackCase, Stack>
        {
            public Stack _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Environment, T> environment,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource)
            {
                return stack(_value);
            }

            public StackCase Set(Stack value)
            {
                _value = value;
                return this;
            }

            public Stack Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<StackBuildCase, StackBuild>))]
        private sealed class StackBuildCase : PipelineIncludesComponents, ICaseValue<StackBuildCase, StackBuild>
        {
            public StackBuild _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Environment, T> environment,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource)
            {
                return stackBuild(_value);
            }

            public StackBuildCase Set(StackBuild value)
            {
                _value = value;
                return this;
            }

            public StackBuild Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ImageCase, Image>))]
        private sealed class ImageCase : PipelineIncludesComponents, ICaseValue<ImageCase, Image>
        {
            public Image _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Environment, T> environment,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource)
            {
                return image(_value);
            }

            public ImageCase Set(Image value)
            {
                _value = value;
                return this;
            }

            public Image Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ImageSourceCase, ImageSource>))]
        private sealed class ImageSourceCase : PipelineIncludesComponents, ICaseValue<ImageSourceCase, ImageSource>
        {
            public ImageSource _value;

            public override T Match<T>(
                Func<Container, T> container,
                Func<Environment, T> environment,
                Func<Stack, T> stack,
                Func<StackBuild, T> stackBuild,
                Func<Image, T> image,
                Func<ImageSource, T> imageSource)
            {
                return imageSource(_value);
            }

            public ImageSourceCase Set(ImageSource value)
            {
                _value = value;
                return this;
            }

            public ImageSource Get()
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