# SDN

Software defined networking. Includes networks that can be created when a user needs to create a new private network spanning multiple environments, and global load balancers for balancing traffic across multiple environments.

```csharp
SDNController sDNController = client.SDNController;
```

## Class Name

`SDNController`

## Methods

* [Get Networks](../../doc/controllers/sdn.md#get-networks)
* [Create Network](../../doc/controllers/sdn.md#create-network)
* [Get Network](../../doc/controllers/sdn.md#get-network)
* [Update Network](../../doc/controllers/sdn.md#update-network)
* [Delete Network](../../doc/controllers/sdn.md#delete-network)
* [Create Network Job](../../doc/controllers/sdn.md#create-network-job)


# Get Networks

Requires the `sdn-networks-view` capability.

```csharp
GetNetworksAsync(
    List<Models.Include34Enum> include = null,
    Models.Filter30 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `include` | [`List<Include34Enum>`](../../doc/models/include-34-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `filter` | [`Filter30`](../../doc/models/filter-30.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.ListNetworksResponse>`](../../doc/models/list-networks-response.md)

## Example Usage

```csharp
try
{
    ListNetworksResponse result = await sDNController.GetNetworksAsync();
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


# Create Network

Requires the `sdn-networks-manage` capability.

```csharp
CreateNetworkAsync(
    List<Models.Include34Enum> include = null,
    Models.V1SdnNetworksRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `include` | [`List<Include34Enum>`](../../doc/models/include-34-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `body` | [`V1SdnNetworksRequest`](../../doc/models/v1-sdn-networks-request.md) | Body, Optional | Parameters for creating a new Network. |

## Response Type

[`Task<Models.V1SdnNetworksResponse>`](../../doc/models/v1-sdn-networks-response.md)

## Example Usage

```csharp
try
{
    V1SdnNetworksResponse result = await sDNController.CreateNetworkAsync();
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


# Get Network

Requires the `sdn-networks-view` capability.

```csharp
GetNetworkAsync(
    string networkId,
    List<Models.Include34Enum> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `networkId` | `string` | Template, Required | The ID of the Network. |
| `include` | [`List<Include34Enum>`](../../doc/models/include-34-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |

## Response Type

[`Task<Models.V1SdnNetworksResponse>`](../../doc/models/v1-sdn-networks-response.md)

## Example Usage

```csharp
string networkId = "networkId4";
try
{
    V1SdnNetworksResponse result = await sDNController.GetNetworkAsync(networkId);
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


# Update Network

Requires the `sdn-networks-manage` capability.

```csharp
UpdateNetworkAsync(
    string networkId,
    List<Models.Include34Enum> include = null,
    Models.V1SdnNetworksRequest1 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `networkId` | `string` | Template, Required | The ID of the Network. |
| `include` | [`List<Include34Enum>`](../../doc/models/include-34-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `body` | [`V1SdnNetworksRequest1`](../../doc/models/v1-sdn-networks-request-1.md) | Body, Optional | Parameters for updating a Network. |

## Response Type

[`Task<Models.V1SdnNetworksResponse>`](../../doc/models/v1-sdn-networks-response.md)

## Example Usage

```csharp
string networkId = "networkId4";
try
{
    V1SdnNetworksResponse result = await sDNController.UpdateNetworkAsync(networkId);
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


# Delete Network

Requires the `sdn-networks-manage` capability.

```csharp
DeleteNetworkAsync(
    string networkId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `networkId` | `string` | Template, Required | The ID of the Network. |

## Response Type

[`Task<Models.V1SdnNetworksResponse3>`](../../doc/models/v1-sdn-networks-response-3.md)

## Example Usage

```csharp
string networkId = "networkId4";
try
{
    V1SdnNetworksResponse3 result = await sDNController.DeleteNetworkAsync(networkId);
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


# Create Network Job

Requires the `sdn-networks-manage` capability.

```csharp
CreateNetworkJobAsync(
    string networkId,
    Models.ReconfigureSDNNetwork body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `networkId` | `string` | Template, Required | The ID of the Network. |
| `body` | [`ReconfigureSDNNetwork`](../../doc/models/reconfigure-sdn-network.md) | Body, Optional | Parameters for creating a new Network Job. |

## Response Type

[`Task<Models.V1SdnNetworksTasksResponse>`](../../doc/models/v1-sdn-networks-tasks-response.md)

## Example Usage

```csharp
string networkId = "networkId4";
ReconfigureSDNNetwork body = new ReconfigureSDNNetwork
{
    Action = "reconfigure",
    Contents = new Contents13
    {
        EnvironmentIds = new List<string>
        {
            "environment_ids9",
            "environment_ids0",
        },
    },
};

try
{
    V1SdnNetworksTasksResponse result = await sDNController.CreateNetworkJobAsync(
        networkId,
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

