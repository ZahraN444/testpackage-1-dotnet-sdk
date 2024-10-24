// <copyright file="EnvironmentsControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using APIMatic.Core.Utilities;
using CyclePlatformAPI.Standard;
using CyclePlatformAPI.Standard.Controllers;
using CyclePlatformAPI.Standard.Exceptions;
using CyclePlatformAPI.Standard.Http.Client;
using CyclePlatformAPI.Standard.Http.Response;
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using NUnit.Framework;

namespace CyclePlatformAPI.Tests
{
    /// <summary>
    /// EnvironmentsControllerTest.
    /// </summary>
    [TestFixture]
    public class EnvironmentsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private EnvironmentsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.EnvironmentsController;
        }

        /// <summary>
        /// Requires the `environments-view` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetEnvironments()
        {
            // Parameters for the API call
            List<Standard.Models.Meta8Enum> meta = null;
            List<Standard.Models.Include2Enum> include = null;
            Standard.Models.Filter3 filter = null;
            List<string> sort = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1EnvironmentsResponse result = null;
            try
            {
                result = await this.controller.GetEnvironmentsAsync(meta, include, filter, sort, page);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// Requires the `environments-create` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateEnvironment()
        {
            // Parameters for the API call
            Standard.Models.V1EnvironmentsRequest body = null;

            // Perform API call
            Standard.Models.V1EnvironmentsResponse1 result = null;
            try
            {
                result = await this.controller.CreateEnvironmentAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(201, HttpCallBack.Response.StatusCode, "Status should be 201");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }
    }
}