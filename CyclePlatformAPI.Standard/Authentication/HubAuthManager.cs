// <copyright file="HubAuthManager.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CyclePlatformAPI.Standard.Http.Request;
using APIMatic.Core.Authentication;

namespace CyclePlatformAPI.Standard.Authentication
{
    /// <summary>
    /// HubAuthManager Class.
    /// </summary>
    internal class HubAuthManager : AuthManager, IHubAuthCredentials
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HubAuthManager"/> class.
        /// </summary>
        /// <param name="hubAuth">HubAuth.</param>
        public HubAuthManager(HubAuthModel hubAuthModel)
        {
            XHubId = hubAuthModel?.XHubId;
            Parameters(paramBuilder => paramBuilder
                .Header(header => header.Setup("X-Hub-Id", XHubId).Required())
            );
        }

        /// <summary>
        /// Gets string value for xHubId.
        /// </summary>
        public string XHubId { get; }

        /// <summary>
        /// Check if credentials match.
        /// </summary>
        /// <param name="xHubId"> The string value for credentials.</param>
        /// <returns> True if credentials matched.</returns>
        public bool Equals(string xHubId)
        {
            return xHubId.Equals(this.XHubId);
        }
    }

    public sealed class HubAuthModel
    {
        internal HubAuthModel()
        {
        }

        internal string XHubId { get; set; }

        /// <summary>
        /// Creates an object of the HubAuthModel using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            return new Builder(XHubId);
        }

        /// <summary>
        /// Builder class for HubAuthModel.
        /// </summary>
        public class Builder
        {
            private string xHubId;

            public Builder(string xHubId)
            {
                this.xHubId = xHubId ?? throw new ArgumentNullException(nameof(xHubId));
            }

            /// <summary>
            /// Sets XHubId.
            /// </summary>
            /// <param name="xHubId">XHubId.</param>
            /// <returns>Builder.</returns>
            public Builder XHubId(string xHubId)
            {
                this.xHubId = xHubId ?? throw new ArgumentNullException(nameof(xHubId));
                return this;
            }


            /// <summary>
            /// Creates an object of the HubAuthModel using the values provided for the builder.
            /// </summary>
            /// <returns>HubAuthModel.</returns>
            public HubAuthModel Build()
            {
                return new HubAuthModel()
                {
                    XHubId = this.xHubId
                };
            }
        }
    }
    
}