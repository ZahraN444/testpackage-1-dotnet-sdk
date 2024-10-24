
# V1 Infrastructure Providers Servers Response

## Structure

`V1InfrastructureProvidersServersResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<ProviderServerModel>`](../../doc/models/provider-server-model.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "651586fca6078e98982dbd90",
      "name": "name0",
      "description": "description0",
      "specs": {
        "cpu": {
          "count": 118,
          "cores": 8,
          "threads": 196,
          "type": "type6",
          "shared": false,
          "extra": {
            "key0": "extra8",
            "key1": "extra7"
          }
        },
        "gpu": {
          "count": 80,
          "cores": 66,
          "vram_gb": 46,
          "type": "type8",
          "shared": false,
          "extra": {
            "key0": "extra4",
            "key1": "extra3"
          }
        },
        "memory": {
          "size_gb": 146,
          "type": "type0",
          "extra": {
            "key0": "extra4"
          }
        },
        "storage": [
          {
            "count": 246,
            "size_gb": 62,
            "type": "type2",
            "extra": {
              "key0": "extra0",
              "key1": "extra1",
              "key2": "extra2"
            }
          }
        ],
        "network": [
          {
            "count": 94,
            "scope": "public",
            "throughput": 184,
            "type": "type6"
          }
        ],
        "features": {
          "raid": "raid2",
          "aws": {
            "ena_support": false,
            "ebs_optimized": false
          }
        }
      },
      "provider": {
        "identifier": "identifier4",
        "integration_id": "String1",
        "category": "category6",
        "class": "class4",
        "model": "model6",
        "locations": [
          "locations6",
          "locations7",
          "locations8"
        ],
        "availability_zones": {
          "key0": {
            "key1": "val1",
            "key2": "val2"
          },
          "key1": {
            "key1": "val1",
            "key2": "val2"
          }
        }
      },
      "price": {
        "mills": 210,
        "term": "monthly"
      },
      "compatible": false,
      "low_resource": false,
      "location_ids": [
        "location_ids0",
        "location_ids1"
      ]
    }
  ]
}
```

