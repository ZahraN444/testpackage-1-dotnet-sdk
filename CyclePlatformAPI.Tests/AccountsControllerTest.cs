// <copyright file="AccountsControllerTest.cs" company="APIMatic">
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
    /// AccountsControllerTest.
    /// </summary>
    [TestFixture]
    public class AccountsControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private AccountsController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.AccountsController;
        }

        /// <summary>
        /// Gets the Account associated with the authenticated bearer token..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetAccount()
        {
            // Perform API call
            Standard.Models.AccountResponse result = null;
            try
            {
                result = await this.controller.GetAccountAsync();
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
        /// Updates the Account..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestUpdateAccount()
        {
            // Parameters for the API call
            Standard.Models.V1AccountRequest body = null;

            // Perform API call
            Standard.Models.V1AccountResponse result = null;
            try
            {
                result = await this.controller.UpdateAccountAsync(body);
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
        /// Puts the Account into a `deleted` state. This will fail if the Account is the current `OWNER` of an active Hub..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDeleteAccount()
        {
            // Perform API call
            Standard.Models.V1AccountResponse1 result = null;
            try
            {
                result = await this.controller.DeleteAccountAsync();
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

        /// <summary>
        /// Lists the pending Hub Memberships (also known as Invites) associated with the Account..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetAccountInvites()
        {
            // Parameters for the API call
            List<Standard.Models.Meta1Enum> meta = null;
            List<Standard.Models.IncludeEnum> include = null;
            List<string> sort = null;
            object filter = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1AccountInvitesResponse result = null;
            try
            {
                result = await this.controller.GetAccountInvitesAsync(meta, include, sort, filter, page);
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
        /// Lists the Hub Memberships for a given account..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetAccountMemberships()
        {
            // Parameters for the API call
            List<Standard.Models.IncludeEnum> include = null;
            List<string> sort = null;
            object filter = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.V1AccountMembershipsResponse result = null;
            try
            {
                result = await this.controller.GetAccountMembershipsAsync(include, sort, filter, page);
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
        /// Lists logins associated with a given account..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetAccountLogins()
        {
            // Parameters for the API call
            List<string> sort = null;
            object filter = null;
            Standard.Models.Page page = null;

            // Perform API call
            Standard.Models.AccountLoginsResponse result = null;
            try
            {
                result = await this.controller.GetAccountLoginsAsync(sort, filter, page);
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
        /// Change the password on the Account. Requires the current password of the Account to be submitted..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestChangePassword()
        {
            // Parameters for the API call
            Standard.Models.V1AccountPasswordRequest body = null;

            // Perform API call
            Standard.Models.V1AccountPasswordResponse result = null;
            try
            {
                result = await this.controller.ChangePasswordAsync(body);
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
        /// Initiate a password reset for the Account. A confirmation email will be sent to the email associated with the Account, and the token in the email must be passed in a second call to this endpoint..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestResetPassword()
        {
            // Parameters for the API call
            ResetPasswordBody body = null;

            // Perform API call
            Standard.Models.V1AccountResetPasswordResponse result = null;
            try
            {
                result = await this.controller.ResetPasswordAsync(body);
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
        /// Gets the barcode and secret required for setting up two-factor authentication for the Account..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestGetTwoFactorAuthSetup()
        {
            // Perform API call
            Standard.Models.V1Account2faSetupResponse result = null;
            try
            {
                result = await this.controller.GetTwoFactorAuthSetupAsync();
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
        /// Enables two-factor auth for the Account. Retrieve the token from an authenticator app using the secret from `getTwoFactorAuthSetup`..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestEnableTwoFactorAuth()
        {
            // Parameters for the API call
            Standard.Models.V1Account2faSetupRequest body = null;

            // Perform API call
            Standard.Models.V1Account2faSetupResponse1 result = null;
            try
            {
                result = await this.controller.EnableTwoFactorAuthAsync(body);
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
        /// Disables two-factor auth for the account..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDisableTwoFactorAuth()
        {
            // Parameters for the API call
            Standard.Models.V1Account2faDisableRequest body = null;

            // Perform API call
            Standard.Models.V1Account2faDisableResponse result = null;
            try
            {
                result = await this.controller.DisableTwoFactorAuthAsync(body);
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
        /// Returns a new two-factor auth setup to reset the Account's two-factor auth..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRecoverTwoFactorAuth()
        {
            // Parameters for the API call
            Standard.Models.V1Account2faRecoverRequest body = null;

            // Perform API call
            Standard.Models.V1Account2faRecoverResponse result = null;
            try
            {
                result = await this.controller.RecoverTwoFactorAuthAsync(body);
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