// <copyright file="RegistryAuth.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<RegistryAuth>),
        new Type[] {
            typeof(RegistryAuthUserCase),
            typeof(RegistryAuthProviderCase),
            typeof(RegistryAuthWebhookCase)
        },
        new string[] {
            "user",
            "provider",
            "webhook"
        },
        "type",
        true
    )]
    public abstract class RegistryAuth
    {
        /// <summary>
        /// This is RegistryAuthUser case.
        /// </summary>
        /// <returns>
        /// The RegistryAuth instance, wrapping the provided RegistryAuthUser value.
        /// </returns>
        public static RegistryAuth FromRegistryAuthUser(RegistryAuthUser registryAuthUser)
        {
            return new RegistryAuthUserCase().Set(registryAuthUser);
        }

        /// <summary>
        /// This is RegistryAuthProvider case.
        /// </summary>
        /// <returns>
        /// The RegistryAuth instance, wrapping the provided RegistryAuthProvider value.
        /// </returns>
        public static RegistryAuth FromRegistryAuthProvider(RegistryAuthProvider registryAuthProvider)
        {
            return new RegistryAuthProviderCase().Set(registryAuthProvider);
        }

        /// <summary>
        /// This is RegistryAuthWebhook case.
        /// </summary>
        /// <returns>
        /// The RegistryAuth instance, wrapping the provided RegistryAuthWebhook value.
        /// </returns>
        public static RegistryAuth FromRegistryAuthWebhook(RegistryAuthWebhook registryAuthWebhook)
        {
            return new RegistryAuthWebhookCase().Set(registryAuthWebhook);
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
            Func<RegistryAuthUser, T> registryAuthUser,
            Func<RegistryAuthProvider, T> registryAuthProvider,
            Func<RegistryAuthWebhook, T> registryAuthWebhook);

        [JsonConverter(typeof(UnionTypeCaseConverter<RegistryAuthUserCase, RegistryAuthUser>))]
        private sealed class RegistryAuthUserCase : RegistryAuth, ICaseValue<RegistryAuthUserCase, RegistryAuthUser>
        {
            public RegistryAuthUser _value;

            public override T Match<T>(
                Func<RegistryAuthUser, T> registryAuthUser,
                Func<RegistryAuthProvider, T> registryAuthProvider,
                Func<RegistryAuthWebhook, T> registryAuthWebhook)
            {
                return registryAuthUser(_value);
            }

            public RegistryAuthUserCase Set(RegistryAuthUser value)
            {
                _value = value;
                return this;
            }

            public RegistryAuthUser Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<RegistryAuthProviderCase, RegistryAuthProvider>))]
        private sealed class RegistryAuthProviderCase : RegistryAuth, ICaseValue<RegistryAuthProviderCase, RegistryAuthProvider>
        {
            public RegistryAuthProvider _value;

            public override T Match<T>(
                Func<RegistryAuthUser, T> registryAuthUser,
                Func<RegistryAuthProvider, T> registryAuthProvider,
                Func<RegistryAuthWebhook, T> registryAuthWebhook)
            {
                return registryAuthProvider(_value);
            }

            public RegistryAuthProviderCase Set(RegistryAuthProvider value)
            {
                _value = value;
                return this;
            }

            public RegistryAuthProvider Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<RegistryAuthWebhookCase, RegistryAuthWebhook>))]
        private sealed class RegistryAuthWebhookCase : RegistryAuth, ICaseValue<RegistryAuthWebhookCase, RegistryAuthWebhook>
        {
            public RegistryAuthWebhook _value;

            public override T Match<T>(
                Func<RegistryAuthUser, T> registryAuthUser,
                Func<RegistryAuthProvider, T> registryAuthProvider,
                Func<RegistryAuthWebhook, T> registryAuthWebhook)
            {
                return registryAuthWebhook(_value);
            }

            public RegistryAuthWebhookCase Set(RegistryAuthWebhook value)
            {
                _value = value;
                return this;
            }

            public RegistryAuthWebhook Get()
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