
# Container Config

A container configuration.

## Structure

`ContainerConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Network` | [`ContainerNetwork`](../../doc/models/container-network.md) | Required | Network configuration for a container. |
| `Deploy` | [`ContainerDeploy`](../../doc/models/container-deploy.md) | Required | Deployment configuration for the given container. |
| `Scale` | [`ContainerScale`](../../doc/models/container-scale.md) | Optional | Network configuration for a container. |
| `Runtime` | [`ContainerRuntime`](../../doc/models/container-runtime.md) | Optional | Runtime configurations for a given container. |
| `Resources` | [`ContainerResources`](../../doc/models/container-resources.md) | Optional | Configuration settings for the resource allocations and limits of a given container. |
| `Integrations` | [`ContainerIntegrations`](../../doc/models/container-integrations.md) | Optional | Configuration settings for integrations with a given container. |

## Example (as JSON)

```json
{
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
}
```

