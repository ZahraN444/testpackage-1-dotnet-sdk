
# V1 Lb Type

## Structure

`V1LbType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Ipv4` | `bool` | Required | Allow / disallow traffic to be routed via IPv4. |
| `Ipv6` | `bool` | Required | Allow / disallow traffic to be routed via IPv6. |
| `Type` | `string` | Required, Constant | **Default**: `"v1"` |
| `Details` | [`V1LbTypeDetails`](../../doc/models/containers/v1-lb-type-details.md) | Required | This is a container for any-of cases. |

## Example (as JSON)

```json
{
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
}
```

