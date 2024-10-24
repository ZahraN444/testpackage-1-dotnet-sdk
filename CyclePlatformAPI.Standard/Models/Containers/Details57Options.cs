// <copyright file="Details57Options.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<Details57Options>),
        new Type[] {
            typeof(WebhookStepOptionsCase)
        },
        false
    )]
    public abstract class Details57Options
    {
        /// <summary>
        /// This is WebhookStepOptions case.
        /// </summary>
        /// <returns>
        /// The Details57Options instance, wrapping the provided WebhookStepOptions value.
        /// </returns>
        public static Details57Options FromWebhookStepOptions(WebhookStepOptions webhookStepOptions)
        {
            return new WebhookStepOptionsCase().Set(webhookStepOptions);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<WebhookStepOptions, T> webhookStepOptions);

        [JsonConverter(typeof(UnionTypeCaseConverter<WebhookStepOptionsCase, WebhookStepOptions>))]
        private sealed class WebhookStepOptionsCase : Details57Options, ICaseValue<WebhookStepOptionsCase, WebhookStepOptions>
        {
            public WebhookStepOptions _value;

            public override T Match<T>(Func<WebhookStepOptions, T> webhookStepOptions)
            {
                return webhookStepOptions(_value);
            }

            public WebhookStepOptionsCase Set(WebhookStepOptions value)
            {
                _value = value;
                return this;
            }

            public WebhookStepOptions Get()
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