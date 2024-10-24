
# Provider Server Model

A server from a provider.

## Structure

`ProviderServerModel`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Name` | `string` | Required | A name for the server. |
| `Description` | `string` | Required | A description of the server. |
| `Specs` | [`ServerSpecs`](../../doc/models/server-specs.md) | Required | Specs for a given server |
| `Provider` | [`ProviderServerSpec`](../../doc/models/provider-server-spec.md) | Required | Higher level information about a providers server. |
| `Price` | [`BillingAmount`](../../doc/models/billing-amount.md) | Required | An object holding information about term and amount that relates to a specific billing component. |
| `Compatible` | `bool` | Required | A boolean where true signifies this server is compatible with the platform. |
| `LowResource` | `bool` | Required | A boolean where true signifies the server has a limited amount of resources and should only be used for very lightweight workloads. |
| `LocationIds` | `List<string>` | Required | An array of location IDs where this server type is available. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "name": "name4",
  "description": "description4",
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
    "location_ids4"
  ]
}
```

