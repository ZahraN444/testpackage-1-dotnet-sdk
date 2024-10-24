
# V1 Infrastructure Providers Locations Response

## Structure

`V1InfrastructureProvidersLocationsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<ProviderLocation>`](../../doc/models/provider-location.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "id0",
      "name": "name0",
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
      "abbreviation": "abbreviation2",
      "annotations": {
        "key0": {
          "key1": "val1",
          "key2": "val2"
        },
        "key1": {
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
  ]
}
```

