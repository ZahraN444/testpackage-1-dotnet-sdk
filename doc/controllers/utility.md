# Utility

```csharp
UtilityController utilityController = client.UtilityController;
```

## Class Name

`UtilityController`


# Lookup Identifier

Given a (base64'd) resource identifier string (i.e. `cluster:production/env:abc`), returns the ID of the matching resource.
If more than one resource matches the identifier, or no resource matches the identifier, this endpoint will return an error.
Given identifiers are NOT unique, you may need to be more specific to target the exact identifier.

```csharp
LookupIdentifierAsync(
    string identifier,
    Models.DesiredComponentEnum desiredComponent)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `identifier` | `string` | Query, Required | A base64 encoded resource identifier string. |
| `desiredComponent` | [`DesiredComponentEnum`](../../doc/models/desired-component-enum.md) | Query, Required | The type of resource to lookup from the identifier string. |

## Response Type

[`Task<Models.V1UtilsResourceLookupResponse>`](../../doc/models/v1-utils-resource-lookup-response.md)

## Example Usage

```csharp
string identifier = "cltr:production/environment:654d4e848924c1c445c3635a/container:api";
DesiredComponentEnum desiredComponent = DesiredComponentEnum.Server;
try
{
    V1UtilsResourceLookupResponse result = await utilityController.LookupIdentifierAsync(
        identifier,
        desiredComponent
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

