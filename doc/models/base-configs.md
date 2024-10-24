
# Base Configs

## Structure

`BaseConfigs`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Haproxy` | [`HaProxyConfig1`](../../doc/models/ha-proxy-config-1.md) | Required | Describes settings that are passed to HAProxy within the load balancer. |
| `V1` | [`V1LbConfig`](../../doc/models/v1-lb-config.md) | Required | - |

## Example (as JSON)

```json
{
  "haproxy": {
    "default": {
      "frontend": {
        "mode": "tcp",
        "max_connections": 190,
        "timeouts": {
          "client_secs": 228,
          "client_fin_ms": 250,
          "http_keep_alive_ms": 122,
          "http_request_ms": 102
        }
      },
      "backend": {
        "balance": "roundrobin",
        "timeouts": {
          "server_secs": 200,
          "server_fin_ms": 126,
          "connect_ms": 174,
          "queue_ms": 16,
          "tunnel_secs": 16
        }
      }
    },
    "ports": {
      "key0": {
        "frontend": {
          "mode": "tcp",
          "max_connections": 190,
          "timeouts": {
            "client_secs": 228,
            "client_fin_ms": 250,
            "http_keep_alive_ms": 122,
            "http_request_ms": 102
          }
        },
        "backend": {
          "balance": "roundrobin",
          "timeouts": {
            "server_secs": 200,
            "server_fin_ms": 126,
            "connect_ms": 174,
            "queue_ms": 16,
            "tunnel_secs": 16
          }
        }
      }
    }
  },
  "v1": {
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
}
```

