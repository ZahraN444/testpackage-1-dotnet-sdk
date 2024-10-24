# Hubs

```csharp
HubsController hubsController = client.HubsController;
```

## Class Name

`HubsController`

## Methods

* [Get Hubs](../../doc/controllers/hubs.md#get-hubs)
* [Create Hub](../../doc/controllers/hubs.md#create-hub)
* [Get Hub](../../doc/controllers/hubs.md#get-hub)
* [Update Hub](../../doc/controllers/hubs.md#update-hub)
* [Delete Hub](../../doc/controllers/hubs.md#delete-hub)
* [Get Hub Capabilities](../../doc/controllers/hubs.md#get-hub-capabilities)
* [Get Hub Usage](../../doc/controllers/hubs.md#get-hub-usage)
* [Get Hub Activity](../../doc/controllers/hubs.md#get-hub-activity)
* [Delete Hub Invite](../../doc/controllers/hubs.md#delete-hub-invite)
* [Get Hub Invites](../../doc/controllers/hubs.md#get-hub-invites)
* [Create Hub Invite](../../doc/controllers/hubs.md#create-hub-invite)
* [Get Hub Members](../../doc/controllers/hubs.md#get-hub-members)
* [Get Hub Membership](../../doc/controllers/hubs.md#get-hub-membership)
* [Get Hub Member](../../doc/controllers/hubs.md#get-hub-member)
* [Update Hub Member](../../doc/controllers/hubs.md#update-hub-member)
* [Delete Hub Member](../../doc/controllers/hubs.md#delete-hub-member)
* [Get Hub Member Account](../../doc/controllers/hubs.md#get-hub-member-account)
* [Get Api Keys](../../doc/controllers/hubs.md#get-api-keys)
* [Create Api Key](../../doc/controllers/hubs.md#create-api-key)
* [Get API Key](../../doc/controllers/hubs.md#get-api-key)
* [Update API Key](../../doc/controllers/hubs.md#update-api-key)
* [Delete API Key](../../doc/controllers/hubs.md#delete-api-key)
* [Get Roles](../../doc/controllers/hubs.md#get-roles)
* [Create Role](../../doc/controllers/hubs.md#create-role)
* [Get Role](../../doc/controllers/hubs.md#get-role)
* [Update Role](../../doc/controllers/hubs.md#update-role)
* [Delete Role](../../doc/controllers/hubs.md#delete-role)
* [Get Integration](../../doc/controllers/hubs.md#get-integration)
* [Update Integration](../../doc/controllers/hubs.md#update-integration)
* [Delete Integration](../../doc/controllers/hubs.md#delete-integration)
* [Get Integrations](../../doc/controllers/hubs.md#get-integrations)
* [Create Integration](../../doc/controllers/hubs.md#create-integration)
* [Get Available Integrations](../../doc/controllers/hubs.md#get-available-integrations)
* [Create Integration Job](../../doc/controllers/hubs.md#create-integration-job)
* [Get Hub Notification Socket Auth](../../doc/controllers/hubs.md#get-hub-notification-socket-auth)


# Get Hubs

Lists all associated Hubs.

```csharp
GetHubsAsync(
    Models.Page page = null,
    Models.Filter15 filter = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |
| `filter` | [`Filter15`](../../doc/models/filter-15.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |

## Response Type

[`Task<Models.ListHubsResponse>`](../../doc/models/list-hubs-response.md)

## Example Usage

```csharp
try
{
    ListHubsResponse result = await hubsController.GetHubsAsync();
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


# Create Hub

Create a Hub.

```csharp
CreateHubAsync(
    Models.V1HubsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1HubsRequest`](../../doc/models/v1-hubs-request.md) | Body, Optional | Parameters for creating a Hub. |

## Response Type

[`Task<Models.V1HubsResponse>`](../../doc/models/v1-hubs-response.md)

## Example Usage

```csharp
try
{
    V1HubsResponse result = await hubsController.CreateHubAsync();
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


# Get Hub

Requires the `hubs-view` capability.

```csharp
GetHubAsync(
    List<Models.Meta14Enum> meta = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `meta` | [`List<Meta14Enum>`](../../doc/models/meta-14-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |

## Response Type

[`Task<Models.V1HubsCurrentResponse>`](../../doc/models/v1-hubs-current-response.md)

## Example Usage

```csharp
try
{
    V1HubsCurrentResponse result = await hubsController.GetHubAsync();
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


# Update Hub

Updates the specified hub, setting the values of the parameters passed.

```csharp
UpdateHubAsync(
    Models.V1HubsCurrentRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1HubsCurrentRequest`](../../doc/models/v1-hubs-current-request.md) | Body, Optional | Parameters for updating a hub. |

## Response Type

[`Task<Models.HubUpdateResponse>`](../../doc/models/hub-update-response.md)

## Example Usage

```csharp
try
{
    HubUpdateResponse result = await hubsController.UpdateHubAsync();
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


# Delete Hub

Requires the `hubs-delete` capability. This can only be aquired by being the hub owner.

```csharp
DeleteHubAsync()
```

## Response Type

[`Task<Models.V1HubsCurrentResponse1>`](../../doc/models/v1-hubs-current-response-1.md)

## Example Usage

```csharp
try
{
    V1HubsCurrentResponse1 result = await hubsController.DeleteHubAsync();
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


# Get Hub Capabilities

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetHubCapabilitiesAsync()
```

## Response Type

[`Task<Models.V1HubsCapabilitiesResponse>`](../../doc/models/v1-hubs-capabilities-response.md)

## Example Usage

```csharp
try
{
    V1HubsCapabilitiesResponse result = await hubsController.GetHubCapabilitiesAsync();
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


# Get Hub Usage

Requires the `hubs-view` capability.

```csharp
GetHubUsageAsync(
    object filter = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `filter` | `object` | Query, Optional | - |

## Response Type

[`Task<Models.V1HubsCurrentUsageResponse>`](../../doc/models/v1-hubs-current-usage-response.md)

## Example Usage

```csharp
try
{
    V1HubsCurrentUsageResponse result = await hubsController.GetHubUsageAsync();
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


# Get Hub Activity

```csharp
GetHubActivityAsync(
    List<Models.Include15Enum> include = null,
    Models.Filter16 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `include` | [`List<Include15Enum>`](../../doc/models/include-15-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `filter` | [`Filter16`](../../doc/models/filter-16.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1HubsCurrentActivityResponse>`](../../doc/models/v1-hubs-current-activity-response.md)

## Example Usage

```csharp
try
{
    V1HubsCurrentActivityResponse result = await hubsController.GetHubActivityAsync();
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


# Delete Hub Invite

Requires the `hub-invites-manage` capability.

```csharp
DeleteHubInviteAsync(
    string inviteId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `inviteId` | `string` | Template, Required | The ID of the Hub Invite. |

## Response Type

[`Task<Models.V1HubsCurrentInvitesResponse>`](../../doc/models/v1-hubs-current-invites-response.md)

## Example Usage

```csharp
string inviteId = "inviteId8";
try
{
    V1HubsCurrentInvitesResponse result = await hubsController.DeleteHubInviteAsync(inviteId);
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


# Get Hub Invites

Requires the `hubs-invites-manage` capability.

```csharp
GetHubInvitesAsync(
    List<Models.Meta1Enum> meta = null,
    List<Models.Include16Enum> include = null,
    List<string> sort = null,
    object filter = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `meta` | [`List<Meta1Enum>`](../../doc/models/meta-1-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `include` | [`List<Include16Enum>`](../../doc/models/include-16-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `filter` | `object` | Query, Optional | - |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1HubsCurrentInvitesResponse1>`](../../doc/models/v1-hubs-current-invites-response-1.md)

## Example Usage

```csharp
try
{
    V1HubsCurrentInvitesResponse1 result = await hubsController.GetHubInvitesAsync();
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


# Create Hub Invite

Requires the `hubs-invites-send` capability.

```csharp
CreateHubInviteAsync(
    Models.V1HubsCurrentInvitesRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1HubsCurrentInvitesRequest`](../../doc/models/v1-hubs-current-invites-request.md) | Body, Optional | Parameters for creating a Hub invite. |

## Response Type

[`Task<Models.V1HubsCurrentInvitesResponse>`](../../doc/models/v1-hubs-current-invites-response.md)

## Example Usage

```csharp
V1HubsCurrentInvitesRequest body = new V1HubsCurrentInvitesRequest
{
    RoleId = "651586fca6078e98982dbd90",
};

try
{
    V1HubsCurrentInvitesResponse result = await hubsController.CreateHubInviteAsync(body);
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


# Get Hub Members

Requires the `hubs-members-view` capability.

```csharp
GetHubMembersAsync(
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
| `include` | [`List<IncludeEnum>`](../../doc/models/include-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `filter` | `object` | Query, Optional | - |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1HubsCurrentMembersResponse>`](../../doc/models/v1-hubs-current-members-response.md)

## Example Usage

```csharp
try
{
    V1HubsCurrentMembersResponse result = await hubsController.GetHubMembersAsync();
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


# Get Hub Membership

Gets the Hub Membership for the requesting Account.

```csharp
GetHubMembershipAsync(
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
| `include` | [`List<IncludeEnum>`](../../doc/models/include-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `filter` | `object` | Query, Optional | - |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1HubsCurrentMembershipResponse>`](../../doc/models/v1-hubs-current-membership-response.md)

## Example Usage

```csharp
try
{
    V1HubsCurrentMembershipResponse result = await hubsController.GetHubMembershipAsync();
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


# Get Hub Member

Requires the `hubs-members-view` capability.

```csharp
GetHubMemberAsync(
    string memberId,
    List<Models.IncludeEnum> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `memberId` | `string` | Template, Required | The ID for the given Hub member. |
| `include` | [`List<IncludeEnum>`](../../doc/models/include-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |

## Response Type

[`Task<Models.V1HubsCurrentMembersResponse1>`](../../doc/models/v1-hubs-current-members-response-1.md)

## Example Usage

```csharp
string memberId = "memberId0";
try
{
    V1HubsCurrentMembersResponse1 result = await hubsController.GetHubMemberAsync(memberId);
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


# Update Hub Member

Requires the `hubs-members-manage` capability.

```csharp
UpdateHubMemberAsync(
    string memberId,
    Models.V1HubsCurrentMembersRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `memberId` | `string` | Template, Required | The ID for the given member. |
| `body` | [`V1HubsCurrentMembersRequest`](../../doc/models/v1-hubs-current-members-request.md) | Body, Optional | Parameters for updating a Hub membership. |

## Response Type

[`Task<Models.V1HubsCurrentMembersResponse2>`](../../doc/models/v1-hubs-current-members-response-2.md)

## Example Usage

```csharp
string memberId = "memberId0";
V1HubsCurrentMembersRequest body = new V1HubsCurrentMembersRequest
{
    RoleId = "651586fca6078e98982dbd90",
};

try
{
    V1HubsCurrentMembersResponse2 result = await hubsController.UpdateHubMemberAsync(
        memberId,
        body
    );
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


# Delete Hub Member

Requires the `hubs-members-manage` capability.

```csharp
DeleteHubMemberAsync(
    string memberId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `memberId` | `string` | Template, Required | The ID of the given Hub Member. |

## Response Type

[`Task<Models.V1HubsCurrentMembersResponse3>`](../../doc/models/v1-hubs-current-members-response-3.md)

## Example Usage

```csharp
string memberId = "memberId0";
try
{
    V1HubsCurrentMembersResponse3 result = await hubsController.DeleteHubMemberAsync(memberId);
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


# Get Hub Member Account

Requires the `hubs-members-view` capability.

```csharp
GetHubMemberAccountAsync(
    string accountId,
    List<Models.Meta1Enum> meta = null,
    List<Models.IncludeEnum> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `accountId` | `string` | Template, Required | The ID of the member's Account. |
| `meta` | [`List<Meta1Enum>`](../../doc/models/meta-1-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `include` | [`List<IncludeEnum>`](../../doc/models/include-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |

## Response Type

[`Task<Models.V1HubsCurrentMembersAccountResponse>`](../../doc/models/v1-hubs-current-members-account-response.md)

## Example Usage

```csharp
string accountId = "accountId0";
try
{
    V1HubsCurrentMembersAccountResponse result = await hubsController.GetHubMemberAccountAsync(accountId);
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


# Get Api Keys

Requires the `api-keys-manage` capability.

```csharp
GetApiKeysAsync(
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

[`Task<Models.ListApiKeysResponse>`](../../doc/models/list-api-keys-response.md)

## Example Usage

```csharp
try
{
    ListApiKeysResponse result = await hubsController.GetApiKeysAsync();
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


# Create Api Key

Requires the `api-keys-manage` capability.

```csharp
CreateApiKeyAsync(
    Models.V1HubsCurrentApiKeysRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1HubsCurrentApiKeysRequest`](../../doc/models/v1-hubs-current-api-keys-request.md) | Body, Optional | Parameters for creating an API Key. |

## Response Type

[`Task<Models.V1HubsCurrentApiKeysResponse>`](../../doc/models/v1-hubs-current-api-keys-response.md)

## Example Usage

```csharp
try
{
    V1HubsCurrentApiKeysResponse result = await hubsController.CreateApiKeyAsync();
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


# Get API Key

Requries the `api-keys-manage` capability.

```csharp
GetAPIKeyAsync(
    string apikeyId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikeyId` | `string` | Template, Required | The ID of the API Key. |

## Response Type

[`Task<Models.V1HubsCurrentApiKeysResponse1>`](../../doc/models/v1-hubs-current-api-keys-response-1.md)

## Example Usage

```csharp
string apikeyId = "apikeyId4";
try
{
    V1HubsCurrentApiKeysResponse1 result = await hubsController.GetAPIKeyAsync(apikeyId);
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


# Update API Key

Requires the `api-keys-manage` capability.

```csharp
UpdateAPIKeyAsync(
    string apikeyId,
    Models.V1HubsCurrentApiKeysRequest1 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikeyId` | `string` | Template, Required | The ID of the API Key. |
| `body` | [`V1HubsCurrentApiKeysRequest1`](../../doc/models/v1-hubs-current-api-keys-request-1.md) | Body, Optional | Parameters for updating an API Key. |

## Response Type

[`Task<Models.V1HubsCurrentApiKeysResponse>`](../../doc/models/v1-hubs-current-api-keys-response.md)

## Example Usage

```csharp
string apikeyId = "apikeyId4";
try
{
    V1HubsCurrentApiKeysResponse result = await hubsController.UpdateAPIKeyAsync(apikeyId);
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


# Delete API Key

Requires the 'api-keys-manage' capability.

```csharp
DeleteAPIKeyAsync(
    string apikeyId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `apikeyId` | `string` | Template, Required | The ID of the API Key. |

## Response Type

[`Task<Models.V1HubsCurrentApiKeysResponse>`](../../doc/models/v1-hubs-current-api-keys-response.md)

## Example Usage

```csharp
string apikeyId = "apikeyId4";
try
{
    V1HubsCurrentApiKeysResponse result = await hubsController.DeleteAPIKeyAsync(apikeyId);
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


# Get Roles

Lists the Roles that have been created for this Hub.

Requires the `hubs-roles-manage` capability.

```csharp
GetRolesAsync(
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

[`Task<Models.V1HubsCurrentRolesResponse>`](../../doc/models/v1-hubs-current-roles-response.md)

## Example Usage

```csharp
try
{
    V1HubsCurrentRolesResponse result = await hubsController.GetRolesAsync();
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


# Create Role

Creates a custom Role for a Hub.

Requires the `hubs-roles-manage` capability.

```csharp
CreateRoleAsync(
    Models.V1HubsCurrentRolesRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1HubsCurrentRolesRequest`](../../doc/models/v1-hubs-current-roles-request.md) | Body, Optional | Parameters for creating a new Hub Role. |

## Response Type

[`Task<Models.V1HubsCurrentRolesResponse1>`](../../doc/models/v1-hubs-current-roles-response-1.md)

## Example Usage

```csharp
try
{
    V1HubsCurrentRolesResponse1 result = await hubsController.CreateRoleAsync();
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


# Get Role

Retrieves the specified Role.

Requries the `hubs-roles-manage` capability.

```csharp
GetRoleAsync(
    string roleId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `roleId` | `string` | Template, Required | The ID of the Role. |

## Response Type

[`Task<Models.GetRoleResponse>`](../../doc/models/get-role-response.md)

## Example Usage

```csharp
string roleId = "roleId6";
try
{
    GetRoleResponse result = await hubsController.GetRoleAsync(roleId);
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


# Update Role

Updates various properties of a specific Role.

Requires the `hubs-roles-manage` capability.

```csharp
UpdateRoleAsync(
    string roleId,
    Models.V1HubsCurrentRolesRequest1 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `roleId` | `string` | Template, Required | The ID of the Role. |
| `body` | [`V1HubsCurrentRolesRequest1`](../../doc/models/v1-hubs-current-roles-request-1.md) | Body, Optional | - |

## Response Type

[`Task<Models.V1HubsCurrentRolesResponse1>`](../../doc/models/v1-hubs-current-roles-response-1.md)

## Example Usage

```csharp
string roleId = "roleId6";
try
{
    V1HubsCurrentRolesResponse1 result = await hubsController.UpdateRoleAsync(roleId);
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


# Delete Role

Marks a Role as 'deleted'.

Requires the 'hubs-roles-manage' capability.

```csharp
DeleteRoleAsync(
    string roleId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `roleId` | `string` | Template, Required | The ID of the Role. |

## Response Type

[`Task<Models.V1HubsCurrentRolesResponse3>`](../../doc/models/v1-hubs-current-roles-response-3.md)

## Example Usage

```csharp
string roleId = "roleId6";
try
{
    V1HubsCurrentRolesResponse3 result = await hubsController.DeleteRoleAsync(roleId);
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


# Get Integration

Retrieves details of a single Integration associated with the current hub.

Requires the `hubs-integrations-view` capability.

```csharp
GetIntegrationAsync(
    string integrationId,
    List<Models.Meta20Enum> meta = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `integrationId` | `string` | Template, Required | The ID of the Integration to retrieve.<br>**Constraints**: *Pattern*: `^[a-f0-9]{24}$` |
| `meta` | [`List<Meta20Enum>`](../../doc/models/meta-20-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |

## Response Type

[`Task<Models.V1HubsCurrentIntegrationsResponse>`](../../doc/models/v1-hubs-current-integrations-response.md)

## Example Usage

```csharp
string integrationId = "integrationId8";
try
{
    V1HubsCurrentIntegrationsResponse result = await hubsController.GetIntegrationAsync(integrationId);
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


# Update Integration

Updates the specified Integration within the current hub. If the Integration definition specifies that it requires verification, then you must submit a verify task to enable it.

```csharp
UpdateIntegrationAsync(
    string integrationId,
    Models.V1HubsCurrentIntegrationsRequest body,
    List<Models.Meta20Enum> meta = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `integrationId` | `string` | Template, Required | The ID of the Integration to update.<br>**Constraints**: *Pattern*: `^[a-f0-9]{24}$` |
| `body` | [`V1HubsCurrentIntegrationsRequest`](../../doc/models/v1-hubs-current-integrations-request.md) | Body, Required | - |
| `meta` | [`List<Meta20Enum>`](../../doc/models/meta-20-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |

## Response Type

[`Task<Models.V1HubsCurrentIntegrationsResponse>`](../../doc/models/v1-hubs-current-integrations-response.md)

## Example Usage

```csharp
string integrationId = "integrationId8";
V1HubsCurrentIntegrationsRequest body = new V1HubsCurrentIntegrationsRequest
{
};

try
{
    V1HubsCurrentIntegrationsResponse result = await hubsController.UpdateIntegrationAsync(
        integrationId,
        body
    );
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


# Delete Integration

Deletes the specified Integration from the current hub, marking it as deleted and returning the updated Integration.

```csharp
DeleteIntegrationAsync(
    string integrationId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `integrationId` | `string` | Template, Required | The ID of the Integration to delete.<br>**Constraints**: *Pattern*: `^[a-f0-9]{24}$` |

## Response Type

[`Task<Models.V1HubsCurrentIntegrationsResponse2>`](../../doc/models/v1-hubs-current-integrations-response-2.md)

## Example Usage

```csharp
string integrationId = "integrationId8";
try
{
    V1HubsCurrentIntegrationsResponse2 result = await hubsController.DeleteIntegrationAsync(integrationId);
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


# Get Integrations

Lists all integrations associated with the current Hub, with optional filtering.

Requires the `hubs-integrations-view` capability.

```csharp
GetIntegrationsAsync(
    Models.Page page = null,
    List<Models.Meta20Enum> meta = null,
    Models.Filter17 filter = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |
| `meta` | [`List<Meta20Enum>`](../../doc/models/meta-20-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `filter` | [`Filter17`](../../doc/models/filter-17.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. Supports filtering by state and a text search. |

## Response Type

[`Task<Models.V1HubsCurrentIntegrationsResponse3>`](../../doc/models/v1-hubs-current-integrations-response-3.md)

## Example Usage

```csharp
try
{
    V1HubsCurrentIntegrationsResponse3 result = await hubsController.GetIntegrationsAsync();
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


# Create Integration

Create an Integration resource within a hub. If the Integration definition specifies that it requires verification, then you must submit a verify task to enable it.

```csharp
CreateIntegrationAsync(
    Models.V1HubsCurrentIntegrationsRequest1 body,
    List<Models.Meta20Enum> meta = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1HubsCurrentIntegrationsRequest1`](../../doc/models/v1-hubs-current-integrations-request-1.md) | Body, Required | Parameters for creating an Integration. |
| `meta` | [`List<Meta20Enum>`](../../doc/models/meta-20-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |

## Response Type

[`Task<Models.V1HubsCurrentIntegrationsResponse>`](../../doc/models/v1-hubs-current-integrations-response.md)

## Example Usage

```csharp
V1HubsCurrentIntegrationsRequest1 body = new V1HubsCurrentIntegrationsRequest1
{
    Vendor = "vendor2",
};

try
{
    V1HubsCurrentIntegrationsResponse result = await hubsController.CreateIntegrationAsync(body);
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


# Get Available Integrations

Returns a map of available integrations categorized by their type.

```csharp
GetAvailableIntegrationsAsync()
```

## Response Type

[`Task<Models.V1HubsCurrentIntegrationsAvailableResponse>`](../../doc/models/v1-hubs-current-integrations-available-response.md)

## Example Usage

```csharp
try
{
    V1HubsCurrentIntegrationsAvailableResponse result = await hubsController.GetAvailableIntegrationsAsync();
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


# Create Integration Job

Creates a new Job targeted at the provided Hub Integration.

## Required Permissions

- Requires a valid hub membership to the target hub.
- Requires the `hubs-integrations-manage` capability.

```csharp
CreateIntegrationJobAsync(
    string integrationId,
    Models.V1HubsCurrentIntegrationsTasksRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `integrationId` | `string` | Template, Required | The ID of the Hub Integration. |
| `body` | [`V1HubsCurrentIntegrationsTasksRequest`](../../doc/models/v1-hubs-current-integrations-tasks-request.md) | Body, Optional | Parameters for creating a new Hub Integration Job. |

## Response Type

[`Task<Models.V1HubsCurrentIntegrationsTasksResponse>`](../../doc/models/v1-hubs-current-integrations-tasks-response.md)

## Example Usage

```csharp
string integrationId = "integrationId8";
V1HubsCurrentIntegrationsTasksRequest body = new V1HubsCurrentIntegrationsTasksRequest
{
    Action = "verify",
};

try
{
    V1HubsCurrentIntegrationsTasksResponse result = await hubsController.CreateIntegrationJobAsync(
        integrationId,
        body
    );
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


# Get Hub Notification Socket Auth

Initializes authorization for the Hub notification pipeline. The Hub notification pipeline is a one-way streaming websocket that
sends real-time 'notifications' as things are happening on the Hub. These notifications tell some basic information about an event,
and it is up to the user to fetch additional details, if deemed necessary.

Requesting this endpoint without a `?token=<token>` URL parameter will result in receiving a short lived token in the response body. That
token can then be applied to the URL parameter to the same endpoint to upgrade the connection to a WebSocket.

Requires the `apionly-notifications-listen` capability.

```csharp
GetHubNotificationSocketAuthAsync()
```

## Response Type

[`Task<Models.V1HubsCurrentNotificationsResponse>`](../../doc/models/v1-hubs-current-notifications-response.md)

## Example Usage

```csharp
try
{
    V1HubsCurrentNotificationsResponse result = await hubsController.GetHubNotificationSocketAuthAsync();
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

