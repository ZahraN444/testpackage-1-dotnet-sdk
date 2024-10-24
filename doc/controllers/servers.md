# Servers

A subgroup of infrastructure, servers call deal specificially with server resources.

```csharp
ServersController serversController = client.ServersController;
```

## Class Name

`ServersController`


# Delete Server

Requires the `servers-manage` capability.

```csharp
DeleteServerAsync(
    string serverId,
    Dictionary<string, string> options = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `serverId` | `string` | Template, Required | The ID of the Server. |
| `options` | `Dictionary<string, string>` | Query, Optional | The option field is a key-value object, where the key is the option, and the value is a boolean. For example, `?option[force]=true` |

## Response Type

[`Task<Models.V1InfrastructureServersResponse1>`](../../doc/models/v1-infrastructure-servers-response-1.md)

## Example Usage

```csharp
string serverId = "serverId8";
try
{
    V1InfrastructureServersResponse1 result = await serversController.DeleteServerAsync(serverId);
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

