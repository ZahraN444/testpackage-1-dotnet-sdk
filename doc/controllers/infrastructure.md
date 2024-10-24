# Infrastructure

Cycle creates a paradigm shift when it comes to dealing with your infrastructure. The primary focus when using the platform is your containers, while the servers underneath appear as a giant pool of distributed resources.

```csharp
InfrastructureController infrastructureController = client.InfrastructureController;
```

## Class Name

`InfrastructureController`

## Methods

* [Get Infrastructure Summary](../../doc/controllers/infrastructure.md#get-infrastructure-summary)
* [Get Provider Servers](../../doc/controllers/infrastructure.md#get-provider-servers)
* [Get Provider Locations](../../doc/controllers/infrastructure.md#get-provider-locations)
* [Get Auto Scale Groups](../../doc/controllers/infrastructure.md#get-auto-scale-groups)
* [Create Auto Scale Group](../../doc/controllers/infrastructure.md#create-auto-scale-group)
* [Get Auto Scale Group](../../doc/controllers/infrastructure.md#get-auto-scale-group)
* [Update Auto Scale Group](../../doc/controllers/infrastructure.md#update-auto-scale-group)
* [Delete Auto Scale Group](../../doc/controllers/infrastructure.md#delete-auto-scale-group)
* [Get Servers](../../doc/controllers/infrastructure.md#get-servers)
* [Create Server](../../doc/controllers/infrastructure.md#create-server)
* [Get Server](../../doc/controllers/infrastructure.md#get-server)
* [Update Server](../../doc/controllers/infrastructure.md#update-server)
* [Get Server Telemetry](../../doc/controllers/infrastructure.md#get-server-telemetry)
* [Get Server Instances](../../doc/controllers/infrastructure.md#get-server-instances)
* [Create Server Job](../../doc/controllers/infrastructure.md#create-server-job)
* [Get Server Tags](../../doc/controllers/infrastructure.md#get-server-tags)
* [Get Clusters](../../doc/controllers/infrastructure.md#get-clusters)
* [Get Server Usage](../../doc/controllers/infrastructure.md#get-server-usage)
* [Get Server Console](../../doc/controllers/infrastructure.md#get-server-console)
* [Get Infrastructure IP Pools](../../doc/controllers/infrastructure.md#get-infrastructure-ip-pools)
* [Get IP Pool](../../doc/controllers/infrastructure.md#get-ip-pool)
* [Delete IP Pool](../../doc/controllers/infrastructure.md#delete-ip-pool)
* [Get Pool I Ps](../../doc/controllers/infrastructure.md#get-pool-i-ps)
* [Get Deployment Strategies](../../doc/controllers/infrastructure.md#get-deployment-strategies)


# Get Infrastructure Summary

Requires the `infrastructure-servers-view` capability.

```csharp
GetInfrastructureSummaryAsync(
    Models.Filter20 filter = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `filter` | [`Filter20`](../../doc/models/filter-20.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |

## Response Type

[`Task<Models.V1InfrastructureSummaryResponse>`](../../doc/models/v1-infrastructure-summary-response.md)

## Example Usage

```csharp
try
{
    V1InfrastructureSummaryResponse result = await infrastructureController.GetInfrastructureSummaryAsync();
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


# Get Provider Servers

```csharp
GetProviderServersAsync(
    string providerVendor,
    List<string> sort = null,
    Models.Page page = null,
    Models.Filter21 filter = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `providerVendor` | `string` | Template, Required | The vendor for the given provider. Example `gcp`, `equinix-metal`, `abstraction`, etc. Can also use a Provider Integration ID. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |
| `filter` | [`Filter21`](../../doc/models/filter-21.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |

## Response Type

[`Task<Models.V1InfrastructureProvidersServersResponse>`](../../doc/models/v1-infrastructure-providers-servers-response.md)

## Example Usage

```csharp
string providerVendor = "providerVendor4";
try
{
    V1InfrastructureProvidersServersResponse result = await infrastructureController.GetProviderServersAsync(providerVendor);
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


# Get Provider Locations

```csharp
GetProviderLocationsAsync(
    string providerVendor,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `providerVendor` | `string` | Template, Required | The vendor for the given Provider Integration. Example `gcp`, `equinix-metal`, `abstraction`, etc. Can also use the Integration ID. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1InfrastructureProvidersLocationsResponse>`](../../doc/models/v1-infrastructure-providers-locations-response.md)

## Example Usage

```csharp
string providerVendor = "providerVendor4";
try
{
    V1InfrastructureProvidersLocationsResponse result = await infrastructureController.GetProviderLocationsAsync(providerVendor);
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


# Get Auto Scale Groups

Requires the `autoscale-groups-manage` capability.

```csharp
GetAutoScaleGroupsAsync(
    Models.Page page = null,
    List<Models.Include25Enum> include = null,
    Models.Filter22 filter = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |
| `include` | [`List<Include25Enum>`](../../doc/models/include-25-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `filter` | [`Filter22`](../../doc/models/filter-22.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |

## Response Type

[`Task<Models.V1InfrastructureAutoScaleGroupsResponse>`](../../doc/models/v1-infrastructure-auto-scale-groups-response.md)

## Example Usage

```csharp
try
{
    V1InfrastructureAutoScaleGroupsResponse result = await infrastructureController.GetAutoScaleGroupsAsync();
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


# Create Auto Scale Group

Requires the 'autoscale-groups-manage'

```csharp
CreateAutoScaleGroupAsync(
    Models.V1InfrastructureAutoScaleGroupsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1InfrastructureAutoScaleGroupsRequest`](../../doc/models/v1-infrastructure-auto-scale-groups-request.md) | Body, Optional | Parameters for creating an Auto-Scale Group |

## Response Type

[`Task<Models.CreateAutoScaleGroupResponse>`](../../doc/models/create-auto-scale-group-response.md)

## Example Usage

```csharp
V1InfrastructureAutoScaleGroupsRequest body = new V1InfrastructureAutoScaleGroupsRequest
{
    Name = "name6",
    Identifier = "identifier6",
    Cluster = "cluster8",
    Scale = new AutoScaleGroupScale
    {
    },
    Infrastructure = new AutoScaleGroupInfrastructure
    {
        Models = new List<Model>
        {
            new Model
            {
                Provider = "provider4",
                ModelId = "model_id4",
                Priority = 54,
                Locations = new List<Location>
                {
                    new Location
                    {
                        Id = "id8",
                        AvailabilityZones = new List<string>
                        {
                            "availability_zones5",
                            "availability_zones6",
                            "availability_zones7",
                        },
                    },
                },
                IntegrationId = "651586fca6078e98982dbd90",
            },
        },
    },
};

try
{
    CreateAutoScaleGroupResponse result = await infrastructureController.CreateAutoScaleGroupAsync(body);
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


# Get Auto Scale Group

Requires the `autoscale-groups-view` capability.

```csharp
GetAutoScaleGroupAsync(
    string groupId,
    List<Models.Include25Enum> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `groupId` | `string` | Template, Required | The ID for the given Auto-Scale Group. |
| `include` | [`List<Include25Enum>`](../../doc/models/include-25-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |

## Response Type

[`Task<Models.V1InfrastructureAutoScaleGroupsResponse1>`](../../doc/models/v1-infrastructure-auto-scale-groups-response-1.md)

## Example Usage

```csharp
string groupId = "groupId2";
try
{
    V1InfrastructureAutoScaleGroupsResponse1 result = await infrastructureController.GetAutoScaleGroupAsync(groupId);
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


# Update Auto Scale Group

Requires the `autoscale-groups-manage` capability.

```csharp
UpdateAutoScaleGroupAsync(
    string groupId,
    Models.V1InfrastructureAutoScaleGroupsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `groupId` | `string` | Template, Required | The ID for the given Auto-Scale Group. |
| `body` | [`V1InfrastructureAutoScaleGroupsRequest`](../../doc/models/v1-infrastructure-auto-scale-groups-request.md) | Body, Optional | Parameters for creating an Auto-Scale Group |

## Response Type

[`Task<Models.V1InfrastructureAutoScaleGroupsResponse2>`](../../doc/models/v1-infrastructure-auto-scale-groups-response-2.md)

## Example Usage

```csharp
string groupId = "groupId2";
V1InfrastructureAutoScaleGroupsRequest body = new V1InfrastructureAutoScaleGroupsRequest
{
    Name = "name6",
    Identifier = "identifier6",
    Cluster = "cluster8",
    Scale = new AutoScaleGroupScale
    {
    },
    Infrastructure = new AutoScaleGroupInfrastructure
    {
        Models = new List<Model>
        {
            new Model
            {
                Provider = "provider4",
                ModelId = "model_id4",
                Priority = 54,
                Locations = new List<Location>
                {
                    new Location
                    {
                        Id = "id8",
                        AvailabilityZones = new List<string>
                        {
                            "availability_zones5",
                            "availability_zones6",
                            "availability_zones7",
                        },
                    },
                },
                IntegrationId = "651586fca6078e98982dbd90",
            },
        },
    },
};

try
{
    V1InfrastructureAutoScaleGroupsResponse2 result = await infrastructureController.UpdateAutoScaleGroupAsync(
        groupId,
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


# Delete Auto Scale Group

Requires the `autoscale-group-manage` capability.

```csharp
DeleteAutoScaleGroupAsync(
    string groupId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `groupId` | `string` | Template, Required | The ID for the given autoscale group. |

## Response Type

[`Task<Models.V1InfrastructureAutoScaleGroupsResponse3>`](../../doc/models/v1-infrastructure-auto-scale-groups-response-3.md)

## Example Usage

```csharp
string groupId = "groupId2";
try
{
    V1InfrastructureAutoScaleGroupsResponse3 result = await infrastructureController.DeleteAutoScaleGroupAsync(groupId);
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


# Get Servers

Requires the `servers-view` capability.

```csharp
GetServersAsync(
    List<Models.Meta13Enum> meta = null,
    List<Models.Include25Enum> include = null,
    Models.Filter23 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `meta` | [`List<Meta13Enum>`](../../doc/models/meta-13-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `include` | [`List<Include25Enum>`](../../doc/models/include-25-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `filter` | [`Filter23`](../../doc/models/filter-23.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1InfrastructureServersResponse>`](../../doc/models/v1-infrastructure-servers-response.md)

## Example Usage

```csharp
try
{
    V1InfrastructureServersResponse result = await infrastructureController.GetServersAsync();
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


# Create Server

Requires the `servers-provision` capability.

```csharp
CreateServerAsync(
    Models.V1InfrastructureServersRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1InfrastructureServersRequest`](../../doc/models/v1-infrastructure-servers-request.md) | Body, Optional | Parameters for creating a Server. |

## Response Type

[`Task<Models.V1InfrastructureServersResponse1>`](../../doc/models/v1-infrastructure-servers-response-1.md)

## Example Usage

```csharp
V1InfrastructureServersRequest body = new V1InfrastructureServersRequest
{
    Cluster = "cluster8",
    Servers = new List<Servers1>
    {
        new Servers1
        {
            IntegrationId = "651586fca6078e98982dbd90",
            ModelId = "model_id2",
            LocationId = "location_id6",
            Quantity = 238,
        },
    },
};

try
{
    V1InfrastructureServersResponse1 result = await infrastructureController.CreateServerAsync(body);
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


# Get Server

Requires the `servers-view` capability.

```csharp
GetServerAsync(
    string serverId,
    List<Models.Include25Enum> include = null,
    List<Models.Meta13Enum> meta = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serverId` | `string` | Template, Required | The ID for the given Server. |
| `include` | [`List<Include25Enum>`](../../doc/models/include-25-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `meta` | [`List<Meta13Enum>`](../../doc/models/meta-13-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |

## Response Type

[`Task<Models.V1InfrastructureServersResponse2>`](../../doc/models/v1-infrastructure-servers-response-2.md)

## Example Usage

```csharp
string serverId = "serverId8";
try
{
    V1InfrastructureServersResponse2 result = await infrastructureController.GetServerAsync(serverId);
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


# Update Server

Requires the `servers-manage` capability.

```csharp
UpdateServerAsync(
    string serverId,
    Models.V1InfrastructureServersRequest1 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serverId` | `string` | Template, Required | The ID for the given Server. |
| `body` | [`V1InfrastructureServersRequest1`](../../doc/models/v1-infrastructure-servers-request-1.md) | Body, Optional | Parameters for updating a Server. |

## Response Type

[`Task<Models.V1InfrastructureServersResponse3>`](../../doc/models/v1-infrastructure-servers-response-3.md)

## Example Usage

```csharp
string serverId = "serverId8";
try
{
    V1InfrastructureServersResponse3 result = await infrastructureController.UpdateServerAsync(serverId);
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


# Get Server Telemetry

This call requires the filter query parameter to be used.

Requires the `servers-view` capability.

```csharp
GetServerTelemetryAsync(
    string serverId,
    Models.Filter24 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serverId` | `string` | Template, Required | The ID for the given Server. |
| `filter` | [`Filter24`](../../doc/models/filter-24.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1InfrastructureServersTelemetryResponse>`](../../doc/models/v1-infrastructure-servers-telemetry-response.md)

## Example Usage

```csharp
string serverId = "serverId8";
Filter24 filter = new Filter24
{
    RangeStart = DateTime.ParseExact("01/30/2021 08:30:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    RangeEnd = DateTime.ParseExact("01/30/2021 08:30:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};

try
{
    V1InfrastructureServersTelemetryResponse result = await infrastructureController.GetServerTelemetryAsync(
        serverId,
        filter
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


# Get Server Instances

Requires the `containers-view` capability.

```csharp
GetServerInstancesAsync(
    string serverId,
    Models.Page page = null,
    List<Models.Include29Enum> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serverId` | `string` | Template, Required | The ID for the given server. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |
| `include` | [`List<Include29Enum>`](../../doc/models/include-29-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |

## Response Type

[`Task<Models.GetServerInstancesReturn>`](../../doc/models/get-server-instances-return.md)

## Example Usage

```csharp
string serverId = "serverId8";
try
{
    GetServerInstancesReturn result = await infrastructureController.GetServerInstancesAsync(serverId);
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


# Create Server Job

Used to perform different actions on a given Server. Requires the `servers-manage` capability.

```csharp
CreateServerJobAsync(
    string serverId,
    CreateServerJobBody body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serverId` | `string` | Template, Required | The ID for the given Server. |
| `body` | [`CreateServerJobBody`](../../doc/models/containers/create-server-job-body.md) | Body, Optional | This is a container for one-of cases. |

## Response Type

[`Task<Models.V1InfrastructureServersTasksResponse>`](../../doc/models/v1-infrastructure-servers-tasks-response.md)

## Example Usage

```csharp
string serverId = "serverId8";
CreateServerJobBody body = CreateServerJobBody.FromReconfigureSharedFs(
    new ReconfigureSharedFs
    {
        Action = "sharedfs.reconfigure",
        Contents = new ServerSharedFileSystems
        {
        },
    }
);

try
{
    V1InfrastructureServersTasksResponse result = await infrastructureController.CreateServerJobAsync(
        serverId,
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


# Get Server Tags

Requires the `servers-view` capability.

```csharp
GetServerTagsAsync(
    Models.Filter25 filter = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `filter` | [`Filter25`](../../doc/models/filter-25.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |

## Response Type

[`Task<Models.ServerTags>`](../../doc/models/server-tags.md)

## Example Usage

```csharp
try
{
    ServerTags result = await infrastructureController.GetServerTagsAsync();
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


# Get Clusters

Requires the `servers-view` capability.

```csharp
GetClustersAsync()
```

## Response Type

[`Task<Models.ServerClustersReturn>`](../../doc/models/server-clusters-return.md)

## Example Usage

```csharp
try
{
    ServerClustersReturn result = await infrastructureController.GetClustersAsync();
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


# Get Server Usage

Requires the `servers-view` capability.

```csharp
GetServerUsageAsync(
    string serverId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serverId` | `string` | Template, Required | The ID for the given server. |

## Response Type

[`Task<Models.V1InfrastructureServersUsageResponse>`](../../doc/models/v1-infrastructure-servers-usage-response.md)

## Example Usage

```csharp
string serverId = "serverId8";
try
{
    V1InfrastructureServersUsageResponse result = await infrastructureController.GetServerUsageAsync(serverId);
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


# Get Server Console

Gets the authorization information required to connect to a Server console websocket.

Requires the `servers-console` capability.

```csharp
GetServerConsoleAsync(
    string serverId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serverId` | `string` | Template, Required | The ID of the server to connect to. |

## Response Type

[`Task<Models.V1InfrastructureServersConsoleResponse>`](../../doc/models/v1-infrastructure-servers-console-response.md)

## Example Usage

```csharp
string serverId = "serverId8";
try
{
    V1InfrastructureServersConsoleResponse result = await infrastructureController.GetServerConsoleAsync(serverId);
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


# Get Infrastructure IP Pools

Requires the `infrastructure-ips-manage` capability.

```csharp
GetInfrastructureIPPoolsAsync(
    List<Models.Include30Enum> include = null,
    Models.Filter26 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `include` | [`List<Include30Enum>`](../../doc/models/include-30-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `filter` | [`Filter26`](../../doc/models/filter-26.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1InfrastructureIpsPoolsResponse>`](../../doc/models/v1-infrastructure-ips-pools-response.md)

## Example Usage

```csharp
try
{
    V1InfrastructureIpsPoolsResponse result = await infrastructureController.GetInfrastructureIPPoolsAsync();
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


# Get IP Pool

Requires the `infrastructure-ips-manage` capability.

```csharp
GetIPPoolAsync(
    string poolId,
    List<Models.Include30Enum> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `poolId` | `string` | Template, Required | The ID for the given pool. |
| `include` | [`List<Include30Enum>`](../../doc/models/include-30-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |

## Response Type

[`Task<Models.V1InfrastructureIpsPoolsResponse1>`](../../doc/models/v1-infrastructure-ips-pools-response-1.md)

## Example Usage

```csharp
string poolId = "poolId4";
try
{
    V1InfrastructureIpsPoolsResponse1 result = await infrastructureController.GetIPPoolAsync(poolId);
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


# Delete IP Pool

Requires the `infrastructure-ips-manage` capability.

```csharp
DeleteIPPoolAsync(
    string poolId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `poolId` | `string` | Template, Required | The ID for the given IP Pool. |

## Response Type

[`Task<Models.V1InfrastructureIpsPoolsResponse2>`](../../doc/models/v1-infrastructure-ips-pools-response-2.md)

## Example Usage

```csharp
string poolId = "poolId4";
try
{
    V1InfrastructureIpsPoolsResponse2 result = await infrastructureController.DeleteIPPoolAsync(poolId);
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


# Get Pool I Ps

Requires the `infrastructure-ips-manage` capability.

```csharp
GetPoolIPsAsync(
    string poolId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `poolId` | `string` | Template, Required | The ID of the IP Pool to fetch the IPs of. |

## Response Type

[`Task<Models.V1InfrastructureIpsPoolsIpsResponse>`](../../doc/models/v1-infrastructure-ips-pools-ips-response.md)

## Example Usage

```csharp
string poolId = "poolId4";
try
{
    V1InfrastructureIpsPoolsIpsResponse result = await infrastructureController.GetPoolIPsAsync(poolId);
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


# Get Deployment Strategies

Gets the available deployment strategies that can be used to orchestrate containers.

```csharp
GetDeploymentStrategiesAsync()
```

## Response Type

[`Task<Models.V1InfrastructureDeploymentStrategiesResponse>`](../../doc/models/v1-infrastructure-deployment-strategies-response.md)

## Example Usage

```csharp
try
{
    V1InfrastructureDeploymentStrategiesResponse result = await infrastructureController.GetDeploymentStrategiesAsync();
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

