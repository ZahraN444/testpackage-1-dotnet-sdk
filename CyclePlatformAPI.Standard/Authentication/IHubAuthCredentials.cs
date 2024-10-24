// <copyright file="IHubAuthCredentials.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;

namespace CyclePlatformAPI.Standard.Authentication
{
    /// <summary>
    /// Authentication configuration interface for HubAuth.
    /// </summary>
    public interface IHubAuthCredentials
    {
        /// <summary>
        /// Gets string value for xHubId.
        /// </summary>
        string XHubId { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="xHubId"> The string value for credentials.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string xHubId);
    }
}