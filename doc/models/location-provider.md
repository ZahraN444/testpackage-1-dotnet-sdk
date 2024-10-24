
# Location Provider

Information about the locaiton of the provider.

## Structure

`LocationProvider`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Required | An identifier for the given provider |
| `IntegrationId` | `string` | Optional | The ID of the provider integration associated with this location. |
| `Location` | `string` | Required | A location name returned from the provider. |
| `Code` | `string` | Required | A location code returned from the provider. |
| `AvailabilityZones` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "identifier": "identifier4",
  "integration_id": "651586fca6078e98982dbd90",
  "location": "location2",
  "code": "code6",
  "availability_zones": [
    "availability_zones5",
    "availability_zones6"
  ]
}
```

