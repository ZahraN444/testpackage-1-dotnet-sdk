// <copyright file="ImagesControllerTest.cs" company="APIMatic">
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
    /// ImagesControllerTest.
    /// </summary>
    [TestFixture]
    public class ImagesControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private ImagesController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.ImagesController;
        }

        /// <summary>
        /// Requires the `images-view` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetImages()
        {
            // Parameters for the API call
            List<Standard.Models.Meta24Enum> meta = null;
            List<Standard.Models.Include21Enum> include = null;
            Standard.Models.Filter18 filter = null;
            List<string> sort = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1ImagesResponse result = null;
            try
            {
                result = await this.controller.GetImagesAsync(meta, include, filter, sort, page);
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
        /// Requires the `images-manage` capability..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateImage()
        {
            // Parameters for the API call
            Standard.Models.V1ImagesRequest body = null;

            // Perform API call
            Standard.Models.V1ImagesResponse1 result = null;
            try
            {
                result = await this.controller.CreateImageAsync(body);
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

        /// <summary>
        /// Used to perform different actions on a given image. 
        ///
        ///Requires the `images-manage` capability.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestCreateImagesJob()
        {
            // Parameters for the API call
            Standard.Models.V1ImagesTasksRequest body = null;

            // Perform API call
            Standard.Models.V1ImagesTasksResponse result = null;
            try
            {
                result = await this.controller.CreateImagesJobAsync(body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(202, HttpCallBack.Response.StatusCode, "Status should be 202");

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