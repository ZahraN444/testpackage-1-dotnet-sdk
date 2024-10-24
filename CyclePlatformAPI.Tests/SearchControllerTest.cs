// <copyright file="SearchControllerTest.cs" company="APIMatic">
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
    /// SearchControllerTest.
    /// </summary>
    [TestFixture]
    public class SearchControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private SearchController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.SearchController;
        }

        /// <summary>
        /// Gets a pre-built search index, containing IDs and basic information for many commonly used resources on the Hub.
        ///Can be used to build a 'quick search' functionality for referencing the most frequently used resources.
        ///
        ///Requires the `view` capability for each returned segment, i.e. to retrieve Containers, you must have `containers-view`.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetSearchIndex()
        {
            // Perform API call
            Standard.Models.V1SearchIndexResponse result = null;
            try
            {
                result = await this.controller.GetSearchIndexAsync();
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
    }
}