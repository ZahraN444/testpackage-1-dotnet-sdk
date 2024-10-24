// <copyright file="AccountLoginsResponseData.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<AccountLoginsResponseData>),
        new Type[] {
            typeof(AccountEmployeeLoginCase),
            typeof(AccountPasswordLoginCase)
        },
        true
    )]
    public abstract class AccountLoginsResponseData
    {
        /// <summary>
        /// This is AccountEmployeeLogin case.
        /// </summary>
        /// <returns>
        /// The AccountLoginsResponseData instance, wrapping the provided AccountEmployeeLogin value.
        /// </returns>
        public static AccountLoginsResponseData FromAccountEmployeeLogin(AccountEmployeeLogin accountEmployeeLogin)
        {
            return new AccountEmployeeLoginCase().Set(accountEmployeeLogin);
        }

        /// <summary>
        /// This is AccountPasswordLogin case.
        /// </summary>
        /// <returns>
        /// The AccountLoginsResponseData instance, wrapping the provided AccountPasswordLogin value.
        /// </returns>
        public static AccountLoginsResponseData FromAccountPasswordLogin(AccountPasswordLogin accountPasswordLogin)
        {
            return new AccountPasswordLoginCase().Set(accountPasswordLogin);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<AccountEmployeeLogin, T> accountEmployeeLogin, Func<AccountPasswordLogin, T> accountPasswordLogin);

        [JsonConverter(typeof(UnionTypeCaseConverter<AccountEmployeeLoginCase, AccountEmployeeLogin>))]
        private sealed class AccountEmployeeLoginCase : AccountLoginsResponseData, ICaseValue<AccountEmployeeLoginCase, AccountEmployeeLogin>
        {
            public AccountEmployeeLogin _value;

            public override T Match<T>(Func<AccountEmployeeLogin, T> accountEmployeeLogin, Func<AccountPasswordLogin, T> accountPasswordLogin)
            {
                return accountEmployeeLogin(_value);
            }

            public AccountEmployeeLoginCase Set(AccountEmployeeLogin value)
            {
                _value = value;
                return this;
            }

            public AccountEmployeeLogin Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<AccountPasswordLoginCase, AccountPasswordLogin>))]
        private sealed class AccountPasswordLoginCase : AccountLoginsResponseData, ICaseValue<AccountPasswordLoginCase, AccountPasswordLogin>
        {
            public AccountPasswordLogin _value;

            public override T Match<T>(Func<AccountEmployeeLogin, T> accountEmployeeLogin, Func<AccountPasswordLogin, T> accountPasswordLogin)
            {
                return accountPasswordLogin(_value);
            }

            public AccountPasswordLoginCase Set(AccountPasswordLogin value)
            {
                _value = value;
                return this;
            }

            public AccountPasswordLogin Get()
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