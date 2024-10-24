
# V1 Environments Services Lb Response

## Structure

`V1EnvironmentsServicesLbResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Data2`](../../doc/models/data-2.md) | Required | Information about an environments load balancer configuration, state, and availability settings. |

## Example (as JSON)

```json
{
  "data": {
    "default_config": {
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
    "default_type": "haproxy",
    "service": {
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
              "default": null,
              "identifier": null,
              "transport": {
                "disable": null,
                "mode": null,
                "config": {
                  "performance": null,
                  "ingress": null,
                  "timeouts": {
                    "idle": "72h45m2s"
                  },
                  "verbosity": null
                },
                "routers": [
                  {
                    "match": null,
                    "mode": null,
                    "config": {
                      "sticky_sessions": null,
                      "destination_retries": null,
                      "timeouts": {
                        "destination_connection": "72h45m2s"
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
    "base_configs": {
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

