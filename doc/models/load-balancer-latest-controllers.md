
# Load Balancer Latest Controllers

Information about the latest controllers that generated traffic.

## Structure

`LoadBalancerLatestControllers`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | - |
| `Controllers` | [`List<LoadBalancerLatestTelemetryController>`](../../doc/models/load-balancer-latest-telemetry-controller.md) | Optional | - |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "controllers": [
    {
      "time": "2016-03-13T12:52:32.123Z",
      "controller": "controller2",
      "instances": [
        {
          "id": "id2",
          "hub_id": "hub_id4",
          "environment_id": "environment_id0",
          "container_id": "container_id8",
          "instance_id": "instance_id2",
          "server_id": "server_id2",
          "cluster": "cluster8",
          "time": "2016-03-13T12:52:32.123Z",
          "controller": "controller2",
          "latest": {
            "time": "2016-03-13T12:52:32.123Z",
            "started": "2016-03-13T12:52:32.123Z",
            "version": "version8",
            "dataset_id": 140,
            "router": {
              "destinations": {
                "key0": {
                  "connections": {
                    "success": 136,
                    "unavailable": 28,
                    "errors": {
                      "key0": 81,
                      "key1": 82,
                      "key2": 83
                    },
                    "bytes_transmitted": 44,
                    "bytes_received": 2
                  },
                  "requests": {
                    "total": 146,
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  },
                  "latency_ms": [
                    98,
                    99,
                    100
                  ],
                  "instance_id": "instance_id2",
                  "container_id": "container_id8"
                },
                "key1": {
                  "connections": {
                    "success": 136,
                    "unavailable": 28,
                    "errors": {
                      "key0": 81,
                      "key1": 82,
                      "key2": 83
                    },
                    "bytes_transmitted": 44,
                    "bytes_received": 2
                  },
                  "requests": {
                    "total": 146,
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  },
                  "latency_ms": [
                    98,
                    99,
                    100
                  ],
                  "instance_id": "instance_id2",
                  "container_id": "container_id8"
                },
                "key2": {
                  "connections": {
                    "success": 136,
                    "unavailable": 28,
                    "errors": {
                      "key0": 81,
                      "key1": 82,
                      "key2": 83
                    },
                    "bytes_transmitted": 44,
                    "bytes_received": 2
                  },
                  "requests": {
                    "total": 146,
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  },
                  "latency_ms": [
                    98,
                    99,
                    100
                  ],
                  "instance_id": "instance_id2",
                  "container_id": "container_id8"
                }
              }
            },
            "urls": {
              "destinations": {
                "key0": {
                  "requests": {
                    "host": "host0",
                    "method": "method2",
                    "path": "path2",
                    "total": 146,
                    "last_hit": "2016-03-13T12:52:32.123Z",
                    "handlers": {
                      "proxy": {
                        "hits": 238,
                        "timing_ms": 202
                      },
                      "cache": {
                        "hits": 146,
                        "timing_ms": 38
                      },
                      "forward": {
                        "hits": 184,
                        "timing_ms": 112
                      },
                      "redirect": {
                        "hits": 110,
                        "timing_ms": 38
                      }
                    },
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  }
                },
                "key1": {
                  "requests": {
                    "host": "host0",
                    "method": "method2",
                    "path": "path2",
                    "total": 146,
                    "last_hit": "2016-03-13T12:52:32.123Z",
                    "handlers": {
                      "proxy": {
                        "hits": 238,
                        "timing_ms": 202
                      },
                      "cache": {
                        "hits": 146,
                        "timing_ms": 38
                      },
                      "forward": {
                        "hits": 184,
                        "timing_ms": 112
                      },
                      "redirect": {
                        "hits": 110,
                        "timing_ms": 38
                      }
                    },
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  }
                },
                "key2": {
                  "requests": {
                    "host": "host0",
                    "method": "method2",
                    "path": "path2",
                    "total": 146,
                    "last_hit": "2016-03-13T12:52:32.123Z",
                    "handlers": {
                      "proxy": {
                        "hits": 238,
                        "timing_ms": 202
                      },
                      "cache": {
                        "hits": 146,
                        "timing_ms": 38
                      },
                      "forward": {
                        "hits": 184,
                        "timing_ms": 112
                      },
                      "redirect": {
                        "hits": 110,
                        "timing_ms": 38
                      }
                    },
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  }
                }
              }
            },
            "metrics": {
              "disconnects": {
                "no_error": 196,
                "request_invalid": 248,
                "timeout_idle": 34,
                "router_none": 30,
                "router_nomatch": 90,
                "destination_unavailable": 48,
                "unknown_error": 218
              },
              "connections": 144,
              "requests": 72,
              "bytes_transmitted": 68,
              "bytes_received": 22
            }
          },
          "snapshots": [
            {
              "time": "2016-03-13T12:52:32.123Z",
              "started": "2016-03-13T12:52:32.123Z",
              "version": "version8",
              "dataset_id": 120,
              "router": {
                "destinations": {
                  "key0": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  },
                  "key1": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  },
                  "key2": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  }
                }
              },
              "urls": {
                "destinations": {
                  "key0": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  },
                  "key1": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  },
                  "key2": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  }
                }
              },
              "metrics": {
                "disconnects": {
                  "no_error": 196,
                  "request_invalid": 248,
                  "timeout_idle": 34,
                  "router_none": 30,
                  "router_nomatch": 90,
                  "destination_unavailable": 48,
                  "unknown_error": 218
                },
                "connections": 144,
                "requests": 72,
                "bytes_transmitted": 68,
                "bytes_received": 22
              }
            },
            {
              "time": "2016-03-13T12:52:32.123Z",
              "started": "2016-03-13T12:52:32.123Z",
              "version": "version8",
              "dataset_id": 120,
              "router": {
                "destinations": {
                  "key0": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  },
                  "key1": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  },
                  "key2": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  }
                }
              },
              "urls": {
                "destinations": {
                  "key0": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  },
                  "key1": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  },
                  "key2": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  }
                }
              },
              "metrics": {
                "disconnects": {
                  "no_error": 196,
                  "request_invalid": 248,
                  "timeout_idle": 34,
                  "router_none": 30,
                  "router_nomatch": 90,
                  "destination_unavailable": 48,
                  "unknown_error": 218
                },
                "connections": 144,
                "requests": 72,
                "bytes_transmitted": 68,
                "bytes_received": 22
              }
            }
          ]
        },
        {
          "id": "id2",
          "hub_id": "hub_id4",
          "environment_id": "environment_id0",
          "container_id": "container_id8",
          "instance_id": "instance_id2",
          "server_id": "server_id2",
          "cluster": "cluster8",
          "time": "2016-03-13T12:52:32.123Z",
          "controller": "controller2",
          "latest": {
            "time": "2016-03-13T12:52:32.123Z",
            "started": "2016-03-13T12:52:32.123Z",
            "version": "version8",
            "dataset_id": 140,
            "router": {
              "destinations": {
                "key0": {
                  "connections": {
                    "success": 136,
                    "unavailable": 28,
                    "errors": {
                      "key0": 81,
                      "key1": 82,
                      "key2": 83
                    },
                    "bytes_transmitted": 44,
                    "bytes_received": 2
                  },
                  "requests": {
                    "total": 146,
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  },
                  "latency_ms": [
                    98,
                    99,
                    100
                  ],
                  "instance_id": "instance_id2",
                  "container_id": "container_id8"
                },
                "key1": {
                  "connections": {
                    "success": 136,
                    "unavailable": 28,
                    "errors": {
                      "key0": 81,
                      "key1": 82,
                      "key2": 83
                    },
                    "bytes_transmitted": 44,
                    "bytes_received": 2
                  },
                  "requests": {
                    "total": 146,
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  },
                  "latency_ms": [
                    98,
                    99,
                    100
                  ],
                  "instance_id": "instance_id2",
                  "container_id": "container_id8"
                },
                "key2": {
                  "connections": {
                    "success": 136,
                    "unavailable": 28,
                    "errors": {
                      "key0": 81,
                      "key1": 82,
                      "key2": 83
                    },
                    "bytes_transmitted": 44,
                    "bytes_received": 2
                  },
                  "requests": {
                    "total": 146,
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  },
                  "latency_ms": [
                    98,
                    99,
                    100
                  ],
                  "instance_id": "instance_id2",
                  "container_id": "container_id8"
                }
              }
            },
            "urls": {
              "destinations": {
                "key0": {
                  "requests": {
                    "host": "host0",
                    "method": "method2",
                    "path": "path2",
                    "total": 146,
                    "last_hit": "2016-03-13T12:52:32.123Z",
                    "handlers": {
                      "proxy": {
                        "hits": 238,
                        "timing_ms": 202
                      },
                      "cache": {
                        "hits": 146,
                        "timing_ms": 38
                      },
                      "forward": {
                        "hits": 184,
                        "timing_ms": 112
                      },
                      "redirect": {
                        "hits": 110,
                        "timing_ms": 38
                      }
                    },
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  }
                },
                "key1": {
                  "requests": {
                    "host": "host0",
                    "method": "method2",
                    "path": "path2",
                    "total": 146,
                    "last_hit": "2016-03-13T12:52:32.123Z",
                    "handlers": {
                      "proxy": {
                        "hits": 238,
                        "timing_ms": 202
                      },
                      "cache": {
                        "hits": 146,
                        "timing_ms": 38
                      },
                      "forward": {
                        "hits": 184,
                        "timing_ms": 112
                      },
                      "redirect": {
                        "hits": 110,
                        "timing_ms": 38
                      }
                    },
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  }
                },
                "key2": {
                  "requests": {
                    "host": "host0",
                    "method": "method2",
                    "path": "path2",
                    "total": 146,
                    "last_hit": "2016-03-13T12:52:32.123Z",
                    "handlers": {
                      "proxy": {
                        "hits": 238,
                        "timing_ms": 202
                      },
                      "cache": {
                        "hits": 146,
                        "timing_ms": 38
                      },
                      "forward": {
                        "hits": 184,
                        "timing_ms": 112
                      },
                      "redirect": {
                        "hits": 110,
                        "timing_ms": 38
                      }
                    },
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  }
                }
              }
            },
            "metrics": {
              "disconnects": {
                "no_error": 196,
                "request_invalid": 248,
                "timeout_idle": 34,
                "router_none": 30,
                "router_nomatch": 90,
                "destination_unavailable": 48,
                "unknown_error": 218
              },
              "connections": 144,
              "requests": 72,
              "bytes_transmitted": 68,
              "bytes_received": 22
            }
          },
          "snapshots": [
            {
              "time": "2016-03-13T12:52:32.123Z",
              "started": "2016-03-13T12:52:32.123Z",
              "version": "version8",
              "dataset_id": 120,
              "router": {
                "destinations": {
                  "key0": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  },
                  "key1": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  },
                  "key2": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  }
                }
              },
              "urls": {
                "destinations": {
                  "key0": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  },
                  "key1": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  },
                  "key2": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  }
                }
              },
              "metrics": {
                "disconnects": {
                  "no_error": 196,
                  "request_invalid": 248,
                  "timeout_idle": 34,
                  "router_none": 30,
                  "router_nomatch": 90,
                  "destination_unavailable": 48,
                  "unknown_error": 218
                },
                "connections": 144,
                "requests": 72,
                "bytes_transmitted": 68,
                "bytes_received": 22
              }
            },
            {
              "time": "2016-03-13T12:52:32.123Z",
              "started": "2016-03-13T12:52:32.123Z",
              "version": "version8",
              "dataset_id": 120,
              "router": {
                "destinations": {
                  "key0": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  },
                  "key1": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  },
                  "key2": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  }
                }
              },
              "urls": {
                "destinations": {
                  "key0": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  },
                  "key1": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  },
                  "key2": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  }
                }
              },
              "metrics": {
                "disconnects": {
                  "no_error": 196,
                  "request_invalid": 248,
                  "timeout_idle": 34,
                  "router_none": 30,
                  "router_nomatch": 90,
                  "destination_unavailable": 48,
                  "unknown_error": 218
                },
                "connections": 144,
                "requests": 72,
                "bytes_transmitted": 68,
                "bytes_received": 22
              }
            }
          ]
        },
        {
          "id": "id2",
          "hub_id": "hub_id4",
          "environment_id": "environment_id0",
          "container_id": "container_id8",
          "instance_id": "instance_id2",
          "server_id": "server_id2",
          "cluster": "cluster8",
          "time": "2016-03-13T12:52:32.123Z",
          "controller": "controller2",
          "latest": {
            "time": "2016-03-13T12:52:32.123Z",
            "started": "2016-03-13T12:52:32.123Z",
            "version": "version8",
            "dataset_id": 140,
            "router": {
              "destinations": {
                "key0": {
                  "connections": {
                    "success": 136,
                    "unavailable": 28,
                    "errors": {
                      "key0": 81,
                      "key1": 82,
                      "key2": 83
                    },
                    "bytes_transmitted": 44,
                    "bytes_received": 2
                  },
                  "requests": {
                    "total": 146,
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  },
                  "latency_ms": [
                    98,
                    99,
                    100
                  ],
                  "instance_id": "instance_id2",
                  "container_id": "container_id8"
                },
                "key1": {
                  "connections": {
                    "success": 136,
                    "unavailable": 28,
                    "errors": {
                      "key0": 81,
                      "key1": 82,
                      "key2": 83
                    },
                    "bytes_transmitted": 44,
                    "bytes_received": 2
                  },
                  "requests": {
                    "total": 146,
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  },
                  "latency_ms": [
                    98,
                    99,
                    100
                  ],
                  "instance_id": "instance_id2",
                  "container_id": "container_id8"
                },
                "key2": {
                  "connections": {
                    "success": 136,
                    "unavailable": 28,
                    "errors": {
                      "key0": 81,
                      "key1": 82,
                      "key2": 83
                    },
                    "bytes_transmitted": 44,
                    "bytes_received": 2
                  },
                  "requests": {
                    "total": 146,
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  },
                  "latency_ms": [
                    98,
                    99,
                    100
                  ],
                  "instance_id": "instance_id2",
                  "container_id": "container_id8"
                }
              }
            },
            "urls": {
              "destinations": {
                "key0": {
                  "requests": {
                    "host": "host0",
                    "method": "method2",
                    "path": "path2",
                    "total": 146,
                    "last_hit": "2016-03-13T12:52:32.123Z",
                    "handlers": {
                      "proxy": {
                        "hits": 238,
                        "timing_ms": 202
                      },
                      "cache": {
                        "hits": 146,
                        "timing_ms": 38
                      },
                      "forward": {
                        "hits": 184,
                        "timing_ms": 112
                      },
                      "redirect": {
                        "hits": 110,
                        "timing_ms": 38
                      }
                    },
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  }
                },
                "key1": {
                  "requests": {
                    "host": "host0",
                    "method": "method2",
                    "path": "path2",
                    "total": 146,
                    "last_hit": "2016-03-13T12:52:32.123Z",
                    "handlers": {
                      "proxy": {
                        "hits": 238,
                        "timing_ms": 202
                      },
                      "cache": {
                        "hits": 146,
                        "timing_ms": 38
                      },
                      "forward": {
                        "hits": 184,
                        "timing_ms": 112
                      },
                      "redirect": {
                        "hits": 110,
                        "timing_ms": 38
                      }
                    },
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  }
                },
                "key2": {
                  "requests": {
                    "host": "host0",
                    "method": "method2",
                    "path": "path2",
                    "total": 146,
                    "last_hit": "2016-03-13T12:52:32.123Z",
                    "handlers": {
                      "proxy": {
                        "hits": 238,
                        "timing_ms": 202
                      },
                      "cache": {
                        "hits": 146,
                        "timing_ms": 38
                      },
                      "forward": {
                        "hits": 184,
                        "timing_ms": 112
                      },
                      "redirect": {
                        "hits": 110,
                        "timing_ms": 38
                      }
                    },
                    "responses": {
                      "key0": 151
                    },
                    "errors": {
                      "key0": 177,
                      "key1": 178,
                      "key2": 179
                    }
                  }
                }
              }
            },
            "metrics": {
              "disconnects": {
                "no_error": 196,
                "request_invalid": 248,
                "timeout_idle": 34,
                "router_none": 30,
                "router_nomatch": 90,
                "destination_unavailable": 48,
                "unknown_error": 218
              },
              "connections": 144,
              "requests": 72,
              "bytes_transmitted": 68,
              "bytes_received": 22
            }
          },
          "snapshots": [
            {
              "time": "2016-03-13T12:52:32.123Z",
              "started": "2016-03-13T12:52:32.123Z",
              "version": "version8",
              "dataset_id": 120,
              "router": {
                "destinations": {
                  "key0": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  },
                  "key1": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  },
                  "key2": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  }
                }
              },
              "urls": {
                "destinations": {
                  "key0": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  },
                  "key1": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  },
                  "key2": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  }
                }
              },
              "metrics": {
                "disconnects": {
                  "no_error": 196,
                  "request_invalid": 248,
                  "timeout_idle": 34,
                  "router_none": 30,
                  "router_nomatch": 90,
                  "destination_unavailable": 48,
                  "unknown_error": 218
                },
                "connections": 144,
                "requests": 72,
                "bytes_transmitted": 68,
                "bytes_received": 22
              }
            },
            {
              "time": "2016-03-13T12:52:32.123Z",
              "started": "2016-03-13T12:52:32.123Z",
              "version": "version8",
              "dataset_id": 120,
              "router": {
                "destinations": {
                  "key0": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  },
                  "key1": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  },
                  "key2": {
                    "connections": {
                      "success": 136,
                      "unavailable": 28,
                      "errors": {
                        "key0": 81,
                        "key1": 82,
                        "key2": 83
                      },
                      "bytes_transmitted": 44,
                      "bytes_received": 2
                    },
                    "requests": {
                      "total": 146,
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    },
                    "latency_ms": [
                      98,
                      99,
                      100
                    ],
                    "instance_id": "instance_id2",
                    "container_id": "container_id8"
                  }
                }
              },
              "urls": {
                "destinations": {
                  "key0": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  },
                  "key1": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  },
                  "key2": {
                    "requests": {
                      "host": "host0",
                      "method": "method2",
                      "path": "path2",
                      "total": 146,
                      "last_hit": "2016-03-13T12:52:32.123Z",
                      "handlers": {
                        "proxy": {
                          "hits": 238,
                          "timing_ms": 202
                        },
                        "cache": {
                          "hits": 146,
                          "timing_ms": 38
                        },
                        "forward": {
                          "hits": 184,
                          "timing_ms": 112
                        },
                        "redirect": {
                          "hits": 110,
                          "timing_ms": 38
                        }
                      },
                      "responses": {
                        "key0": 151
                      },
                      "errors": {
                        "key0": 177,
                        "key1": 178,
                        "key2": 179
                      }
                    }
                  }
                }
              },
              "metrics": {
                "disconnects": {
                  "no_error": 196,
                  "request_invalid": 248,
                  "timeout_idle": 34,
                  "router_none": 30,
                  "router_nomatch": 90,
                  "destination_unavailable": 48,
                  "unknown_error": 218
                },
                "connections": 144,
                "requests": 72,
                "bytes_transmitted": 68,
                "bytes_received": 22
              }
            }
          ]
        }
      ]
    }
  ]
}
```

