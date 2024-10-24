
# V1 Environments Services Lb Tasks Request

## Structure

`V1EnvironmentsServicesLbTasksRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The name of the action to perform.<br>**Default**: `"reconfigure"` |
| `Contents` | [`Contents8`](../../doc/models/contents-8.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "reconfigure",
  "contents": {
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
}
```

