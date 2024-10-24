
# Provider Server Spec

Higher level information about a providers server.

## Structure

`ProviderServerSpec`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Required | A provider identifier |
| `IntegrationId` | [`ProviderServerSpecIntegrationId`](../../doc/models/containers/provider-server-spec-integration-id.md) | Optional | This is a container for any-of cases. |
| `Category` | `string` | Required | A category for the server. |
| `Class` | `string` | Optional | A class for the server. |
| `Model` | `string` | Required | The model of the server. |
| `Locations` | `List<string>` | Required | A list of location ID's this server is available. |
| `AvailabilityZones` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "identifier": "identifier2",
  "integration_id": "String3",
  "category": "category8",
  "class": "class6",
  "model": "model8",
  "locations": [
    "locations8",
    "locations9"
  ],
  "availability_zones": {
    "key0": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

