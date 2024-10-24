
# Environment Services

Service containers run by this environment and their configurations.

## Structure

`EnvironmentServices`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Loadbalancer` | [`EnvironmentServicesLoadbalancer`](../../doc/models/containers/environment-services-loadbalancer.md) | Required | This is a container for any-of cases. |
| `Discovery` | [`EnvironmentServicesDiscovery`](../../doc/models/containers/environment-services-discovery.md) | Optional | This is a container for any-of cases. |
| `Vpn` | [`EnvironmentServicesVpn`](../../doc/models/containers/environment-services-vpn.md) | Optional | This is a container for any-of cases. |
| `Scheduler` | [`EnvironmentServicesScheduler`](../../doc/models/containers/environment-services-scheduler.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "loadbalancer": {
    "enable": false,
    "container_id": "container_id2",
    "high_availability": false,
    "config": {
      "ipv4": false,
      "ipv6": false,
      "type": "v1",
      "details": {
        "controllers": [
          {
            "default": false,
            "identifier": "identifier0",
            "transport": {
              "disable": false,
              "mode": "tcp",
              "config": {
                "performance": false,
                "ingress": {
                  "port": 242,
                  "tls": {
                    "enable": false
                  }
                },
                "timeouts": {
                  "idle": "72h45m2s"
                },
                "verbosity": "low",
                "extension": {
                  "type": "type2",
                  "details": {
                    "connections": {
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
                    }
                  }
                }
              },
              "routers": [
                {
                  "match": {
                    "domains": [
                      "domains0",
                      "domains1",
                      "domains2"
                    ],
                    "internal_port": [
                      223,
                      224,
                      225
                    ],
                    "path": "path4"
                  },
                  "mode": "random",
                  "config": {
                    "sticky_sessions": false,
                    "destination_retries": 166,
                    "timeouts": {
                      "destination_connection": "72h45m2s"
                    },
                    "tls": {
                      "server_name": "server_name2",
                      "allow_insecure": false,
                      "client_cert_auth": "client_cert_auth6",
                      "client_auth": "require"
                    },
                    "extension": {
                      "type": "type6",
                      "details": {
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
                      }
                    }
                  }
                }
              ]
            }
          }
        ],
        "controller_template": {
          "default": false,
          "identifier": "identifier4",
          "transport": {
            "disable": false,
            "mode": "tcp",
            "config": {
              "performance": false,
              "ingress": {
                "port": 242,
                "tls": {
                  "enable": false
                }
              },
              "timeouts": {
                "idle": "idle8"
              },
              "verbosity": "low",
              "extension": {
                "type": "type2",
                "details": {
                  "connections": {
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
                  }
                }
              }
            },
            "routers": [
              {
                "match": {
                  "domains": [
                    "domains0",
                    "domains1",
                    "domains2"
                  ],
                  "internal_port": [
                    223,
                    224,
                    225
                  ],
                  "path": "path4"
                },
                "mode": "random",
                "config": {
                  "sticky_sessions": false,
                  "destination_retries": 166,
                  "tls": {
                    "server_name": "server_name2",
                    "allow_insecure": false,
                    "client_cert_auth": "client_cert_auth6",
                    "client_auth": "require"
                  },
                  "timeouts": {
                    "destination_connection": "destination_connection6"
                  },
                  "extension": {
                    "type": "type6",
                    "details": {
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
                    }
                  }
                }
              },
              {
                "match": {
                  "domains": [
                    "domains0",
                    "domains1",
                    "domains2"
                  ],
                  "internal_port": [
                    223,
                    224,
                    225
                  ],
                  "path": "path4"
                },
                "mode": "random",
                "config": {
                  "sticky_sessions": false,
                  "destination_retries": 166,
                  "tls": {
                    "server_name": "server_name2",
                    "allow_insecure": false,
                    "client_cert_auth": "client_cert_auth6",
                    "client_auth": "require"
                  },
                  "timeouts": {
                    "destination_connection": "destination_connection6"
                  },
                  "extension": {
                    "type": "type6",
                    "details": {
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
                    }
                  }
                }
              }
            ]
          }
        }
      }
    },
    "auto_update": false
  },
  "discovery": {
    "enable": false,
    "container_id": "container_id6",
    "high_availability": false,
    "auto_update": false,
    "config": {
      "hosts": {
        "key0": {
          "ipv4": [
            "ipv42",
            "ipv43"
          ],
          "ipv6": [
            "ipv66",
            "ipv67",
            "ipv68"
          ]
        }
      }
    }
  },
  "vpn": {
    "enable": false,
    "container_id": "container_id0",
    "auto_update": false,
    "config": {
      "allow_internet": false,
      "auth": {
        "webhook": "webhook4",
        "cycle_accounts": false,
        "vpn_accounts": false
      }
    }
  },
  "scheduler": {
    "enable": false,
    "container_id": "container_id0",
    "high_availability": false,
    "auto_update": false,
    "config": {
      "public": false,
      "access_keys": [
        {
          "name": "name4",
          "secret": "secret0",
          "ips": [
            "ips8"
          ]
        }
      ]
    }
  }
}
```

