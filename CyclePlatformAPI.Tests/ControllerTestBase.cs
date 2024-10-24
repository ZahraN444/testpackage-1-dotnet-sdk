// <copyright file="ControllerTestBase.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyclePlatformAPI.Standard;
using CyclePlatformAPI.Standard.Authentication;
using CyclePlatformAPI.Standard.Http.Client;
using CyclePlatformAPI.Standard.Models;
using CyclePlatformAPI.Standard.Models.Containers;
using NUnit.Framework;

namespace CyclePlatformAPI.Tests
{
    /// <summary>
    /// ControllerTestBase Class.
    /// </summary>
    [TestFixture]
    public class ControllerTestBase
    {
        /// <summary>
        /// Assert precision.
        /// </summary>
        protected const double AssertPrecision = 0.1;

        /// <summary>
        /// Gets HttpCallBackHandler.
        /// </summary>
        internal HttpCallback HttpCallBack { get; private set; } = new HttpCallback();

        /// <summary>
        /// Gets CyclePlatformAPIClient Client.
        /// </summary>
        protected CyclePlatformAPIClient Client { get; private set; }

        /// <summary>
        /// Set up the client.
        /// </summary>
        [OneTimeSetUp]
        public void SetUp()
        {
            CyclePlatformAPIClient config = CyclePlatformAPIClient.CreateFromEnvironment();
            this.Client = config.ToBuilder()
                .HttpCallback(HttpCallBack)
                .Build();
        }
    }
}