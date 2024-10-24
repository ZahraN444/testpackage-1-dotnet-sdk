
# Server Meta

A list of meta fields that can be applied to a server.

## Structure

`ServerMeta`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Node` | [`Node2`](../../doc/models/node-2.md) | Optional | Infrormation about the status of the server. |
| `InstancesCount` | [`ResourceCountSummary`](../../doc/models/resource-count-summary.md) | Optional | A summary of resources by state |

## Example (as JSON)

```json
{
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
  "node": {
    "last_checkin": "2016-03-13T12:52:32.123Z",
    "drivers": [
      "drivers4",
      "drivers5"
    ],
    "state": {
      "current": "authorizing",
      "changed": "2016-03-13T12:52:32.123Z",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "stats": {
      "network": {
        "interfaces": {
          "key0": {
            "interface": "interface8",
            "flags": "flags6",
            "mtu": 38,
            "mac_addr": "mac_addr8",
            "addrs": [
              "addrs9",
              "addrs0"
            ]
          }
        },
        "external_ipv4": "external_ipv46",
        "external_ipv6": "external_ipv62"
      },
      "uptime": {
        "seconds": 205.14,
        "cpu_idle": 38.8
      },
      "cpu": {
        "cores": 8,
        "processors": [
          {
            "model": "model2",
            "speed": 12.92
          },
          {
            "model": "model2",
            "speed": 12.92
          }
        ],
        "usage": {
          "user": 2,
          "nice": 30,
          "system": 206,
          "idle": 254,
          "iowait": 180
        }
      },
      "load": {
        "avg1m": 164.12,
        "avg5m": 123.4,
        "avg15m": 158.96
      },
      "ram": {
        "available": 172,
        "free": 224,
        "total": 126
      },
      "storage": {
        "volume_groups": {
          "key0": {
            "name": "name8",
            "size": 104,
            "volumes": {
              "key0": {
                "name": "name6",
                "size": 224,
                "data_percent": 206,
                "meta_percent": 96,
                "pool": "pool0"
              },
              "key1": {
                "name": "name6",
                "size": 224,
                "data_percent": 206,
                "meta_percent": 96,
                "pool": "pool0"
              },
              "key2": {
                "name": "name6",
                "size": 224,
                "data_percent": 206,
                "meta_percent": 96,
                "pool": "pool0"
              }
            }
          },
          "key1": {
            "name": "name8",
            "size": 104,
            "volumes": {
              "key0": {
                "name": "name6",
                "size": 224,
                "data_percent": 206,
                "meta_percent": 96,
                "pool": "pool0"
              },
              "key1": {
                "name": "name6",
                "size": 224,
                "data_percent": 206,
                "meta_percent": 96,
                "pool": "pool0"
              },
              "key2": {
                "name": "name6",
                "size": 224,
                "data_percent": 206,
                "meta_percent": 96,
                "pool": "pool0"
              }
            }
          }
        },
        "mounts": {
          "key0": {
            "device": "device8",
            "type": "type8",
            "mountpoint": "mountpoint8",
            "total": 26,
            "free": 68,
            "used": 220
          },
          "key1": {
            "device": "device8",
            "type": "type8",
            "mountpoint": "mountpoint8",
            "total": 26,
            "free": 68,
            "used": 220
          }
        }
      },
      "os": {
        "release": "release0",
        "kernel": "kernel2",
        "hostname": "hostname6"
      },
      "versions": {
        "services": {
          "key0": "services0",
          "key1": "services1",
          "key2": "services2"
        }
      }
    },
    "healthy": false,
    "online": false
  }
}
```

