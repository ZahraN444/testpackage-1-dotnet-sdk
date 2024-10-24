
# Node Meta Stats

Statistics that pertain to a specific node.

## Structure

`NodeMetaStats`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Network` | [`ServerStatsNetwork`](../../doc/models/server-stats-network.md) | Required | Statistics about the networks on a given server. |
| `Uptime` | [`ServerStatsUptime`](../../doc/models/server-stats-uptime.md) | Required | Statistics describing the uptime of a given server. |
| `Cpu` | [`ServerStatsCpu`](../../doc/models/server-stats-cpu.md) | Required | Statistics about the CPU resources on a server. |
| `Load` | [`ServerStatsLoad`](../../doc/models/server-stats-load.md) | Required | Statistics about the current load on the server. |
| `Ram` | [`ServerStatsRam`](../../doc/models/server-stats-ram.md) | Required | Statistics about the RAM on a given server. |
| `Storage` | [`ServerStatsStorage`](../../doc/models/server-stats-storage.md) | Required | Statistics about storage for a given server. |
| `Os` | [`ServerStatsOS`](../../doc/models/server-stats-os.md) | Required | Statistics about the operating system installed on the server (CycleOS). |
| `Versions` | [`ServerStatsVersions`](../../doc/models/server-stats-versions.md) | Required | Information about the versions of Cycle services on a given server. |

## Example (as JSON)

```json
{
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
}
```

