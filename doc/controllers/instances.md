# Instances

A subgroup of containers, instances refers to calls that work with container instance resources.

```csharp
InstancesController instancesController = client.InstancesController;
```

## Class Name

`InstancesController`


# Delete Container Instances

Manually delete Instances of a Container.

Requires the `containers-update` capability.

```csharp
DeleteContainerInstancesAsync(
    string containerId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `containerId` | `string` | Template, Required | The ID of the container the instance(s) were created from. |

## Response Type

[`Task<Models.V1ContainersInstancesResponse1>`](../../doc/models/v1-containers-instances-response-1.md)

## Example Usage

```csharp
string containerId = "containerId4";
try
{
    V1ContainersInstancesResponse1 result = await instancesController.DeleteContainerInstancesAsync(containerId);
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

