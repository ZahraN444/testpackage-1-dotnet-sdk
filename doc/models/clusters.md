
# Clusters

## Structure

`Clusters`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The name of the cluster |
| `Resources` | [`InfrastructureResourceSummary1`](../../doc/models/infrastructure-resource-summary-1.md) | Required | Information about the aggregate resources of the cluster. |
| `Healthy` | `bool` | Required | Whether Cycle has determined this cluster to be healthy or not. |
| `Versions` | [`ClusterVersionServerCount`](../../doc/models/cluster-version-server-count.md) | Required | A count of servers in a cluster with the given version of Cycle software |
| `Instances` | [`ResourceCountSummary`](../../doc/models/resource-count-summary.md) | Required | A summary of resources by state |
| `Servers` | [`Servers`](../../doc/models/servers.md) | Required | - |

## Example (as JSON)

```json
{
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
      "new": 0,
      "starting": 0,
      "running": 5,
      "stopping": 0,
      "deleting": 0,
      "deleted": 0
    },
    "total": 5,
    "available": 5
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
```

