# Containers

Containers are a way to package together your application along with it's dependencies, and run in a resource isolated process. They provide consistency across different hosts, efficiency over traditional hosting methods, and facilitate a micro-service based approach, where each logical piece of your application is split into multiple, easily testable parts (such as API, Backend, Frontend, etc).

```csharp
ContainersController containersController = client.ContainersController;
```

## Class Name

`ContainersController`

## Methods

* [Get Containers](../../doc/controllers/containers.md#get-containers)
* [Create Container](../../doc/controllers/containers.md#create-container)
* [Get Container](../../doc/controllers/containers.md#get-container)
* [Update Container](../../doc/controllers/containers.md#update-container)
* [Delete Container](../../doc/controllers/containers.md#delete-container)
* [Get Container Summary](../../doc/controllers/containers.md#get-container-summary)
* [Create Container Job](../../doc/controllers/containers.md#create-container-job)
* [Get Instances](../../doc/controllers/containers.md#get-instances)
* [Create Instances](../../doc/controllers/containers.md#create-instances)
* [Get Instance](../../doc/controllers/containers.md#get-instance)
* [Delete Instance](../../doc/controllers/containers.md#delete-instance)
* [Generate Instance SSH Credentials](../../doc/controllers/containers.md#generate-instance-ssh-credentials)
* [Expire Instance SSH Credentials](../../doc/controllers/containers.md#expire-instance-ssh-credentials)
* [Create Instance Job](../../doc/controllers/containers.md#create-instance-job)
* [Get Instance Volumes](../../doc/controllers/containers.md#get-instance-volumes)
* [Get Instance Telemetry Report](../../doc/controllers/containers.md#get-instance-telemetry-report)
* [Get Instance Telemetry Stream Auth](../../doc/controllers/containers.md#get-instance-telemetry-stream-auth)
* [Get Container Servers](../../doc/controllers/containers.md#get-container-servers)
* [Get Compatible Servers](../../doc/controllers/containers.md#get-compatible-servers)
* [Get Compatible Images](../../doc/controllers/containers.md#get-compatible-images)
* [Get Container Backups](../../doc/controllers/containers.md#get-container-backups)
* [Get Container Backup](../../doc/controllers/containers.md#get-container-backup)
* [Delete Container Backup](../../doc/controllers/containers.md#delete-container-backup)
* [Create Container Backup Job](../../doc/controllers/containers.md#create-container-backup-job)
* [Get Container Backup Logs](../../doc/controllers/containers.md#get-container-backup-logs)
* [Get Container Instances Telemetry](../../doc/controllers/containers.md#get-container-instances-telemetry)
* [Get Instance Console Stream Auth](../../doc/controllers/containers.md#get-instance-console-stream-auth)


# Get Containers

Requires the `containers-view` capability.

```csharp
GetContainersAsync(
    List<Models.Meta10Enum> meta = null,
    List<Models.Include5Enum> include = null,
    Models.Filter8 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `meta` | [`List<Meta10Enum>`](../../doc/models/meta-10-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `include` | [`List<Include5Enum>`](../../doc/models/include-5-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `filter` | [`Filter8`](../../doc/models/filter-8.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1ContainersResponse>`](../../doc/models/v1-containers-response.md)

## Example Usage

```csharp
Filter8 filter = new Filter8
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
    V1ContainersResponse result = await containersController.GetContainersAsync(
        null,
        null,
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


# Create Container

Requires the `containers-deploy` capability.

```csharp
CreateContainerAsync(
    Models.V1ContainersRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1ContainersRequest`](../../doc/models/v1-containers-request.md) | Body, Optional | Parameters for creating a new Container. |

## Response Type

[`Task<Models.V1ContainersResponse1>`](../../doc/models/v1-containers-response-1.md)

## Example Usage

```csharp
try
{
    V1ContainersResponse1 result = await containersController.CreateContainerAsync();
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


# Get Container

Gets a Container.

Requires the `containers-view` capability.

```csharp
GetContainerAsync(
    string containerId,
    List<Models.Meta10Enum> meta = null,
    List<Models.Include5Enum> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested Container. |
| `meta` | [`List<Meta10Enum>`](../../doc/models/meta-10-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `include` | [`List<Include5Enum>`](../../doc/models/include-5-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |

## Response Type

[`Task<Models.V1ContainersResponse2>`](../../doc/models/v1-containers-response-2.md)

## Example Usage

```csharp
string containerId = "containerId4";
try
{
    V1ContainersResponse2 result = await containersController.GetContainerAsync(containerId);
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


# Update Container

Updates the specified Container.

Requires the `containers-manage` capability.

```csharp
UpdateContainerAsync(
    string containerId,
    Models.V1ContainersRequest1 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the Container. |
| `body` | [`V1ContainersRequest1`](../../doc/models/v1-containers-request-1.md) | Body, Optional | Parameters for updating a Container. |

## Response Type

[`Task<Models.V1ContainersResponse3>`](../../doc/models/v1-containers-response-3.md)

## Example Usage

```csharp
string containerId = "containerId4";
try
{
    V1ContainersResponse3 result = await containersController.UpdateContainerAsync(containerId);
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


# Delete Container

Requires the `containers-manage` capability.

```csharp
DeleteContainerAsync(
    string containerId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested Container. |

## Response Type

[`Task<Models.V1ContainersResponse4>`](../../doc/models/v1-containers-response-4.md)

## Example Usage

```csharp
string containerId = "containerId4";
try
{
    V1ContainersResponse4 result = await containersController.DeleteContainerAsync(containerId);
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


# Get Container Summary

Requires the `containers-view` capability.

```csharp
GetContainerSummaryAsync(
    string containerId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested container. |

## Response Type

[`Task<Models.V1ContainersSummaryResponse>`](../../doc/models/v1-containers-summary-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
try
{
    V1ContainersSummaryResponse result = await containersController.GetContainerSummaryAsync(containerId);
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


# Create Container Job

Used to perform different actions on a given Container.

Requires the following capabilities based on the task:
`start`: `containers-manage`
`stop`: `containers-manage`
`reconfigure`: `containers-manage`
`volumes.reconfigure`: `containers-volumes-manage`
`reimage`: `containers-manage`
`scale`: `containers-manage`

```csharp
CreateContainerJobAsync(
    string containerId,
    CreateContainerJobBody body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested container. |
| `body` | [`CreateContainerJobBody`](../../doc/models/containers/create-container-job-body.md) | Body, Optional | This is a container for one-of cases. |

## Response Type

[`Task<Models.V1ContainersTasksResponse>`](../../doc/models/v1-containers-tasks-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
CreateContainerJobBody body = CreateContainerJobBody.FromContainerStartActionTask(
    new ContainerStartActionTask
    {
        Action = "start",
    }
);

try
{
    V1ContainersTasksResponse result = await containersController.CreateContainerJobAsync(
        containerId,
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


# Get Instances

Requires the `containers-view` capability.

```csharp
GetInstancesAsync(
    string containerId,
    List<Models.Include7Enum> include = null,
    Models.Filter9 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the container this instance is created from. |
| `include` | [`List<Include7Enum>`](../../doc/models/include-7-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `filter` | [`Filter9`](../../doc/models/filter-9.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1ContainersInstancesResponse>`](../../doc/models/v1-containers-instances-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
Filter9 filter = new Filter9
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
    V1ContainersInstancesResponse result = await containersController.GetInstancesAsync(
        containerId,
        null,
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


# Create Instances

Manually create Instances of a Container.

Requires the `containers-update` capability.

```csharp
CreateInstancesAsync(
    string containerId,
    List<Models.V1ContainersInstancesRequest> body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the Container this Instance is created from. |
| `body` | [`List<V1ContainersInstancesRequest>`](../../doc/models/v1-containers-instances-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.V1ContainersInstancesResponse1>`](../../doc/models/v1-containers-instances-response-1.md)

## Example Usage

```csharp
string containerId = "containerId4";
List<V1ContainersInstancesRequest> body = new List<V1ContainersInstancesRequest>
{
    new V1ContainersInstancesRequest
    {
        ServerId = "server_id4",
        NewInstances = 142,
    },
};

try
{
    V1ContainersInstancesResponse1 result = await containersController.CreateInstancesAsync(
        containerId,
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


# Get Instance

Requires the `containers-view` capability.

```csharp
GetInstanceAsync(
    string containerId,
    string instanceId,
    List<Models.Include7Enum> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested container. |
| `instanceId` | `string` | Template, Required | The ID for the container instance. |
| `include` | [`List<Include7Enum>`](../../doc/models/include-7-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |

## Response Type

[`Task<Models.V1ContainersInstancesResponse3>`](../../doc/models/v1-containers-instances-response-3.md)

## Example Usage

```csharp
string containerId = "containerId4";
string instanceId = "instanceId6";
try
{
    V1ContainersInstancesResponse3 result = await containersController.GetInstanceAsync(
        containerId,
        instanceId
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


# Delete Instance

Requires the `containers-update` capability.

```csharp
DeleteInstanceAsync(
    string containerId,
    string instanceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested container. |
| `instanceId` | `string` | Template, Required | The ID for the container instance. |

## Response Type

[`Task<Models.V1ContainersInstancesResponse1>`](../../doc/models/v1-containers-instances-response-1.md)

## Example Usage

```csharp
string containerId = "containerId4";
string instanceId = "instanceId6";
try
{
    V1ContainersInstancesResponse1 result = await containersController.DeleteInstanceAsync(
        containerId,
        instanceId
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


# Generate Instance SSH Credentials

Generates credentials for connecting to an Instance via SSH. The generated endpoint/secret can be used to log in via SSH
into the Instance without exposing ports on the container or host.

Requires the `containers-ssh` capability.

```csharp
GenerateInstanceSSHCredentialsAsync(
    string containerId,
    string instanceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested container. |
| `instanceId` | `string` | Template, Required | The ID for the container instance. |

## Response Type

[`Task<Models.V1ContainersInstancesSshResponse>`](../../doc/models/v1-containers-instances-ssh-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
string instanceId = "instanceId6";
try
{
    V1ContainersInstancesSshResponse result = await containersController.GenerateInstanceSSHCredentialsAsync(
        containerId,
        instanceId
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


# Expire Instance SSH Credentials

Instantly expires any SSH credentials generated for this Instance.

Requires the `containers-ssh` capability.

```csharp
ExpireInstanceSSHCredentialsAsync(
    string containerId,
    string instanceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested container. |
| `instanceId` | `string` | Template, Required | The ID for the container instance. |

## Response Type

[`Task<Models.ExpireSSHTokenResponse>`](../../doc/models/expire-ssh-token-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
string instanceId = "instanceId6";
try
{
    ExpireSSHTokenResponse result = await containersController.ExpireInstanceSSHCredentialsAsync(
        containerId,
        instanceId
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


# Create Instance Job

Used to perform different actions on a given Container Instance. Can be used to migrate or undo a migration of a Container Instance.

Requires the `containers-instance-migrate` capability.

```csharp
CreateInstanceJobAsync(
    string containerId,
    string instanceId,
    CreateInstanceJobBody body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested container. |
| `instanceId` | `string` | Template, Required | The ID for the container instance. |
| `body` | [`CreateInstanceJobBody`](../../doc/models/containers/create-instance-job-body.md) | Body, Optional | This is a container for one-of cases. |

## Response Type

[`Task<Models.V1ContainersInstancesTasksResponse>`](../../doc/models/v1-containers-instances-tasks-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
string instanceId = "instanceId6";
CreateInstanceJobBody body = CreateInstanceJobBody.FromRevertMigrationAction(
    new RevertMigrationAction
    {
        Action = "migrate_revert",
    }
);

try
{
    V1ContainersInstancesTasksResponse result = await containersController.CreateInstanceJobAsync(
        containerId,
        instanceId,
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


# Get Instance Volumes

Requires the `containers-view` capability.

```csharp
GetInstanceVolumesAsync(
    string containerId,
    string instanceId,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested Container. |
| `instanceId` | `string` | Template, Required | The ID for the Container Instance. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1ContainersInstancesVolumesResponse>`](../../doc/models/v1-containers-instances-volumes-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
string instanceId = "instanceId6";
try
{
    V1ContainersInstancesVolumesResponse result = await containersController.GetInstanceVolumesAsync(
        containerId,
        instanceId
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


# Get Instance Telemetry Report

Retrieves a point-in-time report of an Instance's resource usage (CPU, RAM, Network, Storage, etc).

Requires the `containers-view` capability.

```csharp
GetInstanceTelemetryReportAsync(
    string containerId,
    string instanceId,
    Models.Filter6 filter = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested container. |
| `instanceId` | `string` | Template, Required | The ID for the container instance. |
| `filter` | [`Filter6`](../../doc/models/filter-6.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |

## Response Type

[`Task<Models.V1ContainersInstancesTelemetryResourcesReportResponse>`](../../doc/models/v1-containers-instances-telemetry-resources-report-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
string instanceId = "instanceId6";
Filter6 filter = new Filter6
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
    V1ContainersInstancesTelemetryResourcesReportResponse result = await containersController.GetInstanceTelemetryReportAsync(
        containerId,
        instanceId,
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


# Get Instance Telemetry Stream Auth

Retrieves an access token and URL to open a websocket to for streaming instance telemetry live.
This connects directly to the compute layer on the server the instance is hosted on, and streams telemetry in real time.

Requires the `containers-view` capability.

```csharp
GetInstanceTelemetryStreamAuthAsync(
    string containerId,
    string instanceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested container. |
| `instanceId` | `string` | Template, Required | The ID for the Container Instance. |

## Response Type

[`Task<Models.V1ContainersInstancesTelemetryResourcesStreamResponse>`](../../doc/models/v1-containers-instances-telemetry-resources-stream-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
string instanceId = "instanceId6";
try
{
    V1ContainersInstancesTelemetryResourcesStreamResponse result = await containersController.GetInstanceTelemetryStreamAuthAsync(
        containerId,
        instanceId
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


# Get Container Servers

Lists all Servers that currently have an Instance of this Container deployed to them.

Requires the `containers-view` capability.

```csharp
GetContainerServersAsync(
    string containerId,
    List<Models.Meta12Enum> meta = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested container. |
| `meta` | [`List<Meta12Enum>`](../../doc/models/meta-12-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1ContainersServersResponse>`](../../doc/models/v1-containers-servers-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
try
{
    V1ContainersServersResponse result = await containersController.GetContainerServersAsync(containerId);
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


# Get Compatible Servers

Gets a list of servers that are compatible with the specified Container and its restrictions (tags, etc).

Requires the `containers-view` capability.

```csharp
GetCompatibleServersAsync(
    string containerId,
    List<Models.Meta13Enum> meta = null,
    List<Models.Include9Enum> include = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested container. |
| `meta` | [`List<Meta13Enum>`](../../doc/models/meta-13-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `include` | [`List<Include9Enum>`](../../doc/models/include-9-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1ContainersServersUsableResponse>`](../../doc/models/v1-containers-servers-usable-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
try
{
    V1ContainersServersUsableResponse result = await containersController.GetCompatibleServersAsync(containerId);
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


# Get Compatible Images

Returns a list of Images that are compatible with the specified Container.
Used to quickly find Images that can be used for reimaging the Container.

Requires the `containers-view` capability.

```csharp
GetCompatibleImagesAsync(
    string containerId,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested Container. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1ContainersCompatibleImagesResponse>`](../../doc/models/v1-containers-compatible-images-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
try
{
    V1ContainersCompatibleImagesResponse result = await containersController.GetCompatibleImagesAsync(containerId);
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


# Get Container Backups

Requires the `containers-backups-view` capability.

```csharp
GetContainerBackupsAsync(
    string containerId,
    List<Models.Include10Enum> include = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested Container. |
| `include` | [`List<Include10Enum>`](../../doc/models/include-10-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1ContainersBackupsResponse>`](../../doc/models/v1-containers-backups-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
try
{
    V1ContainersBackupsResponse result = await containersController.GetContainerBackupsAsync(containerId);
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


# Get Container Backup

Gets the specified Container Backup.

Requires the `containers-backups-view` capability.

```csharp
GetContainerBackupAsync(
    string containerId,
    string backupId,
    List<Models.Include10Enum> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested container. |
| `backupId` | `string` | Template, Required | The ID for the container backup. |
| `include` | [`List<Include10Enum>`](../../doc/models/include-10-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |

## Response Type

[`Task<Models.V1ContainersBackupsResponse1>`](../../doc/models/v1-containers-backups-response-1.md)

## Example Usage

```csharp
string containerId = "containerId4";
string backupId = "backupId6";
try
{
    V1ContainersBackupsResponse1 result = await containersController.GetContainerBackupAsync(
        containerId,
        backupId
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


# Delete Container Backup

Requires the `containers-backups-manage` capability.

```csharp
DeleteContainerBackupAsync(
    string containerId,
    string backupId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the container. |
| `backupId` | `string` | Template, Required | The ID of the container backup. |

## Response Type

[`Task<Models.TaskResponse>`](../../doc/models/task-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
string backupId = "backupId6";
try
{
    TaskResponse result = await containersController.DeleteContainerBackupAsync(
        containerId,
        backupId
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


# Create Container Backup Job

Creates a Container Backup Job.
Can be used to restore a Container Backup for a given Container Instance.

Requires the `containers-backups-manage` capability.

```csharp
CreateContainerBackupJobAsync(
    string containerId,
    string backupId,
    Models.V1ContainersBackupsTasksRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested container. |
| `backupId` | `string` | Template, Required | The ID of the backup. |
| `body` | [`V1ContainersBackupsTasksRequest`](../../doc/models/v1-containers-backups-tasks-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.V1ContainersBackupsTasksResponse>`](../../doc/models/v1-containers-backups-tasks-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
string backupId = "backupId6";
V1ContainersBackupsTasksRequest body = new V1ContainersBackupsTasksRequest
{
    Action = "restore",
    Contents = new Contents11
    {
        InstanceId = "instance_id4",
    },
};

try
{
    V1ContainersBackupsTasksResponse result = await containersController.CreateContainerBackupJobAsync(
        containerId,
        backupId,
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


# Get Container Backup Logs

Requires the `containers-backups-view` capability.

```csharp
GetContainerBackupLogsAsync(
    string containerId,
    string backupId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the requested container. |
| `backupId` | `string` | Template, Required | The ID for the container backup. |

## Response Type

[`Task<Models.V1ContainersBackupsLogsResponse>`](../../doc/models/v1-containers-backups-logs-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
string backupId = "backupId6";
try
{
    V1ContainersBackupsLogsResponse result = await containersController.GetContainerBackupLogsAsync(
        containerId,
        backupId
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


# Get Container Instances Telemetry

Gets a list of telemetry points describing the number and state of all Instances of this Container at a point in time.

Requires the `containers-view` capability.

```csharp
GetContainerInstancesTelemetryAsync(
    string containerId,
    Models.Filter6 filter = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the desired Container |
| `filter` | [`Filter6`](../../doc/models/filter-6.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |

## Response Type

[`Task<Models.V1ContainersTelemetryInstancesResponse>`](../../doc/models/v1-containers-telemetry-instances-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
Filter6 filter = new Filter6
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
    V1ContainersTelemetryInstancesResponse result = await containersController.GetContainerInstancesTelemetryAsync(
        containerId,
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


# Get Instance Console Stream Auth

Returns the authorization information necessary to connect to a Container Instance's console.
To connect via WebSocket, use the returned address, and append the returned token as a URL parameter: `<address>?token=<token>`.

Requires the `containers-console` capability.

```csharp
GetInstanceConsoleStreamAuthAsync(
    string containerId,
    string instanceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID for the Container |
| `instanceId` | `string` | Template, Required | The ID of the Instance. |

## Response Type

[`Task<Models.V1ContainersInstancesConsoleResponse>`](../../doc/models/v1-containers-instances-console-response.md)

## Example Usage

```csharp
string containerId = "containerId4";
string instanceId = "instanceId6";
try
{
    V1ContainersInstancesConsoleResponse result = await containersController.GetInstanceConsoleStreamAuthAsync(
        containerId,
        instanceId
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

