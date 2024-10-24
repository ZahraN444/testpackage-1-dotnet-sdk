
# Server

The server resource, referring to servers that have been deployed to a Cycle hub.

## Structure

`Server`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `LocationId` | `string` | Required | An identifier for the location this server is deployed to. |
| `ModelId` | `string` | Required | An identifier for the model of server that is deployed. |
| `NodeId` | `string` | Required | An identifier for the node. |
| `SharedFileSystems` | [`ServerSharedFileSystems`](../../doc/models/server-shared-file-systems.md) | Required | - |
| `Hostname` | `string` | Required | The server hostname. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `Provider` | [`ServerProvider`](../../doc/models/server-provider.md) | Required | A resource regarding the provider a given server is deployed from. |
| `Cluster` | `string` | Required | The cluster the given server is deployed to. |
| `Features` | [`ServerFeatures`](../../doc/models/server-features.md) | Required | A set of features a given server can have and their information. |
| `Constraints` | [`ServerConstraints`](../../doc/models/server-constraints.md) | Required | Constraints to apply to the server. |
| `Autoscale` | [`Autoscale1`](../../doc/models/autoscale-1.md) | Optional | - |
| `Ephemeral` | `bool` | Required | Set to true when a server is created as part of an auto-scale event. |
| `Evacuate` | [`Evacuate`](../../doc/models/evacuate.md) | Optional | Details about a server's evacuation status. When an evacuation is in progress, no new container instances will be permitted on the server. |
| `State` | [`ServerState`](../../doc/models/server-state.md) | Required | - |
| `Events` | [`ServerEvents`](../../doc/models/server-events.md) | Required | A collection of timestamps for each event in the server's lifetime. |
| `Meta` | [`ServerMeta`](../../doc/models/server-meta.md) | Optional | A list of meta fields that can be applied to a server. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "hub_id": "651586fca6078e98982dbd90",
  "location_id": "location_id6",
  "model_id": "model_id2",
  "node_id": "node_id0",
  "shared_file_systems": {
    "mounts": {
      "key0": {
        "type": "type8",
        "options": "options0",
        "source": "source2"
      },
      "key1": {
        "type": "type8",
        "options": "options0",
        "source": "source2"
      }
    },
    "directories": {
      "key0": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  },
  "hostname": "hostname2",
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "provider": {
    "vendor": "vendor4",
    "model": "model6",
    "location": "location2",
    "server": "server2",
    "init_ips": [
      "init_ips3",
      "init_ips2"
    ],
    "mac_addr": "mac_addr2",
    "extra": {
      "key1": "val1",
      "key2": "val2"
    },
    "provision_options": {
      "attachesd_storage_size": 103.2,
      "reservation_id": "reservation_id8"
    }
  },
  "cluster": "cluster8",
  "features": {
    "sftp": false,
    "base_volume_gb": 224
  },
  "constraints": {
    "tags": [
      "tags3",
      "tags4",
      "tags5"
    ],
    "allow": {
      "pool": false,
      "services": false,
      "overcommit": false
    }
  },
  "ephemeral": false,
  "state": {
    "current": "configuring",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "events": {
    "created": "01/30/2021 08:30:00",
    "updated": "01/30/2021 08:30:00",
    "deleted": "01/30/2021 08:30:00",
    "latest_instance": "01/30/2021 08:30:00",
    "provisioning": {
      "started": "01/30/2021 08:30:00",
      "failed": "01/30/2021 08:30:00",
      "completed": "01/30/2021 08:30:00"
    }
  },
  "autoscale": {
    "group_id": "group_id8"
  },
  "evacuate": {
    "started": "2016-03-13T12:52:32.123Z"
  },
  "meta": {
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
    },
    "instances_count": {
      "state": {
        "key0": 136,
        "key1": 135,
        "key2": 134
      },
      "total": 108,
      "available": 154
    }
  }
}
```

