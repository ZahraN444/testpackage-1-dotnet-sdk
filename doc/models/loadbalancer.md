
# Loadbalancer

## Structure

`Loadbalancer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enable` | `bool?` | Optional | Whether or not the loadbalancer service is enabled. |
| `ContainerId` | `string` | Optional | The ID of the loadbalancer service container |
| `HighAvailability` | `bool?` | Optional | A boolean representing if this service container is set to high availability mode or not. |
| `AutoUpdate` | `bool?` | Optional | A boolean representing if this service container is set to autoupdate or not |
| `Config` | [`LoadbalancerConfig`](../../doc/models/containers/loadbalancer-config.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "enable": false,
  "container_id": "container_id0",
  "high_availability": false,
  "auto_update": false,
  "config": {
    "type": "v1",
    "ipv4": false,
    "ipv6": false,
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
        },
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
        },
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
}
```

