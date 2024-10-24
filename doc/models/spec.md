
# Spec

## Structure

`Spec`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Version` | `string` | Optional | A string defining the version of the stack spec. |
| `About` | [`About`](../../doc/models/about.md) | Optional | Information about the stack. |
| `Tests` | [`List<StackSpecTestContainer>`](../../doc/models/stack-spec-test-container.md) | Optional | - |
| `ScopedVariables` | [`List<StackSpecScopedVariable>`](../../doc/models/stack-spec-scoped-variable.md) | Optional | - |
| `Containers` | [`Dictionary<string, StackContainer>`](../../doc/models/stack-container.md) | Optional | Records defining the containers within the stack. |
| `Services` | [`StackSpecServices`](../../doc/models/stack-spec-services.md) | Optional | - |
| `Annotations` | `object` | Optional | Additional meta info about the stack. |

## Example (as JSON)

```json
{
  "version": "version8",
  "about": {
    "version": "version0",
    "description": "description4"
  },
  "tests": [
    {
      "name": "name6",
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
      "config": {
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
        }
      }
    },
    {
      "name": "name6",
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
      "config": {
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
        }
      }
    },
    {
      "name": "name6",
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
      "config": {
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
        }
      }
    }
  ],
  "scoped_variables": [
    {
      "identifier": "identifier2",
      "scope": {
        "containers": {
          "global": false,
          "ids": [
            "ids3",
            "ids4",
            "ids5"
          ],
          "identifiers": [
            "identifiers8",
            "identifiers9"
          ]
        }
      },
      "access": {
        "env_variable": {
          "key": "key8"
        },
        "internal_api": {
          "duration": "String5"
        },
        "file": {
          "decode": false,
          "path": "path4"
        }
      },
      "source": {
        "type": "type4",
        "details": {
          "url": "url4",
          "headers": {
            "key0": {
              "key1": "val1",
              "key2": "val2"
            }
          },
          "auth_token_url": "auth_token_url4"
        }
      }
    },
    {
      "identifier": "identifier2",
      "scope": {
        "containers": {
          "global": false,
          "ids": [
            "ids3",
            "ids4",
            "ids5"
          ],
          "identifiers": [
            "identifiers8",
            "identifiers9"
          ]
        }
      },
      "access": {
        "env_variable": {
          "key": "key8"
        },
        "internal_api": {
          "duration": "String5"
        },
        "file": {
          "decode": false,
          "path": "path4"
        }
      },
      "source": {
        "type": "type4",
        "details": {
          "url": "url4",
          "headers": {
            "key0": {
              "key1": "val1",
              "key2": "val2"
            }
          },
          "auth_token_url": "auth_token_url4"
        }
      }
    }
  ],
  "containers": {
    "key0": {
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
      "annotations": {
        "key0": {
          "key1": "val1",
          "key2": "val2"
        },
        "key1": {
          "key1": "val1",
          "key2": "val2"
        },
        "key2": {
          "key1": "val1",
          "key2": "val2"
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
    },
    "key1": {
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
      "annotations": {
        "key0": {
          "key1": "val1",
          "key2": "val2"
        },
        "key1": {
          "key1": "val1",
          "key2": "val2"
        },
        "key2": {
          "key1": "val1",
          "key2": "val2"
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
    },
    "key2": {
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
      "annotations": {
        "key0": {
          "key1": "val1",
          "key2": "val2"
        },
        "key1": {
          "key1": "val1",
          "key2": "val2"
        },
        "key2": {
          "key1": "val1",
          "key2": "val2"
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
  }
}
```

