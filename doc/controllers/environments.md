# Environments

Environments are logical groupings of containers. All containers deployed inside an environment automatically have a private network built between them, enabling seamless communication.

```csharp
EnvironmentsController environmentsController = client.EnvironmentsController;
```

## Class Name

`EnvironmentsController`

## Methods

* [Get Environments](../../doc/controllers/environments.md#get-environments)
* [Create Environment](../../doc/controllers/environments.md#create-environment)
* [Get Environment](../../doc/controllers/environments.md#get-environment)
* [Update Environment](../../doc/controllers/environments.md#update-environment)
* [Delete Environment](../../doc/controllers/environments.md#delete-environment)
* [Create Environment Job](../../doc/controllers/environments.md#create-environment-job)
* [Get Environment Summary](../../doc/controllers/environments.md#get-environment-summary)
* [Get Environment Deployments](../../doc/controllers/environments.md#get-environment-deployments)
* [Get Load Balancer Service](../../doc/controllers/environments.md#get-load-balancer-service)
* [Create Load Balancer Service Job](../../doc/controllers/environments.md#create-load-balancer-service-job)
* [Get Load Balancer Telemetry Report](../../doc/controllers/environments.md#get-load-balancer-telemetry-report)
* [Get Load Balancer Latest Telemetry Report](../../doc/controllers/environments.md#get-load-balancer-latest-telemetry-report)
* [Get Load Balancer Telemetry Latest Controllers](../../doc/controllers/environments.md#get-load-balancer-telemetry-latest-controllers)
* [Create Discovery Service Job](../../doc/controllers/environments.md#create-discovery-service-job)
* [Create Scheduler Service Job](../../doc/controllers/environments.md#create-scheduler-service-job)
* [Get VPN Service](../../doc/controllers/environments.md#get-vpn-service)
* [Get VPN Logins](../../doc/controllers/environments.md#get-vpn-logins)
* [Get VPN Users](../../doc/controllers/environments.md#get-vpn-users)
* [Create VPN User](../../doc/controllers/environments.md#create-vpn-user)
* [Delete VPN User](../../doc/controllers/environments.md#delete-vpn-user)
* [Create VPN Service Job](../../doc/controllers/environments.md#create-vpn-service-job)
* [Get Environment Instances Telemetry](../../doc/controllers/environments.md#get-environment-instances-telemetry)
* [Get Scoped Variables](../../doc/controllers/environments.md#get-scoped-variables)
* [Create Scoped Variable](../../doc/controllers/environments.md#create-scoped-variable)
* [Get Scoped Variable](../../doc/controllers/environments.md#get-scoped-variable)
* [Update Scoped Variable](../../doc/controllers/environments.md#update-scoped-variable)
* [Delete Scoped Variable](../../doc/controllers/environments.md#delete-scoped-variable)


# Get Environments

Requires the `environments-view` capability.

```csharp
GetEnvironmentsAsync(
    List<Models.Meta8Enum> meta = null,
    List<Models.Include2Enum> include = null,
    Models.Filter3 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `meta` | [`List<Meta8Enum>`](../../doc/models/meta-8-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `include` | [`List<Include2Enum>`](../../doc/models/include-2-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `filter` | [`Filter3`](../../doc/models/filter-3.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1EnvironmentsResponse>`](../../doc/models/v1-environments-response.md)

## Example Usage

```csharp
try
{
    V1EnvironmentsResponse result = await environmentsController.GetEnvironmentsAsync();
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


# Create Environment

Requires the `environments-create` capability.

```csharp
CreateEnvironmentAsync(
    Models.V1EnvironmentsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1EnvironmentsRequest`](../../doc/models/v1-environments-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.V1EnvironmentsResponse1>`](../../doc/models/v1-environments-response-1.md)

## Example Usage

```csharp
try
{
    V1EnvironmentsResponse1 result = await environmentsController.CreateEnvironmentAsync();
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


# Get Environment

Requires the `environments-view` capability.

```csharp
GetEnvironmentAsync(
    string environmentId,
    List<Models.Meta8Enum> meta = null,
    List<Models.Include2Enum> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the requested environment. |
| `meta` | [`List<Meta8Enum>`](../../doc/models/meta-8-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `include` | [`List<Include2Enum>`](../../doc/models/include-2-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |

## Response Type

[`Task<Models.V1EnvironmentsResponse2>`](../../doc/models/v1-environments-response-2.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
try
{
    V1EnvironmentsResponse2 result = await environmentsController.GetEnvironmentAsync(environmentId);
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


# Update Environment

Updates the specificed Environment.

Requires the `environments-manage` capability.

```csharp
UpdateEnvironmentAsync(
    string environmentId,
    Models.V1EnvironmentsRequest1 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the requested Environment. |
| `body` | [`V1EnvironmentsRequest1`](../../doc/models/v1-environments-request-1.md) | Body, Optional | Parameters for updating an Environment. |

## Response Type

[`Task<Models.V1EnvironmentsResponse1>`](../../doc/models/v1-environments-response-1.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
try
{
    V1EnvironmentsResponse1 result = await environmentsController.UpdateEnvironmentAsync(environmentId);
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


# Delete Environment

Requires the `environments-manage` capability.

```csharp
DeleteEnvironmentAsync(
    string environmentId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the requested Environment. |

## Response Type

[`Task<Models.V1EnvironmentsResponse4>`](../../doc/models/v1-environments-response-4.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
try
{
    V1EnvironmentsResponse4 result = await environmentsController.DeleteEnvironmentAsync(environmentId);
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


# Create Environment Job

Create a job for an Environment, such as 'start' or 'stop'.

Requires the `environments-manage` capability.

```csharp
CreateEnvironmentJobAsync(
    string environmentId,
    CreateEnvironmentJobBody body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the requested Environment. |
| `body` | [`CreateEnvironmentJobBody`](../../doc/models/containers/create-environment-job-body.md) | Body, Optional | This is a container for one-of cases. |

## Response Type

[`Task<Models.TaskResponse>`](../../doc/models/task-response.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
CreateEnvironmentJobBody body = CreateEnvironmentJobBody.FromEnvironmentStartAction(
    new EnvironmentStartAction
    {
        Action = "start",
    }
);

try
{
    TaskResponse result = await environmentsController.CreateEnvironmentJobAsync(
        environmentId,
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


# Get Environment Summary

Gets the summary of an Environment. Contains useful and relevant data/statistics that would otherwise be several separate API calls.

Requires the `environments-view` capability.

```csharp
GetEnvironmentSummaryAsync(
    string environmentId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the requested environment. |

## Response Type

[`Task<Models.V1EnvironmentsSummaryResponse>`](../../doc/models/v1-environments-summary-response.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
try
{
    V1EnvironmentsSummaryResponse result = await environmentsController.GetEnvironmentSummaryAsync(environmentId);
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


# Get Environment Deployments

Gets a list of all deployments in the specified Environment.

Requires the `environments-view` capability.

```csharp
GetEnvironmentDeploymentsAsync(
    string environmentId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the Environment to get the list of deployments for. |

## Response Type

[`Task<Models.V1EnvironmentsDeploymentsResponse>`](../../doc/models/v1-environments-deployments-response.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
try
{
    V1EnvironmentsDeploymentsResponse result = await environmentsController.GetEnvironmentDeploymentsAsync(environmentId);
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


# Get Load Balancer Service

Requires the `environments-view` capability.

```csharp
GetLoadBalancerServiceAsync(
    string environmentId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The environmentId where the load balancer resides. |

## Response Type

[`Task<Models.V1EnvironmentsServicesLbResponse>`](../../doc/models/v1-environments-services-lb-response.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
try
{
    V1EnvironmentsServicesLbResponse result = await environmentsController.GetLoadBalancerServiceAsync(environmentId);
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


# Create Load Balancer Service Job

Creates a task that will update the load balancer's configuration.

```csharp
CreateLoadBalancerServiceJobAsync(
    string environmentId,
    Models.V1EnvironmentsServicesLbTasksRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the environment where this load balancer resides. |
| `body` | [`V1EnvironmentsServicesLbTasksRequest`](../../doc/models/v1-environments-services-lb-tasks-request.md) | Body, Optional | Parameters for reconfiguring a load balancer. |

## Response Type

[`Task<Models.V1EnvironmentsServicesLbTasksResponse>`](../../doc/models/v1-environments-services-lb-tasks-response.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
V1EnvironmentsServicesLbTasksRequest body = new V1EnvironmentsServicesLbTasksRequest
{
    Action = "reconfigure",
    Contents = new Contents8
    {
    },
};

try
{
    V1EnvironmentsServicesLbTasksResponse result = await environmentsController.CreateLoadBalancerServiceJobAsync(
        environmentId,
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


# Get Load Balancer Telemetry Report

Fetches a telemetry report for Cycle's native load balancer for the specified range.

## Permissions

Requires the `environments-view` capability. Also requires the user to have access specifically to the requested Environment.

```csharp
GetLoadBalancerTelemetryReportAsync(
    string environmentId,
    Models.Filter4 filter = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The environmentId where the load balancer resides. |
| `filter` | [`Filter4`](../../doc/models/filter-4.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |

## Response Type

[`Task<Models.V1EnvironmentsServicesLbTelemetryReportResponse>`](../../doc/models/v1-environments-services-lb-telemetry-report-response.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
Filter4 filter = new Filter4
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
    V1EnvironmentsServicesLbTelemetryReportResponse result = await environmentsController.GetLoadBalancerTelemetryReportAsync(
        environmentId,
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


# Get Load Balancer Latest Telemetry Report

Fetches the latest telemetry report for Cycle's native load balancer. Provides detailed information on a per-instance basis.

## Permissions

Requires the `environments-view` capability. Also requires the user to have access specifically to the requested Environment.

```csharp
GetLoadBalancerLatestTelemetryReportAsync(
    string environmentId,
    Models.Filter5 filter)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The environmentId where the load balancer resides. |
| `filter` | [`Filter5`](../../doc/models/filter-5.md) | Query, Required | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for.<br><br>### Required Filter<br><br>On this endpoint, you MUST pass filter[controller]. |

## Response Type

[`Task<Models.V1EnvironmentsServicesLbTelemetryLatestResponse>`](../../doc/models/v1-environments-services-lb-telemetry-latest-response.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
Filter5 filter = new Filter5
{
};

try
{
    V1EnvironmentsServicesLbTelemetryLatestResponse result = await environmentsController.GetLoadBalancerLatestTelemetryReportAsync(
        environmentId,
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


# Get Load Balancer Telemetry Latest Controllers

Gets the controller information for the specified load balancer. Returns a similar struct to the 'latest' load balancer telemetry call, but does NOT return snapshots, just the controller information.

## Permissions

Requires the `environments-view` capability. Also requires the user to have access specifically to the requested Environment.

```csharp
GetLoadBalancerTelemetryLatestControllersAsync(
    string environmentId,
    List<Models.Include4Enum> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the environment of the desired load balancer. |
| `include` | [`List<Include4Enum>`](../../doc/models/include-4-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |

## Response Type

[`Task<Models.V1EnvironmentsServicesLbTelemetryLatestControllersResponse>`](../../doc/models/v1-environments-services-lb-telemetry-latest-controllers-response.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
try
{
    V1EnvironmentsServicesLbTelemetryLatestControllersResponse result = await environmentsController.GetLoadBalancerTelemetryLatestControllersAsync(environmentId);
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


# Create Discovery Service Job

Creates a task that will update the discovery service's configuration.

```csharp
CreateDiscoveryServiceJobAsync(
    string environmentId,
    Models.V1EnvironmentsServicesDiscoveryTasksRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the environment where this discovery service resides. |
| `body` | [`V1EnvironmentsServicesDiscoveryTasksRequest`](../../doc/models/v1-environments-services-discovery-tasks-request.md) | Body, Optional | Parameters for reconfiguring a discovery service. |

## Response Type

[`Task<Models.TaskResponse>`](../../doc/models/task-response.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
V1EnvironmentsServicesDiscoveryTasksRequest body = new V1EnvironmentsServicesDiscoveryTasksRequest
{
    Action = "reconfigure",
    Contents = new Contents9
    {
    },
};

try
{
    TaskResponse result = await environmentsController.CreateDiscoveryServiceJobAsync(
        environmentId,
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


# Create Scheduler Service Job

Creates a task that will update the scheduler service's configuration.

```csharp
CreateSchedulerServiceJobAsync(
    string environmentId,
    Models.V1EnvironmentsServicesSchedulerTasksRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the environment where this scheduler service resides. |
| `body` | [`V1EnvironmentsServicesSchedulerTasksRequest`](../../doc/models/v1-environments-services-scheduler-tasks-request.md) | Body, Optional | Parameters for reconfiguring a scheduler service. |

## Response Type

[`Task<Models.V1EnvironmentsServicesSchedulerTasksResponse>`](../../doc/models/v1-environments-services-scheduler-tasks-response.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
V1EnvironmentsServicesSchedulerTasksRequest body = new V1EnvironmentsServicesSchedulerTasksRequest
{
    Action = "reconfigure",
    Contents = new Contents10
    {
    },
};

try
{
    V1EnvironmentsServicesSchedulerTasksResponse result = await environmentsController.CreateSchedulerServiceJobAsync(
        environmentId,
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


# Get VPN Service

Requires the `environments-vpn` capability.

```csharp
GetVPNServiceAsync(
    string environmentId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The environmentId where the VPN resides. |

## Response Type

[`Task<Models.V1EnvironmentsServicesVpnResponse>`](../../doc/models/v1-environments-services-vpn-response.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
try
{
    V1EnvironmentsServicesVpnResponse result = await environmentsController.GetVPNServiceAsync(environmentId);
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


# Get VPN Logins

Requires the `environments-vpn` capability.

```csharp
GetVPNLoginsAsync(
    string environmentId,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The environmentId where the VPN resides. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.VPNInfoEnvironmentService>`](../../doc/models/vpn-info-environment-service.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
try
{
    VPNInfoEnvironmentService result = await environmentsController.GetVPNLoginsAsync(environmentId);
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


# Get VPN Users

Requires the `environments-vpn-manage` capability.

```csharp
GetVPNUsersAsync(
    string environmentId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The environmentId where the VPN service resides. |

## Response Type

[`Task<Models.GetVPNUsersReturn>`](../../doc/models/get-vpn-users-return.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
try
{
    GetVPNUsersReturn result = await environmentsController.GetVPNUsersAsync(environmentId);
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


# Create VPN User

Requires the `environments-vpn-manage` capability.

```csharp
CreateVPNUserAsync(
    string environmentId,
    Models.V1EnvironmentsServicesVpnUsersRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The environmentId where the VPN service resides. |
| `body` | [`V1EnvironmentsServicesVpnUsersRequest`](../../doc/models/v1-environments-services-vpn-users-request.md) | Body, Optional | Parameters for creating a new VPN user. |

## Response Type

[`Task<Models.V1EnvironmentsServicesVpnUsersResponse>`](../../doc/models/v1-environments-services-vpn-users-response.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
try
{
    V1EnvironmentsServicesVpnUsersResponse result = await environmentsController.CreateVPNUserAsync(environmentId);
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


# Delete VPN User

Requires the `environments-vpn-manage` capability.

```csharp
DeleteVPNUserAsync(
    string environmentId,
    string userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The environmentId where the VPN service the given user belongs to resides. |
| `userId` | `string` | Template, Required | The userId of the user to be deleted. |

## Response Type

[`Task<Models.VPNUserDeleteReturn>`](../../doc/models/vpn-user-delete-return.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
string userId = "userId0";
try
{
    VPNUserDeleteReturn result = await environmentsController.DeleteVPNUserAsync(
        environmentId,
        userId
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


# Create VPN Service Job

Used to reconfigure or reset the Environment VPN. Requires the `environments-vpn-manage` capability.

```csharp
CreateVPNServiceJobAsync(
    string environmentId,
    CreateVPNServiceJobBody body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the Environment the VPN service resides in. |
| `body` | [`CreateVPNServiceJobBody`](../../doc/models/containers/create-vpn-service-job-body.md) | Body, Optional | This is a container for one-of cases. |

## Response Type

[`Task<Models.V1EnvironmentsServicesVpnTasksResponse>`](../../doc/models/v1-environments-services-vpn-tasks-response.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
CreateVPNServiceJobBody body = CreateVPNServiceJobBody.FromVpnResetTask(
    new VpnResetTask
    {
        Action = "reset",
    }
);

try
{
    V1EnvironmentsServicesVpnTasksResponse result = await environmentsController.CreateVPNServiceJobAsync(
        environmentId,
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


# Get Environment Instances Telemetry

Get telemetry points on the number of instances and their states over a range of time.

Requires the `environments-view` capability.

```csharp
GetEnvironmentInstancesTelemetryAsync(
    string environmentId,
    Models.Filter6 filter = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the desired Environment |
| `filter` | [`Filter6`](../../doc/models/filter-6.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |

## Response Type

[`Task<Models.V1EnvironmentsTelemetryInstancesResponse>`](../../doc/models/v1-environments-telemetry-instances-response.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
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
    V1EnvironmentsTelemetryInstancesResponse result = await environmentsController.GetEnvironmentInstancesTelemetryAsync(
        environmentId,
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


# Get Scoped Variables

Requires the `scoped-variables-view` capability.

```csharp
GetScopedVariablesAsync(
    string environmentId,
    Models.Filter7 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the requested Environment. |
| `filter` | [`Filter7`](../../doc/models/filter-7.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1EnvironmentsScopedVariablesResponse>`](../../doc/models/v1-environments-scoped-variables-response.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
try
{
    V1EnvironmentsScopedVariablesResponse result = await environmentsController.GetScopedVariablesAsync(environmentId);
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


# Create Scoped Variable

Requires the `scoped-variables-manage` capability.

```csharp
CreateScopedVariableAsync(
    string environmentId,
    Models.V1EnvironmentsScopedVariablesRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the requested Environment. |
| `body` | [`V1EnvironmentsScopedVariablesRequest`](../../doc/models/v1-environments-scoped-variables-request.md) | Body, Optional | Parameters for creating a Scoped Variable. |

## Response Type

[`Task<Models.V1EnvironmentsScopedVariablesResponse1>`](../../doc/models/v1-environments-scoped-variables-response-1.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
V1EnvironmentsScopedVariablesRequest body = new V1EnvironmentsScopedVariablesRequest
{
    Identifier = "identifier6",
    Scope = new ScopedVariableScope
    {
        Containers = new Containers1
        {
            MGlobal = false,
            Ids = new List<string>
            {
                "ids3",
                "ids4",
                "ids5",
            },
            Identifiers = new List<string>
            {
                "identifiers8",
                "identifiers9",
            },
        },
    },
    Source = V1EnvironmentsScopedVariablesRequestSource.FromRawScopedVariableSource(
        new RawScopedVariableSource
        {
            Type = "raw",
            Details = new Details23
            {
                MValue = "value2",
                Blob = false,
            },
        }
    ),
};

try
{
    V1EnvironmentsScopedVariablesResponse1 result = await environmentsController.CreateScopedVariableAsync(
        environmentId,
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


# Get Scoped Variable

Requires the `scoped-variables-view` capability.

```csharp
GetScopedVariableAsync(
    string environmentId,
    string scopedVariableId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the requested Environment. |
| `scopedVariableId` | `string` | Template, Required | The ID of the requested Scoped Variable. |

## Response Type

[`Task<Models.V1EnvironmentsScopedVariablesResponse1>`](../../doc/models/v1-environments-scoped-variables-response-1.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
string scopedVariableId = "scopedVariableId6";
try
{
    V1EnvironmentsScopedVariablesResponse1 result = await environmentsController.GetScopedVariableAsync(
        environmentId,
        scopedVariableId
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


# Update Scoped Variable

Requires the `scoped-variables-manage` capability.

```csharp
UpdateScopedVariableAsync(
    string environmentId,
    string scopedVariableId,
    Models.V1EnvironmentsScopedVariablesRequest1 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the requested endpointnvironment. |
| `scopedVariableId` | `string` | Template, Required | The ID of the requested Scoped Variable. |
| `body` | [`V1EnvironmentsScopedVariablesRequest1`](../../doc/models/v1-environments-scoped-variables-request-1.md) | Body, Optional | Parameters for updating a Scoped Variable. |

## Response Type

[`Task<Models.V1EnvironmentsScopedVariablesResponse1>`](../../doc/models/v1-environments-scoped-variables-response-1.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
string scopedVariableId = "scopedVariableId6";
try
{
    V1EnvironmentsScopedVariablesResponse1 result = await environmentsController.UpdateScopedVariableAsync(
        environmentId,
        scopedVariableId
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


# Delete Scoped Variable

Requires the `scoped-variables-manage` capability.

```csharp
DeleteScopedVariableAsync(
    string environmentId,
    string scopedVariableId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `environmentId` | `string` | Template, Required | The ID of the requested Environment. |
| `scopedVariableId` | `string` | Template, Required | The ID of the requested Scoped Variable. |

## Response Type

[`Task<Models.V1EnvironmentsScopedVariablesResponse4>`](../../doc/models/v1-environments-scoped-variables-response-4.md)

## Example Usage

```csharp
string environmentId = "environmentId8";
string scopedVariableId = "scopedVariableId6";
try
{
    V1EnvironmentsScopedVariablesResponse4 result = await environmentsController.DeleteScopedVariableAsync(
        environmentId,
        scopedVariableId
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

