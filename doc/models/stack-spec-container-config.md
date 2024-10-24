
# Stack Spec Container Config

## Structure

`StackSpecContainerConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Network` | [`StackContainerConfigNetworkYml`](../../doc/models/stack-container-config-network-yml.md) | Required | - |
| `Deploy` | [`StackContainerConfigDeployYml`](../../doc/models/stack-container-config-deploy-yml.md) | Required | - |
| `Scaling` | [`StackSpecContainerConfigScaling`](../../doc/models/containers/stack-spec-container-config-scaling.md) | Optional | This is a container for any-of cases. |
| `Runtime` | [`StackSpecContainerConfigRuntime`](../../doc/models/containers/stack-spec-container-config-runtime.md) | Optional | This is a container for any-of cases. |
| `Resources` | [`StackSpecContainerConfigResources`](../../doc/models/containers/stack-spec-container-config-resources.md) | Optional | This is a container for any-of cases. |
| `Integrations` | [`StackSpecContainerConfigIntegrations`](../../doc/models/containers/stack-spec-container-config-integrations.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
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
}
```

