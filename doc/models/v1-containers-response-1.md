
# V1 Containers Response 1

## Structure

`V1ContainersResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Container`](../../doc/models/container.md) | Optional | Containers are a way to package together your application along with it's dependencies, and run in a resource isolated process. They provide consistency across different hosts, efficiency over traditional hosting methods, and facilitate a micro-service based approach, where each logical piece of your application is split into multiple, easily testable parts (such as API, Backend, Frontend, etc). |

## Example (as JSON)

```json
{
  "data": {
    "id": "id0",
    "identifier": "identifier8",
    "name": "name0",
    "creator": {
      "id": "id8",
      "type": "employee"
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
    },
    "hub_id": "hub_id2",
    "image": {
      "id": "String7",
      "extension": {
        "identifier": "identifier6"
      },
      "service": "scheduler"
    },
    "stack": {
      "id": "id0",
      "build_id": "build_id0",
      "identifier": "identifier2"
    },
    "config": {
      "network": {
        "public": "disable",
        "hostname": "hostname0",
        "ports": [
          "ports9",
          "ports0"
        ]
      },
      "deploy": {
        "instances": 208,
        "strategy": "high-availability",
        "stateful": {
          "options": {
            "use_base_hostname": false
          }
        },
        "constraints": {
          "node": {
            "tags": {
              "any": [
                "any6",
                "any7"
              ],
              "all": [
                "all9"
              ]
            }
          },
          "secrets": [
            "secrets1",
            "secrets2"
          ]
        },
        "shutdown": {
          "graceful_timeout": "String7",
          "signals": [
            "SIGHUP",
            "SIGQUIT"
          ]
        },
        "startup": {
          "delay": "delay2"
        }
      },
      "scale": {
        "autoscale_group": "autoscale_group0",
        "instances": {
          "delta": 232,
          "max": 128,
          "max_server": 132,
          "min_ttl": "min_ttl4"
        },
        "window": "window4",
        "thresholds": [
          {
            "type": "ram",
            "details": {
              "used": "used2"
            }
          },
          {
            "type": "ram",
            "details": {
              "used": "used2"
            }
          }
        ]
      },
      "runtime": {
        "command": {
          "path": "path0",
          "args": "args6"
        },
        "namespaces": [
          "uts"
        ],
        "environment_vars": {
          "key0": "environment_vars8",
          "key1": "environment_vars7"
        },
        "privileged": false,
        "capabilities": [
          "CAP_WAKE_ALARM"
        ],
        "workdir": "workdir6"
      },
      "resources": {
        "cpu": {
          "shares": {
            "limit": 214,
            "reserve": 14
          },
          "cpus": "cpus2"
        },
        "ram": {
          "limit": "limit4",
          "reserve": "reserve0"
        }
      },
      "integrations": {
        "webhooks": {
          "events": {
            "deploy": "deploy2",
            "start": "start4",
            "stop": "stop2"
          },
          "config": "config2"
        },
        "files": [
          {
            "source": "source0",
            "destination": "destination0"
          },
          {
            "source": "source0",
            "destination": "destination0"
          }
        ],
        "lets_encrypt": {
          "enable": false,
          "certificate_path": "certificate_path4",
          "chain_path": "chain_path2",
          "key_path": "key_path0",
          "bundle_path": "bundle_path6",
          "additional_certs_path": "additional_certs_path4"
        },
        "backups": {
          "integration_id": "integration_id6",
          "backup": {
            "command": "command4",
            "timeout": "String9",
            "cron_string": "cron_string6"
          },
          "restore": {
            "command": "command8",
            "timeout": "timeout4"
          },
          "retention": "String7"
        },
        "shared_file_systems": {
          "key0": {
            "writable": false,
            "mount_point": "mount_point0"
          },
          "key1": {
            "writable": false,
            "mount_point": "mount_point0"
          },
          "key2": {
            "writable": false,
            "mount_point": "mount_point0"
          }
        }
      }
    },
    "deployment": {
      "version": "version0"
    },
    "instances": 248,
    "volumes": [
      {
        "id": "id6",
        "hash": "hash2",
        "config": {
          "read_only": false,
          "local": {
            "max_size": "max_size6",
            "storage_pool": false
          },
          "destination": "destination8",
          "remote_access": {
            "enable": false,
            "ips": [
              "ips4",
              "ips5",
              "ips6"
            ],
            "web_hook": "web_hook0",
            "password": {
              "algorithm": "sha512",
              "data": "data4"
            }
          }
        }
      }
    ],
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
    "role": "orchestrator",
    "stateful": false,
    "deprecate": false,
    "lock": false,
    "state": {
      "current": "deleting",
      "desired": "stopping",
      "changed": "2016-03-13T12:52:32.123Z",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "events": {
      "created": "2016-03-13T12:52:32.123Z",
      "updated": "2016-03-13T12:52:32.123Z",
      "deleted": "2016-03-13T12:52:32.123Z",
      "started": "2016-03-13T12:52:32.123Z"
    }
  }
}
```

