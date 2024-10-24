// <copyright file="PipelinesControllerTest.cs" company="APIMatic">
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
    /// PipelinesControllerTest.
    /// </summary>
    [TestFixture]
    public class PipelinesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private PipelinesController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.PipelinesController;
        }

        /// <summary>
        /// Requires the `pipelines-view` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetPipelines()
        {
            // Parameters for the API call
            List<Standard.Models.Include38Enum> include = null;
            Standard.Models.Filter31 filter = null;
            List<string> sort = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1PipelinesResponse result = null;
            try
            {
                result = await this.controller.GetPipelinesAsync(include, filter, sort, page);
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
        /// Requires the `pipelines-manage` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreatePipeline()
        {
            // Parameters for the API call
            Standard.Models.V1PipelinesRequest body = null;

            // Perform API call
            Standard.Models.V1PipelinesResponse1 result = null;
            try
            {
                result = await this.controller.CreatePipelineAsync(body);
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