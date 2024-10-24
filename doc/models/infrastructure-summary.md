
# Infrastructure Summary

An infrastructure summary resource.

## Structure

`InfrastructureSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Servers` | `double` | Required | The number of servers on the cluster |
| `Images` | [`Images`](../../doc/models/images.md) | Required | Statistics about image usage. |
| `Clusters` | [`Dictionary<string, Clusters>`](../../doc/models/clusters.md) | Required | Records pointing to information about clusters that make up this hubs infrastructure. |
| `Updated` | `DateTime` | Required | A timestamp of when the infrastructure was last updated. |

## Example (as JSON)

```json
{
  "hub_id": "651586fca6078e98982dbd90",
  "servers": 137.02,
  "images": {
    "tier": {
      "total_mb": 42,
      "allocated_mb": 130,
      "used_mb": 200
    }
  },
  "clusters": {
    "key0": {
      "name": "name6",
      "resources": {
        "ram": {
          "total_mb": 88,
          "allocated_mb": 176,
          "used_mb": 246,
          "provisioned_mb": 52
        },
        "cpu": {
          "cores": 8,
          "shares": {
            "allocated": 40,
            "total": 52
          },
          "share_ratio": 82
        }
      },
      "healthy": false,
      "versions": {
        "agent": {
          "key0": 60.11
        },
        "agent-spawner": {
          "key0": 190.57,
          "key1": 190.58
        },
        "compute": {
          "key0": 188.87,
          "key1": 188.88,
          "key2": 188.89
        },
        "compute-spawner": {
          "key0": 47.75,
          "key1": 47.76,
          "key2": 47.77
        }
      },
      "instances": {
        "state": {
          "key0": 252,
          "key1": 253
        },
        "total": 24,
        "available": 22
      },
      "servers": {
        "count": 119.22,
        "providers": {
          "key0": {
            "count": 57.74,
            "locations": {
              "key0": 98,
              "key1": 97
            },
            "models": {
              "key0": 178,
              "key1": 179,
              "key2": 180
            },
            "resources": {
              "ram": {
                "total_mb": 88,
                "allocated_mb": 176,
                "used_mb": 246,
                "provisioned_mb": 52
              },
              "cpu": {
                "cores": 8,
                "shares": {
                  "allocated": 40,
                  "total": 52
                },
                "share_ratio": 82
              }
            }
          }
        },
        "server_ids": [
          "server_ids1",
          "server_ids2"
        ]
      }
    }
  },
  "updated": "01/30/2021 08:30:00"
}
```

