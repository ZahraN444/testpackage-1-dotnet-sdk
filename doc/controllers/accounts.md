# Accounts

```csharp
AccountsController accountsController = client.AccountsController;
```

## Class Name

`AccountsController`

## Methods

* [Get Account](../../doc/controllers/accounts.md#get-account)
* [Update Account](../../doc/controllers/accounts.md#update-account)
* [Delete Account](../../doc/controllers/accounts.md#delete-account)
* [Get Account Invites](../../doc/controllers/accounts.md#get-account-invites)
* [Update Account Invite](../../doc/controllers/accounts.md#update-account-invite)
* [Get Account Memberships](../../doc/controllers/accounts.md#get-account-memberships)
* [Get Account Logins](../../doc/controllers/accounts.md#get-account-logins)
* [Change Password](../../doc/controllers/accounts.md#change-password)
* [Reset Password](../../doc/controllers/accounts.md#reset-password)
* [Get Two Factor Auth Setup](../../doc/controllers/accounts.md#get-two-factor-auth-setup)
* [Enable Two Factor Auth](../../doc/controllers/accounts.md#enable-two-factor-auth)
* [Disable Two Factor Auth](../../doc/controllers/accounts.md#disable-two-factor-auth)
* [Recover Two Factor Auth](../../doc/controllers/accounts.md#recover-two-factor-auth)


# Get Account

Gets the Account associated with the authenticated bearer token.

```csharp
GetAccountAsync()
```

## Response Type

[`Task<Models.AccountResponse>`](../../doc/models/account-response.md)

## Example Usage

```csharp
try
{
    AccountResponse result = await accountsController.GetAccountAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | General error response from the platform | [`ErrorEnvelopeException`](../../doc/models/error-envelope-exception.md) |


# Update Account

Updates the Account.

```csharp
UpdateAccountAsync(
    Models.V1AccountRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1AccountRequest`](../../doc/models/v1-account-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.V1AccountResponse>`](../../doc/models/v1-account-response.md)

## Example Usage

```csharp
try
{
    V1AccountResponse result = await accountsController.UpdateAccountAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | General error response from the platform | [`ErrorEnvelopeException`](../../doc/models/error-envelope-exception.md) |


# Delete Account

Puts the Account into a `deleted` state. This will fail if the Account is the current `OWNER` of an active Hub.

```csharp
DeleteAccountAsync()
```

## Response Type

[`Task<Models.V1AccountResponse1>`](../../doc/models/v1-account-response-1.md)

## Example Usage

```csharp
try
{
    V1AccountResponse1 result = await accountsController.DeleteAccountAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | General error response from the platform | [`ErrorEnvelopeException`](../../doc/models/error-envelope-exception.md) |


# Get Account Invites

Lists the pending Hub Memberships (also known as Invites) associated with the Account.

```csharp
GetAccountInvitesAsync(
    List<Models.Meta1Enum> meta = null,
    List<Models.IncludeEnum> include = null,
    List<string> sort = null,
    object filter = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `meta` | [`List<Meta1Enum>`](../../doc/models/meta-1-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `include` | [`List<IncludeEnum>`](../../doc/models/include-enum.md) | Query, Optional | - |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `filter` | `object` | Query, Optional | - |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1AccountInvitesResponse>`](../../doc/models/v1-account-invites-response.md)

## Example Usage

```csharp
try
{
    V1AccountInvitesResponse result = await accountsController.GetAccountInvitesAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | General error response from the platform | [`ErrorEnvelopeException`](../../doc/models/error-envelope-exception.md) |


# Update Account Invite

Accept/reject a pending Invite to join a Hub.

```csharp
UpdateAccountInviteAsync(
    string inviteId,
    List<Models.IncludeEnum> include = null,
    Models.V1AccountInvitesRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `inviteId` | `string` | Template, Required | The ID of the given Invite. |
| `include` | [`List<IncludeEnum>`](../../doc/models/include-enum.md) | Query, Optional | - |
| `body` | [`V1AccountInvitesRequest`](../../doc/models/v1-account-invites-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.V1AccountInvitesResponse1>`](../../doc/models/v1-account-invites-response-1.md)

## Example Usage

```csharp
string inviteId = "inviteId8";
try
{
    V1AccountInvitesResponse1 result = await accountsController.UpdateAccountInviteAsync(inviteId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | General error response from the platform | [`ErrorEnvelopeException`](../../doc/models/error-envelope-exception.md) |


# Get Account Memberships

Lists the Hub Memberships for a given account.

```csharp
GetAccountMembershipsAsync(
    List<Models.IncludeEnum> include = null,
    List<string> sort = null,
    object filter = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `include` | [`List<IncludeEnum>`](../../doc/models/include-enum.md) | Query, Optional | - |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `filter` | `object` | Query, Optional | - |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1AccountMembershipsResponse>`](../../doc/models/v1-account-memberships-response.md)

## Example Usage

```csharp
try
{
    V1AccountMembershipsResponse result = await accountsController.GetAccountMembershipsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | General error response from the platform | [`ErrorEnvelopeException`](../../doc/models/error-envelope-exception.md) |


# Get Account Logins

Lists logins associated with a given account.

```csharp
GetAccountLoginsAsync(
    List<string> sort = null,
    object filter = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `filter` | `object` | Query, Optional | - |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.AccountLoginsResponse>`](../../doc/models/account-logins-response.md)

## Example Usage

```csharp
try
{
    AccountLoginsResponse result = await accountsController.GetAccountLoginsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | General error response from the platform | [`ErrorEnvelopeException`](../../doc/models/error-envelope-exception.md) |


# Change Password

Change the password on the Account. Requires the current password of the Account to be submitted.

```csharp
ChangePasswordAsync(
    Models.V1AccountPasswordRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1AccountPasswordRequest`](../../doc/models/v1-account-password-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.V1AccountPasswordResponse>`](../../doc/models/v1-account-password-response.md)

## Example Usage

```csharp
try
{
    V1AccountPasswordResponse result = await accountsController.ChangePasswordAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | General error response from the platform | [`ErrorEnvelopeException`](../../doc/models/error-envelope-exception.md) |


# Reset Password

Initiate a password reset for the Account. A confirmation email will be sent to the email associated with the Account, and the token in the email must be passed in a second call to this endpoint.

```csharp
ResetPasswordAsync(
    ResetPasswordBody body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ResetPasswordBody`](../../doc/models/containers/reset-password-body.md) | Body, Optional | This is a container for one-of cases. |

## Response Type

[`Task<Models.V1AccountResetPasswordResponse>`](../../doc/models/v1-account-reset-password-response.md)

## Example Usage

```csharp
try
{
    V1AccountResetPasswordResponse result = await accountsController.ResetPasswordAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | General error response from the platform | [`ErrorEnvelopeException`](../../doc/models/error-envelope-exception.md) |


# Get Two Factor Auth Setup

Gets the barcode and secret required for setting up two-factor authentication for the Account.

```csharp
GetTwoFactorAuthSetupAsync()
```

## Response Type

[`Task<Models.V1Account2faSetupResponse>`](../../doc/models/v1-account-2-fa-setup-response.md)

## Example Usage

```csharp
try
{
    V1Account2faSetupResponse result = await accountsController.GetTwoFactorAuthSetupAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | General error response from the platform | [`ErrorEnvelopeException`](../../doc/models/error-envelope-exception.md) |


# Enable Two Factor Auth

Enables two-factor auth for the Account. Retrieve the token from an authenticator app using the secret from `getTwoFactorAuthSetup`.

```csharp
EnableTwoFactorAuthAsync(
    Models.V1Account2faSetupRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1Account2faSetupRequest`](../../doc/models/v1-account-2-fa-setup-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.V1Account2faSetupResponse1>`](../../doc/models/v1-account-2-fa-setup-response-1.md)

## Example Usage

```csharp
try
{
    V1Account2faSetupResponse1 result = await accountsController.EnableTwoFactorAuthAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | General error response from the platform | [`ErrorEnvelopeException`](../../doc/models/error-envelope-exception.md) |


# Disable Two Factor Auth

Disables two-factor auth for the account.

```csharp
DisableTwoFactorAuthAsync(
    Models.V1Account2faDisableRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1Account2faDisableRequest`](../../doc/models/v1-account-2-fa-disable-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.V1Account2faDisableResponse>`](../../doc/models/v1-account-2-fa-disable-response.md)

## Example Usage

```csharp
try
{
    V1Account2faDisableResponse result = await accountsController.DisableTwoFactorAuthAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | General error response from the platform | [`ErrorEnvelopeException`](../../doc/models/error-envelope-exception.md) |


# Recover Two Factor Auth

Returns a new two-factor auth setup to reset the Account's two-factor auth.

```csharp
RecoverTwoFactorAuthAsync(
    Models.V1Account2faRecoverRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1Account2faRecoverRequest`](../../doc/models/v1-account-2-fa-recover-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.V1Account2faRecoverResponse>`](../../doc/models/v1-account-2-fa-recover-response.md)

## Example Usage

```csharp
try
{
    V1Account2faRecoverResponse result = await accountsController.RecoverTwoFactorAuthAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | General error response from the platform | [`ErrorEnvelopeException`](../../doc/models/error-envelope-exception.md) |

