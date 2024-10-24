
# Environment Meta

A list of meta fields that can be applied to this environment.

## Structure

`EnvironmentMeta`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ContainersCount` | [`ResourceCountSummary`](../../doc/models/resource-count-summary.md) | Optional | A summary of resources by state |
| `InstancesCount` | [`ResourceCountSummary`](../../doc/models/resource-count-summary.md) | Optional | A summary of resources by state |
| `Containers` | [`List<Container2>`](../../doc/models/container-2.md) | Optional | - |

## Example (as JSON)

```json
{
  "containers_count": {
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
  "instances_count": {
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
  "containers": [
    {
      "id": "id2",
      "name": "name2",
      "state": {
        "current": "deleting",
        "desired": "stopping",
        "changed": "2016-03-13T12:52:32.123Z",
        "error": {
          "message": "message4",
          "time": "2016-03-13T12:52:32.123Z"
        }
      },
      "image": {
        "id": "id6",
        "service": "discovery"
      },
      "environment": {
        "id": "id6",
        "cluster": "cluster8",
        "container_subnet": "container_subnet6",
        "ipv6": {
          "ip": "ip8",
          "cidr": "cidr4"
        },
        "legacy": {
          "subnet": 58,
          "ipv4": {
            "ip": "ip8",
            "cidr": "cidr4"
          }
        }
      }
    }
  ]
}
```

