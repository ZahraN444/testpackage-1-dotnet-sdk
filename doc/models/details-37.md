
# Details 37

## Structure

`Details37`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Identifier` | `string` | Optional | - |
| `Environment` | `string` | Required | An identifier used in pipelines to refer to different kinds of resources across Cycle.<br><br>## Types:<br><br>- `id:<mongo id>`: A raw resource ID<br>- `resource:<a resource identifier>`: A compound identifier pointing to a resource.<br>- `from:<stage/step>`: For referencing a previous pipeline step. |
| `Image` | `string` | Required | An identifier used in pipelines to refer to different kinds of resources across Cycle.<br><br>## Types:<br><br>- `id:<mongo id>`: A raw resource ID<br>- `resource:<a resource identifier>`: A compound identifier pointing to a resource.<br>- `from:<stage/step>`: For referencing a previous pipeline step. |
| `Stateful` | `bool` | Required | - |
| `Annotations` | `object` | Optional | Additional information about a container |
| `Config` | [`ContainerConfig`](../../doc/models/container-config.md) | Required | A container configuration. |
| `Volumes` | [`List<ContainerVolume>`](../../doc/models/container-volume.md) | Required | - |
| `Deployment` | [`Details37Deployment`](../../doc/models/containers/details-37-deployment.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "name": "name8",
  "environment": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
  "image": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
  "stateful": false,
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
  "volumes": [
    {
      "read_only": false,
      "local": {
        "max_size": "max_size6",
        "storage_pool": false
      },
      "destination": "destination2",
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
  "identifier": "identifier4",
  "annotations": {
    "key0": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "deployment": {
    "version": "version0"
  }
}
```

