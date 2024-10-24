
# Provider Location

Location information for a given provider.

## Structure

`ProviderLocation`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Name` | `string` | Required | A name for the location. |
| `Geographic` | [`ProviderLocationGeographic`](../../doc/models/containers/provider-location-geographic.md) | Optional | This is a container for any-of cases. |
| `Provider` | [`LocationProvider`](../../doc/models/location-provider.md) | Required | Information about the locaiton of the provider. |
| `Compatible` | `bool` | Required | A boolean where true means the locaiton is supported by the platform. |
| `Features` | [`Features3`](../../doc/models/features-3.md) | Required | Additional information about available and supported features of the provider location. |
| `Abbreviation` | `string` | Required | An abbreviation for the given provider locaiton. |
| `Annotations` | `object` | Required | Additional information about the given provider locaiton. |

## Example (as JSON)

```json
{
  "id": "id2",
  "name": "name2",
  "provider": {
    "identifier": "identifier4",
    "integration_id": "651586fca6078e98982dbd90",
    "location": "location2",
    "code": "code6",
    "availability_zones": [
      "availability_zones5",
      "availability_zones6"
    ]
  },
  "compatible": false,
  "features": {
    "available": [
      "available2",
      "available3"
    ],
    "supported": [
      "supported2",
      "supported3",
      "supported4"
    ]
  },
  "abbreviation": "abbreviation4",
  "annotations": {
    "key0": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "geographic": {
    "latitude": 10,
    "longitude": 46,
    "city": "city4",
    "state": "state0",
    "country": "country8",
    "region": "region0"
  }
}
```

