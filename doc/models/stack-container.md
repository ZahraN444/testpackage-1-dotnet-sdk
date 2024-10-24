
# Stack Container

Stacks container object

## Structure

`StackContainer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Image` | [`StackSpecContainerImage`](../../doc/models/stack-spec-container-image.md) | Required | - |
| `Annotations` | `object` | Optional | Additional meta info about the container. |
| `Stateful` | `bool` | Required | - |
| `Config` | [`StackSpecContainerConfig`](../../doc/models/stack-spec-container-config.md) | Required | - |
| `Role` | [`Role1Enum?`](../../doc/models/role-1-enum.md) | Optional | - |
| `Pod` | `string` | Optional | - |
| `Volumes` | [`List<StackSpecContainerVolume>`](../../doc/models/stack-spec-container-volume.md) | Optional | - |
| `Deprecate` | `bool?` | Optional | - |
| `Lock` | `bool?` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name2",
  "image": {
    "name": "name6",
    "origin": {
      "type": "docker-hub",
      "details": {
        "existing": {
          "source_id": "source_id8"
        },
        "target": "target8",
        "username": "username0",
        "token": "token4"
      }
    },
    "build": {
      "args": {
        "key0": "args9"
      }
    },
    "builder": {
      "integration_id": "integration_id6"
    }
  },
  "stateful": false,
  "config": {
    "network": {
      "public": "egress-only",
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
        ],
        "containers": [
          "containers5"
        ]
      },
      "shutdown": {
        "graceful_timeout": "String7",
        "signals": [
          "signals2",
          "signals3"
        ]
      },
      "startup": {
        "delay": "String3"
      }
    },
    "scaling": {
      "autoscale_group": "autoscale_group4",
      "instances": {
        "delta": 232,
        "max": 128,
        "max_server": 132,
        "min_ttl": "min_ttl4"
      },
      "window": "window0",
      "thresholds": [
        {
          "type": "ram",
          "details": {
            "used": "used2"
          }
        }
      ]
    },
    "runtime": {
      "workdir": "workdir0",
      "command": {
        "path": "path0",
        "args": "args6"
      },
      "environment_vars": {
        "key0": "environment_vars8",
        "key1": "environment_vars7"
      },
      "namespaces": [
        "mount",
        "user"
      ],
      "sysctl": {
        "key0": "sysctl8"
      }
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
        "reserve": "reserve0",
        "swappiness": 93.52
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
      "lets_encrypt": {
        "enable": false,
        "certificate_path": "certificate_path4",
        "chain_path": "chain_path2",
        "key_path": "key_path0",
        "bundle_path": "bundle_path6",
        "additional_certs_path": "additional_certs_path4"
      },
      "files": [
        {
          "source": "source0",
          "destination": "destination0"
        }
      ],
      "backups": {
        "destination": "destination0",
        "backup": {
          "command": "command4",
          "timeout": "String9",
          "cron_string": "cron_string6"
        },
        "restore": {
          "command": "command8",
          "timeout": "String5"
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
        }
      }
    }
  },
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
  "role": "conductor",
  "pod": "pod4",
  "volumes": [
    {
      "local": {
        "max_size": "max_size6",
        "storage_pool": false
      },
      "destination": "destination2",
      "read_only": false,
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
  ],
  "deprecate": false
}
```

