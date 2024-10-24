# Pipelines

From simple tasks like importing an image, to complex sequences that affect entire clusters, Deployment Pipelines make it easy to automate nearly any task within Cycle.

```csharp
PipelinesController pipelinesController = client.PipelinesController;
```

## Class Name

`PipelinesController`

## Methods

* [Get Pipelines](../../doc/controllers/pipelines.md#get-pipelines)
* [Create Pipeline](../../doc/controllers/pipelines.md#create-pipeline)
* [Get Pipeline](../../doc/controllers/pipelines.md#get-pipeline)
* [Update Pipeline](../../doc/controllers/pipelines.md#update-pipeline)
* [Delete Pipeline](../../doc/controllers/pipelines.md#delete-pipeline)
* [Get Pipeline Runs](../../doc/controllers/pipelines.md#get-pipeline-runs)
* [Create Pipeline Job](../../doc/controllers/pipelines.md#create-pipeline-job)
* [Get Pipeline Trigger Keys](../../doc/controllers/pipelines.md#get-pipeline-trigger-keys)
* [Create Pipeline Trigger Key](../../doc/controllers/pipelines.md#create-pipeline-trigger-key)
* [Get Pipeline Trigger Key](../../doc/controllers/pipelines.md#get-pipeline-trigger-key)
* [Update Pipeline Trigger Key](../../doc/controllers/pipelines.md#update-pipeline-trigger-key)
* [Delete Pipeline Trigger Key](../../doc/controllers/pipelines.md#delete-pipeline-trigger-key)


# Get Pipelines

Requires the `pipelines-view` capability.

```csharp
GetPipelinesAsync(
    List<Models.Include38Enum> include = null,
    Models.Filter31 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `include` | [`List<Include38Enum>`](../../doc/models/include-38-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `filter` | [`Filter31`](../../doc/models/filter-31.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1PipelinesResponse>`](../../doc/models/v1-pipelines-response.md)

## Example Usage

```csharp
try
{
    V1PipelinesResponse result = await pipelinesController.GetPipelinesAsync();
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


# Create Pipeline

Requires the `pipelines-manage` capability.

```csharp
CreatePipelineAsync(
    Models.V1PipelinesRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1PipelinesRequest`](../../doc/models/v1-pipelines-request.md) | Body, Optional | Parameters for creating a new Pipeline. |

## Response Type

[`Task<Models.V1PipelinesResponse1>`](../../doc/models/v1-pipelines-response-1.md)

## Example Usage

```csharp
try
{
    V1PipelinesResponse1 result = await pipelinesController.CreatePipelineAsync();
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


# Get Pipeline

Requires the `pipelines-view` capability.

```csharp
GetPipelineAsync(
    string pipelineId,
    List<Models.Include38Enum> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pipelineId` | `string` | Template, Required | The ID of the Pipeline. |
| `include` | [`List<Include38Enum>`](../../doc/models/include-38-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |

## Response Type

[`Task<Models.V1PipelinesResponse2>`](../../doc/models/v1-pipelines-response-2.md)

## Example Usage

```csharp
string pipelineId = "pipelineId6";
try
{
    V1PipelinesResponse2 result = await pipelinesController.GetPipelineAsync(pipelineId);
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


# Update Pipeline

Requires the `pipelines-manage` capability.

```csharp
UpdatePipelineAsync(
    string pipelineId,
    Models.V1PipelinesRequest1 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pipelineId` | `string` | Template, Required | The ID of the Pipeline. |
| `body` | [`V1PipelinesRequest1`](../../doc/models/v1-pipelines-request-1.md) | Body, Optional | Parameters for updating a Pipeline. |

## Response Type

[`Task<Models.V1PipelinesResponse1>`](../../doc/models/v1-pipelines-response-1.md)

## Example Usage

```csharp
string pipelineId = "pipelineId6";
try
{
    V1PipelinesResponse1 result = await pipelinesController.UpdatePipelineAsync(pipelineId);
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


# Delete Pipeline

Requires the `pipelines-manage` capability.

```csharp
DeletePipelineAsync(
    string pipelineId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pipelineId` | `string` | Template, Required | The ID of the Pipeline. |

## Response Type

[`Task<Models.V1PipelinesResponse4>`](../../doc/models/v1-pipelines-response-4.md)

## Example Usage

```csharp
string pipelineId = "pipelineId6";
try
{
    V1PipelinesResponse4 result = await pipelinesController.DeletePipelineAsync(pipelineId);
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


# Get Pipeline Runs

List information about times this Pipeline has run.

Requires the `pipelines-view` capability.

```csharp
GetPipelineRunsAsync(
    string pipelineId,
    List<string> sort = null,
    List<Models.Include12Enum> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pipelineId` | `string` | Template, Required | The ID of the pipeline. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `include` | [`List<Include12Enum>`](../../doc/models/include-12-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |

## Response Type

[`Task<Models.V1PipelinesRunsResponse>`](../../doc/models/v1-pipelines-runs-response.md)

## Example Usage

```csharp
string pipelineId = "pipelineId6";
try
{
    V1PipelinesRunsResponse result = await pipelinesController.GetPipelineRunsAsync(pipelineId);
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


# Create Pipeline Job

Requires the `pipelines-manage` capability.

```csharp
CreatePipelineJobAsync(
    string pipelineId,
    Models.V1PipelinesTasksRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pipelineId` | `string` | Template, Required | The ID of the Pipeline. |
| `body` | [`V1PipelinesTasksRequest`](../../doc/models/v1-pipelines-tasks-request.md) | Body, Optional | Parameters for creating a new Pipeline job. |

## Response Type

[`Task<Models.V1PipelinesTasksResponse>`](../../doc/models/v1-pipelines-tasks-response.md)

## Example Usage

```csharp
string pipelineId = "pipelineId6";
V1PipelinesTasksRequest body = new V1PipelinesTasksRequest
{
    Action = "trigger",
};

try
{
    V1PipelinesTasksResponse result = await pipelinesController.CreatePipelineJobAsync(
        pipelineId,
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


# Get Pipeline Trigger Keys

Requires the `pipelines-manage` capability.

```csharp
GetPipelineTriggerKeysAsync(
    string pipelineId,
    Models.Filter32 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pipelineId` | `string` | Template, Required | The ID of the Pipeline. |
| `filter` | [`Filter32`](../../doc/models/filter-32.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1PipelinesKeysResponse>`](../../doc/models/v1-pipelines-keys-response.md)

## Example Usage

```csharp
string pipelineId = "pipelineId6";
try
{
    V1PipelinesKeysResponse result = await pipelinesController.GetPipelineTriggerKeysAsync(pipelineId);
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


# Create Pipeline Trigger Key

Requires the `pipelines-manage` capability.

```csharp
CreatePipelineTriggerKeyAsync(
    string pipelineId,
    Models.V1PipelinesKeysRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pipelineId` | `string` | Template, Required | The ID of the Pipeline. |
| `body` | [`V1PipelinesKeysRequest`](../../doc/models/v1-pipelines-keys-request.md) | Body, Optional | Parameters for creating a new Pipeline Trigger Key. |

## Response Type

[`Task<Models.V1PipelinesKeysResponse1>`](../../doc/models/v1-pipelines-keys-response-1.md)

## Example Usage

```csharp
string pipelineId = "pipelineId6";
try
{
    V1PipelinesKeysResponse1 result = await pipelinesController.CreatePipelineTriggerKeyAsync(pipelineId);
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


# Get Pipeline Trigger Key

Requires the `pipelines-manage` capability.

```csharp
GetPipelineTriggerKeyAsync(
    string pipelineId,
    string triggerKeyId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pipelineId` | `string` | Template, Required | The ID of the Pipeline. |
| `triggerKeyId` | `string` | Template, Required | The ID of the Trigger Key. |

## Response Type

[`Task<Models.V1PipelinesKeysResponse2>`](../../doc/models/v1-pipelines-keys-response-2.md)

## Example Usage

```csharp
string pipelineId = "pipelineId6";
string triggerKeyId = "triggerKeyId4";
try
{
    V1PipelinesKeysResponse2 result = await pipelinesController.GetPipelineTriggerKeyAsync(
        pipelineId,
        triggerKeyId
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


# Update Pipeline Trigger Key

Requires the `pipelines-manage` capability.

```csharp
UpdatePipelineTriggerKeyAsync(
    string pipelineId,
    string triggerKeyId,
    Models.V1PipelinesKeysRequest1 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pipelineId` | `string` | Template, Required | The ID of the Pipeline. |
| `triggerKeyId` | `string` | Template, Required | The ID of the Trigger Key. |
| `body` | [`V1PipelinesKeysRequest1`](../../doc/models/v1-pipelines-keys-request-1.md) | Body, Optional | - |

## Response Type

[`Task<Models.V1PipelinesKeysResponse3>`](../../doc/models/v1-pipelines-keys-response-3.md)

## Example Usage

```csharp
string pipelineId = "pipelineId6";
string triggerKeyId = "triggerKeyId4";
try
{
    V1PipelinesKeysResponse3 result = await pipelinesController.UpdatePipelineTriggerKeyAsync(
        pipelineId,
        triggerKeyId
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


# Delete Pipeline Trigger Key

Requires the `pipelines-manage` capability.

```csharp
DeletePipelineTriggerKeyAsync(
    string pipelineId,
    string triggerKeyId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `pipelineId` | `string` | Template, Required | The ID of the Pipeline. |
| `triggerKeyId` | `string` | Template, Required | The ID of the Trigger Key. |

## Response Type

[`Task<Models.V1PipelinesKeysResponse3>`](../../doc/models/v1-pipelines-keys-response-3.md)

## Example Usage

```csharp
string pipelineId = "pipelineId6";
string triggerKeyId = "triggerKeyId4";
try
{
    V1PipelinesKeysResponse3 result = await pipelinesController.DeletePipelineTriggerKeyAsync(
        pipelineId,
        triggerKeyId
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

