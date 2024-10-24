
# Node 2

Infrormation about the status of the server.

## Structure

`Node2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `LastCheckin` | `DateTime` | Required | The last time this server checked in with the platform. |
| `Drivers` | `List<string>` | Required | An array a drivers associated with the given server. |
| `State` | [`NodeState`](../../doc/models/node-state.md) | Required | - |
| `Stats` | [`NodeMetaStats`](../../doc/models/node-meta-stats.md) | Required | Statistics that pertain to a specific node. |
| `Healthy` | `bool` | Required | A boolean where true means the platform is reporting the server as healthy. |
| `Online` | `bool` | Required | A boolean where true means the server is online and reachable by the platform. |

## Example (as JSON)

```json
{
  "last_checkin": "01/30/2021 08:30:00",
  "drivers": [
    "drivers8",
    "drivers9",
    "drivers0"
  ],
  "state": {
    "current": "authorizing",
    "changed": "01/30/2021 08:30:00",
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
```

