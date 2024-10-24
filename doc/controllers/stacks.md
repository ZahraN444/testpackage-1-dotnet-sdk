# Stacks

Stacks offer a powerful way to declarative manage multiple containers, and their deployments to the Cycle platform. Using stacks, you are able to configure every aspect of your applications ahead of time, save it to your version controlled repo, and have Cycle automate the deployment any time you make a push.

```csharp
StacksController stacksController = client.StacksController;
```

## Class Name

`StacksController`

## Methods

* [Get Stacks](../../doc/controllers/stacks.md#get-stacks)
* [Create Stack](../../doc/controllers/stacks.md#create-stack)
* [Get Stack](../../doc/controllers/stacks.md#get-stack)
* [Update Stack](../../doc/controllers/stacks.md#update-stack)
* [Delete Stack](../../doc/controllers/stacks.md#delete-stack)
* [Create Stack Job](../../doc/controllers/stacks.md#create-stack-job)
* [Lookup Stack Build](../../doc/controllers/stacks.md#lookup-stack-build)
* [Get Stack Builds](../../doc/controllers/stacks.md#get-stack-builds)
* [Create Stack Build](../../doc/controllers/stacks.md#create-stack-build)
* [Get Stack Build](../../doc/controllers/stacks.md#get-stack-build)
* [Delete Stack Build](../../doc/controllers/stacks.md#delete-stack-build)
* [Create Stack Build Job](../../doc/controllers/stacks.md#create-stack-build-job)


# Get Stacks

Requires the `stacks-view` permission.

```csharp
GetStacksAsync(
    List<Models.Meta30Enum> meta = null,
    List<Models.Include12Enum> include = null,
    Models.Filter28 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `meta` | [`List<Meta30Enum>`](../../doc/models/meta-30-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `include` | [`List<Include12Enum>`](../../doc/models/include-12-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `filter` | [`Filter28`](../../doc/models/filter-28.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1StacksResponse>`](../../doc/models/v1-stacks-response.md)

## Example Usage

```csharp
try
{
    V1StacksResponse result = await stacksController.GetStacksAsync();
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


# Create Stack

Requires the `stacks-manage` capability.

```csharp
CreateStackAsync(
    Models.V1StacksRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1StacksRequest`](../../doc/models/v1-stacks-request.md) | Body, Optional | Parameters for creating a new Stack. |

## Response Type

[`Task<Models.V1StacksResponse1>`](../../doc/models/v1-stacks-response-1.md)

## Example Usage

```csharp
V1StacksRequest body = new V1StacksRequest
{
    Name = "name6",
    Source = StackSource.FromStackRepoSource(
        new StackRepoSource
        {
            Type = "git-repo",
            Details = new Details20
            {
                Url = "url4",
            },
        }
    ),
};

try
{
    V1StacksResponse1 result = await stacksController.CreateStackAsync(body);
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


# Get Stack

Requires the `stacks-view` capability.

```csharp
GetStackAsync(
    string stackId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `stackId` | `string` | Template, Required | The ID of the Stack |

## Response Type

[`Task<Models.V1StacksResponse1>`](../../doc/models/v1-stacks-response-1.md)

## Example Usage

```csharp
string stackId = "stackId2";
try
{
    V1StacksResponse1 result = await stacksController.GetStackAsync(stackId);
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


# Update Stack

Requires the `stacks-manage` capability.

```csharp
UpdateStackAsync(
    string stackId,
    Models.V1StacksRequest1 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `stackId` | `string` | Template, Required | The ID of the Stack |
| `body` | [`V1StacksRequest1`](../../doc/models/v1-stacks-request-1.md) | Body, Optional | Parameters for updating a Stack. |

## Response Type

[`Task<Models.V1StacksResponse1>`](../../doc/models/v1-stacks-response-1.md)

## Example Usage

```csharp
string stackId = "stackId2";
try
{
    V1StacksResponse1 result = await stacksController.UpdateStackAsync(stackId);
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


# Delete Stack

Requires the `stacks-manage` capability.

```csharp
DeleteStackAsync(
    string stackId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `stackId` | `string` | Template, Required | The ID of the Stack |

## Response Type

[`Task<Models.V1StacksResponse4>`](../../doc/models/v1-stacks-response-4.md)

## Example Usage

```csharp
string stackId = "stackId2";
try
{
    V1StacksResponse4 result = await stacksController.DeleteStackAsync(stackId);
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


# Create Stack Job

Requires the `stacks-manage` capability.

```csharp
CreateStackJobAsync(
    string stackId,
    Models.PruneStackBuilds body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `stackId` | `string` | Template, Required | The ID of the Stack |
| `body` | [`PruneStackBuilds`](../../doc/models/prune-stack-builds.md) | Body, Optional | Parameters for creating a new Stack Job. |

## Response Type

[`Task<Models.V1StacksTasksResponse>`](../../doc/models/v1-stacks-tasks-response.md)

## Example Usage

```csharp
string stackId = "stackId2";
PruneStackBuilds body = new PruneStackBuilds
{
    Action = "prune",
};

try
{
    V1StacksTasksResponse result = await stacksController.CreateStackJobAsync(
        stackId,
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


# Lookup Stack Build

Look up a Stack Build using only the Build ID, instead of requiring a Stack ID as well.

Requires the `stacks-view` capability.

```csharp
LookupStackBuildAsync(
    string buildId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `buildId` | `string` | Template, Required | The ID of the Build. |

## Response Type

[`Task<Models.V1StacksBuildsResponse>`](../../doc/models/v1-stacks-builds-response.md)

## Example Usage

```csharp
string buildId = "buildId2";
try
{
    V1StacksBuildsResponse result = await stacksController.LookupStackBuildAsync(buildId);
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


# Get Stack Builds

Requires the `stacks-view` capability.

```csharp
GetStackBuildsAsync(
    string stackId,
    List<Models.Meta24Enum> meta = null,
    Models.Filter29 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `stackId` | `string` | Template, Required | The ID of the Stack. |
| `meta` | [`List<Meta24Enum>`](../../doc/models/meta-24-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `filter` | [`Filter29`](../../doc/models/filter-29.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1StacksBuildsResponse1>`](../../doc/models/v1-stacks-builds-response-1.md)

## Example Usage

```csharp
string stackId = "stackId2";
try
{
    V1StacksBuildsResponse1 result = await stacksController.GetStackBuildsAsync(stackId);
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


# Create Stack Build

Requires the `stacks-manage` capability.

```csharp
CreateStackBuildAsync(
    string stackId,
    Models.V1StacksBuildsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `stackId` | `string` | Template, Required | The ID of the Stack |
| `body` | [`V1StacksBuildsRequest`](../../doc/models/v1-stacks-builds-request.md) | Body, Optional | Parameters for creating a new Stack Build. |

## Response Type

[`Task<Models.V1StacksBuildsResponse>`](../../doc/models/v1-stacks-builds-response.md)

## Example Usage

```csharp
string stackId = "stackId2";
try
{
    V1StacksBuildsResponse result = await stacksController.CreateStackBuildAsync(stackId);
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


# Get Stack Build

Requires the `stacks-view` capability.

```csharp
GetStackBuildAsync(
    string stackId,
    string buildId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `stackId` | `string` | Template, Required | The ID of the Stack. |
| `buildId` | `string` | Template, Required | The ID of the Build. |

## Response Type

[`Task<Models.V1StacksBuildsResponse>`](../../doc/models/v1-stacks-builds-response.md)

## Example Usage

```csharp
string stackId = "stackId2";
string buildId = "buildId2";
try
{
    V1StacksBuildsResponse result = await stacksController.GetStackBuildAsync(
        stackId,
        buildId
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


# Delete Stack Build

Requires the `stacks-manage` capability.

```csharp
DeleteStackBuildAsync(
    string stackId,
    string buildId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `stackId` | `string` | Template, Required | The ID of the Stack. |
| `buildId` | `string` | Template, Required | The ID of the Build. |

## Response Type

[`Task<Models.V1StacksBuildsResponse4>`](../../doc/models/v1-stacks-builds-response-4.md)

## Example Usage

```csharp
string stackId = "stackId2";
string buildId = "buildId2";
try
{
    V1StacksBuildsResponse4 result = await stacksController.DeleteStackBuildAsync(
        stackId,
        buildId
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


# Create Stack Build Job

Requires the `stacks-manage` capability.

```csharp
CreateStackBuildJobAsync(
    string stackId,
    string buildId,
    CreateStackBuildJobBody body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `stackId` | `string` | Template, Required | The ID of the Stack. |
| `buildId` | `string` | Template, Required | The ID of the Build. |
| `body` | [`CreateStackBuildJobBody`](../../doc/models/containers/create-stack-build-job-body.md) | Body, Optional | This is a container for one-of cases. |

## Response Type

[`Task<Models.V1StacksBuildsTasksResponse>`](../../doc/models/v1-stacks-builds-tasks-response.md)

## Example Usage

```csharp
string stackId = "stackId2";
string buildId = "buildId2";
CreateStackBuildJobBody body = CreateStackBuildJobBody.FromGenerateStackBuild(
    new GenerateStackBuild
    {
        Action = "generate",
    }
);

try
{
    V1StacksBuildsTasksResponse result = await stacksController.CreateStackBuildJobAsync(
        stackId,
        buildId,
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

