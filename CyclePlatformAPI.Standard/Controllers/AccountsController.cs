// <copyright file="AccountsController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using CyclePlatformAPI.Standard;
using CyclePlatformAPI.Standard.Exceptions;
using CyclePlatformAPI.Standard.Http.Client;
using CyclePlatformAPI.Standard.Models.Containers;
using CyclePlatformAPI.Standard.Utilities;
using Newtonsoft.Json.Converters;
using System.Net.Http;

namespace CyclePlatformAPI.Standard.Controllers
{
    /// <summary>
    /// AccountsController.
    /// </summary>
    public class AccountsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountsController"/> class.
        /// </summary>
        internal AccountsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Gets the Account associated with the authenticated bearer token.
        /// </summary>
        /// <returns>Returns the Models.AccountResponse response from the API call.</returns>
        public Models.AccountResponse GetAccount()
            => CoreHelper.RunTask(GetAccountAsync());

        /// <summary>
        /// Gets the Account associated with the authenticated bearer token.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountResponse response from the API call.</returns>
        public async Task<Models.AccountResponse> GetAccountAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/account")
                  .WithAuth("bearerAuth"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Updates the Account.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1AccountResponse response from the API call.</returns>
        public Models.V1AccountResponse UpdateAccount(
                Models.V1AccountRequest body = null)
            => CoreHelper.RunTask(UpdateAccountAsync(body));

        /// <summary>
        /// Updates the Account.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1AccountResponse response from the API call.</returns>
        public async Task<Models.V1AccountResponse> UpdateAccountAsync(
                Models.V1AccountRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1AccountResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/account")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Puts the Account into a `deleted` state. This will fail if the Account is the current `OWNER` of an active Hub.
        /// </summary>
        /// <returns>Returns the Models.V1AccountResponse1 response from the API call.</returns>
        public Models.V1AccountResponse1 DeleteAccount()
            => CoreHelper.RunTask(DeleteAccountAsync());

        /// <summary>
        /// Puts the Account into a `deleted` state. This will fail if the Account is the current `OWNER` of an active Hub.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1AccountResponse1 response from the API call.</returns>
        public async Task<Models.V1AccountResponse1> DeleteAccountAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1AccountResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Delete, "/v1/account")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  ))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists the pending Hub Memberships (also known as Invites) associated with the Account.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: Example: .</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1AccountInvitesResponse response from the API call.</returns>
        public Models.V1AccountInvitesResponse GetAccountInvites(
                List<Models.Meta1Enum> meta = null,
                List<Models.IncludeEnum> include = null,
                List<string> sort = null,
                object filter = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetAccountInvitesAsync(meta, include, sort, filter, page));

        /// <summary>
        /// Lists the pending Hub Memberships (also known as Invites) associated with the Account.
        /// </summary>
        /// <param name="meta">Optional parameter: A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled..</param>
        /// <param name="include">Optional parameter: Example: .</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1AccountInvitesResponse response from the API call.</returns>
        public async Task<Models.V1AccountInvitesResponse> GetAccountInvitesAsync(
                List<Models.Meta1Enum> meta = null,
                List<Models.IncludeEnum> include = null,
                List<string> sort = null,
                object filter = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1AccountInvitesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/account/invites")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("meta", meta?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Accept/reject a pending Invite to join a Hub.
        /// </summary>
        /// <param name="inviteId">Required parameter: The ID of the given Invite..</param>
        /// <param name="include">Optional parameter: Example: .</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1AccountInvitesResponse1 response from the API call.</returns>
        public Models.V1AccountInvitesResponse1 UpdateAccountInvite(
                string inviteId,
                List<Models.IncludeEnum> include = null,
                Models.V1AccountInvitesRequest body = null)
            => CoreHelper.RunTask(UpdateAccountInviteAsync(inviteId, include, body));

        /// <summary>
        /// Accept/reject a pending Invite to join a Hub.
        /// </summary>
        /// <param name="inviteId">Required parameter: The ID of the given Invite..</param>
        /// <param name="include">Optional parameter: Example: .</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1AccountInvitesResponse1 response from the API call.</returns>
        public async Task<Models.V1AccountInvitesResponse1> UpdateAccountInviteAsync(
                string inviteId,
                List<Models.IncludeEnum> include = null,
                Models.V1AccountInvitesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1AccountInvitesResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/account/invites/{inviteId}")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("inviteId", inviteId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists the Hub Memberships for a given account.
        /// </summary>
        /// <param name="include">Optional parameter: Example: .</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.V1AccountMembershipsResponse response from the API call.</returns>
        public Models.V1AccountMembershipsResponse GetAccountMemberships(
                List<Models.IncludeEnum> include = null,
                List<string> sort = null,
                object filter = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetAccountMembershipsAsync(include, sort, filter, page));

        /// <summary>
        /// Lists the Hub Memberships for a given account.
        /// </summary>
        /// <param name="include">Optional parameter: Example: .</param>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1AccountMembershipsResponse response from the API call.</returns>
        public async Task<Models.V1AccountMembershipsResponse> GetAccountMembershipsAsync(
                List<Models.IncludeEnum> include = null,
                List<string> sort = null,
                object filter = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1AccountMembershipsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/account/memberships")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("include", include?.Select(a => ApiHelper.JsonSerialize(a).Trim('\"')).ToList()))
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Lists logins associated with a given account.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <returns>Returns the Models.AccountLoginsResponse response from the API call.</returns>
        public Models.AccountLoginsResponse GetAccountLogins(
                List<string> sort = null,
                object filter = null,
                Models.Page page = null)
            => CoreHelper.RunTask(GetAccountLoginsAsync(sort, filter, page));

        /// <summary>
        /// Lists logins associated with a given account.
        /// </summary>
        /// <param name="sort">Optional parameter: An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`..</param>
        /// <param name="filter">Optional parameter: Example: .</param>
        /// <param name="page"><![CDATA[Optional parameter: In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2`.]]></param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountLoginsResponse response from the API call.</returns>
        public async Task<Models.AccountLoginsResponse> GetAccountLoginsAsync(
                List<string> sort = null,
                object filter = null,
                Models.Page page = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountLoginsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/account/logins")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("sort", sort))
                      .Query(_query => _query.Setup("filter", filter))
                      .Query(_query => _query.Setup("page", page))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Change the password on the Account. Requires the current password of the Account to be submitted.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1AccountPasswordResponse response from the API call.</returns>
        public Models.V1AccountPasswordResponse ChangePassword(
                Models.V1AccountPasswordRequest body = null)
            => CoreHelper.RunTask(ChangePasswordAsync(body));

        /// <summary>
        /// Change the password on the Account. Requires the current password of the Account to be submitted.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1AccountPasswordResponse response from the API call.</returns>
        public async Task<Models.V1AccountPasswordResponse> ChangePasswordAsync(
                Models.V1AccountPasswordRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1AccountPasswordResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(new HttpMethod("PATCH"), "/v1/account/password")
                  .WithAuth("bearerAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Initiate a password reset for the Account. A confirmation email will be sent to the email associated with the Account, and the token in the email must be passed in a second call to this endpoint.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1AccountResetPasswordResponse response from the API call.</returns>
        public Models.V1AccountResetPasswordResponse ResetPassword(
                ResetPasswordBody body = null)
            => CoreHelper.RunTask(ResetPasswordAsync(body));

        /// <summary>
        /// Initiate a password reset for the Account. A confirmation email will be sent to the email associated with the Account, and the token in the email must be passed in a second call to this endpoint.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1AccountResetPasswordResponse response from the API call.</returns>
        public async Task<Models.V1AccountResetPasswordResponse> ResetPasswordAsync(
                ResetPasswordBody body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1AccountResetPasswordResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/account/reset-password")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Gets the barcode and secret required for setting up two-factor authentication for the Account.
        /// </summary>
        /// <returns>Returns the Models.V1Account2faSetupResponse response from the API call.</returns>
        public Models.V1Account2faSetupResponse GetTwoFactorAuthSetup()
            => CoreHelper.RunTask(GetTwoFactorAuthSetupAsync());

        /// <summary>
        /// Gets the barcode and secret required for setting up two-factor authentication for the Account.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1Account2faSetupResponse response from the API call.</returns>
        public async Task<Models.V1Account2faSetupResponse> GetTwoFactorAuthSetupAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1Account2faSetupResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/v1/account/2fa/setup")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  ))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Enables two-factor auth for the Account. Retrieve the token from an authenticator app using the secret from `getTwoFactorAuthSetup`.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1Account2faSetupResponse1 response from the API call.</returns>
        public Models.V1Account2faSetupResponse1 EnableTwoFactorAuth(
                Models.V1Account2faSetupRequest body = null)
            => CoreHelper.RunTask(EnableTwoFactorAuthAsync(body));

        /// <summary>
        /// Enables two-factor auth for the Account. Retrieve the token from an authenticator app using the secret from `getTwoFactorAuthSetup`.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1Account2faSetupResponse1 response from the API call.</returns>
        public async Task<Models.V1Account2faSetupResponse1> EnableTwoFactorAuthAsync(
                Models.V1Account2faSetupRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1Account2faSetupResponse1>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/account/2fa/setup")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Disables two-factor auth for the account.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1Account2faDisableResponse response from the API call.</returns>
        public Models.V1Account2faDisableResponse DisableTwoFactorAuth(
                Models.V1Account2faDisableRequest body = null)
            => CoreHelper.RunTask(DisableTwoFactorAuthAsync(body));

        /// <summary>
        /// Disables two-factor auth for the account.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1Account2faDisableResponse response from the API call.</returns>
        public async Task<Models.V1Account2faDisableResponse> DisableTwoFactorAuthAsync(
                Models.V1Account2faDisableRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1Account2faDisableResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/account/2fa/disable")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a new two-factor auth setup to reset the Account's two-factor auth.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.V1Account2faRecoverResponse response from the API call.</returns>
        public Models.V1Account2faRecoverResponse RecoverTwoFactorAuth(
                Models.V1Account2faRecoverRequest body = null)
            => CoreHelper.RunTask(RecoverTwoFactorAuthAsync(body));

        /// <summary>
        /// Returns a new two-factor auth setup to reset the Account's two-factor auth.
        /// </summary>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.V1Account2faRecoverResponse response from the API call.</returns>
        public async Task<Models.V1Account2faRecoverResponse> RecoverTwoFactorAuthAsync(
                Models.V1Account2faRecoverRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.V1Account2faRecoverResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/v1/account/2fa/recover")
                  .WithAndAuth(_andAuth => _andAuth
                      .Add("bearerAuth")
                      .Add("hubAuth")
                  )
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("0", CreateErrorCase("General error response from the platform", (_reason, _context) => new ErrorEnvelopeException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}