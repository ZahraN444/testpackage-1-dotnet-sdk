
# V1 Environments Services Lb Telemetry Latest Controllers Response

## Structure

`V1EnvironmentsServicesLbTelemetryLatestControllersResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`LoadBalancerLatestControllers`](../../doc/models/load-balancer-latest-controllers.md) | Required | Information about the latest controllers that generated traffic. |
| `Includes` | [`LoadBalancerLatestControllersIncludes`](../../doc/models/load-balancer-latest-controllers-includes.md) | Optional | Optionally included resources for load balancer controllers |

## Example (as JSON)

```json
{
  "data": {
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
  },
  "includes": {
    "creators": {
      "accounts": {
        "key0": {
          "name": {
            "first": "first6",
            "last": "last0"
          },
          "email": {
            "address": "address2",
            "verified": false,
            "added": "2016-03-13T12:52:32.123Z"
          },
          "id": "id0",
          "events": {
            "last_login": "2016-03-13T12:52:32.123Z"
          }
        }
      },
      "employees": {
        "key0": {
          "name": {
            "first": "first6",
            "last": "last0"
          },
          "email": {
            "address": "address2",
            "verified": false,
            "added": "2016-03-13T12:52:32.123Z"
          },
          "id": "id4",
          "events": {
            "last_login": "2016-03-13T12:52:32.123Z"
          }
        },
        "key1": {
          "name": {
            "first": "first6",
            "last": "last0"
          },
          "email": {
            "address": "address2",
            "verified": false,
            "added": "2016-03-13T12:52:32.123Z"
          },
          "id": "id4",
          "events": {
            "last_login": "2016-03-13T12:52:32.123Z"
          }
        }
      },
      "visitors": {
        "key0": {
          "name": {
            "first": "first6",
            "last": "last0"
          },
          "email": {
            "address": "address2",
            "verified": false,
            "added": "2016-03-13T12:52:32.123Z"
          },
          "id": "id8",
          "events": {
            "last_login": "2016-03-13T12:52:32.123Z"
          }
        }
      },
      "environments": {
        "key0": {
          "id": "id2",
          "identifier": "identifier0",
          "name": "name2",
          "cluster": "cluster8",
          "about": {
            "description": "description4",
            "favorite": false
          },
          "creator": {
            "id": "id8",
            "type": "employee"
          },
          "hub_id": "hub_id4",
          "state": {
            "current": "cloning",
            "changed": "2016-03-13T12:52:32.123Z",
            "error": {
              "message": "message4",
              "time": "2016-03-13T12:52:32.123Z"
            }
          },
          "events": {
            "created": "2016-03-13T12:52:32.123Z",
            "updated": "2016-03-13T12:52:32.123Z",
            "deleted": "2016-03-13T12:52:32.123Z"
          },
          "features": {
            "legacy_networking": false
          },
          "services": {
            "loadbalancer": {
              "enable": false,
              "container_id": "container_id2",
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
          },
          "private_network": {
            "vxlan_tag": 126,
            "subnet": "subnet8",
            "ipv6": {
              "ip": "ip0",
              "cidr": "cidr6"
            },
            "legacy": {
              "subnet": 58,
              "ipv4": {
                "ip": "ip8",
                "cidr": "cidr4"
              }
            }
          },
          "deployments": {
            "tags": {
              "key0": "tags1",
              "key1": "tags2"
            }
          },
          "meta": {
            "containers_count": {
              "state": {
                "key0": 148,
                "key1": 149,
                "key2": 150
              },
              "total": 80,
              "available": 126
            },
            "instances_count": {
              "state": {
                "key0": 136,
                "key1": 135,
                "key2": 134
              },
              "total": 108,
              "available": 154
            },
            "containers": [
              {
                "id": "id2",
                "name": "name2",
                "state": {
                  "current": "deleting",
                  "desired": "stopping",
                  "changed": "2016-03-13T12:52:32.123Z",
                  "error": {
                    "message": "message4",
                    "time": "2016-03-13T12:52:32.123Z"
                  }
                },
                "image": {
                  "id": "id6",
                  "service": "discovery"
                },
                "environment": {
                  "id": "id6",
                  "cluster": "cluster8",
                  "container_subnet": "container_subnet6",
                  "ipv6": {
                    "ip": "ip8",
                    "cidr": "cidr4"
                  },
                  "legacy": {
                    "subnet": 58,
                    "ipv4": {
                      "ip": "ip8",
                      "cidr": "cidr4"
                    }
                  }
                }
              }
            ]
          }
        }
      },
      "api_keys": {
        "key0": {
          "id": "id0",
          "name": "name0",
          "hub_id": "hub_id2",
          "secret": "secret4",
          "permissions": {
            "all_environments": false,
            "environments": [
              {
                "id": "id2",
                "manage": false
              }
            ]
          },
          "capabilities": {
            "all": false,
            "specific": [
              "specific4"
            ]
          },
          "ips": [
            "ips4"
          ],
          "state": {
            "current": "deleted",
            "changed": "2016-03-13T12:52:32.123Z",
            "error": {
              "message": "message4",
              "time": "2016-03-13T12:52:32.123Z"
            }
          },
          "events": {
            "key0": "2016-03-13T12:52:32.123Z",
            "key1": "2016-03-13T12:52:32.123Z"
          }
        }
      }
    },
    "stack_builds": {
      "key0": {
        "id": "id6",
        "hub_id": "hub_id8",
        "stack_id": "stack_id6",
        "spec": {
          "version": "version4",
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
            }
          },
          "services": {
            "discovery": {
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
                },
                "key1": {
                  "ipv4": [
                    "ipv42",
                    "ipv43"
                  ],
                  "ipv6": [
                    "ipv66",
                    "ipv67",
                    "ipv68"
                  ]
                },
                "key2": {
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
            },
            "loadbalancer": {
              "type": "haproxy",
              "ipv4": false,
              "ipv6": false,
              "details": {
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
                  },
                  "key1": {
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
                  "key2": {
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
              }
            },
            "vpn": {
              "auth": {
                "webhook": "webhook4",
                "cycle_accounts": false,
                "vpn_accounts": false
              },
              "allow_internet": false
            }
          },
          "annotations": {
            "key0": {
              "key1": "val1",
              "key2": "val2"
            }
          }
        },
        "about": {
          "version": "version0",
          "description": "description4",
          "git_commit": {
            "hash": "hash8",
            "message": "message8",
            "time": "2016-03-13T12:52:32.123Z",
            "author": {
              "name": "name0",
              "email": "email6"
            }
          }
        },
        "instructions": {
          "git": {
            "type": "hash",
            "value": "value4"
          },
          "variables": {
            "key0": "variables1",
            "key1": "variables0",
            "key2": "variables9"
          }
        },
        "events": {
          "created": "2016-03-13T12:52:32.123Z",
          "updated": "2016-03-13T12:52:32.123Z",
          "deleted": "2016-03-13T12:52:32.123Z"
        },
        "state": {
          "current": "deleted",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "meta": {
          "containers_count": {
            "state": {
              "key0": 148,
              "key1": 149,
              "key2": 150
            },
            "total": 80,
            "available": 126
          }
        }
      },
      "key1": {
        "id": "id6",
        "hub_id": "hub_id8",
        "stack_id": "stack_id6",
        "spec": {
          "version": "version4",
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
            }
          },
          "services": {
            "discovery": {
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
                },
                "key1": {
                  "ipv4": [
                    "ipv42",
                    "ipv43"
                  ],
                  "ipv6": [
                    "ipv66",
                    "ipv67",
                    "ipv68"
                  ]
                },
                "key2": {
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
            },
            "loadbalancer": {
              "type": "haproxy",
              "ipv4": false,
              "ipv6": false,
              "details": {
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
                  },
                  "key1": {
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
                  "key2": {
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
              }
            },
            "vpn": {
              "auth": {
                "webhook": "webhook4",
                "cycle_accounts": false,
                "vpn_accounts": false
              },
              "allow_internet": false
            }
          },
          "annotations": {
            "key0": {
              "key1": "val1",
              "key2": "val2"
            }
          }
        },
        "about": {
          "version": "version0",
          "description": "description4",
          "git_commit": {
            "hash": "hash8",
            "message": "message8",
            "time": "2016-03-13T12:52:32.123Z",
            "author": {
              "name": "name0",
              "email": "email6"
            }
          }
        },
        "instructions": {
          "git": {
            "type": "hash",
            "value": "value4"
          },
          "variables": {
            "key0": "variables1",
            "key1": "variables0",
            "key2": "variables9"
          }
        },
        "events": {
          "created": "2016-03-13T12:52:32.123Z",
          "updated": "2016-03-13T12:52:32.123Z",
          "deleted": "2016-03-13T12:52:32.123Z"
        },
        "state": {
          "current": "deleted",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "meta": {
          "containers_count": {
            "state": {
              "key0": 148,
              "key1": 149,
              "key2": 150
            },
            "total": 80,
            "available": 126
          }
        }
      },
      "key2": {
        "id": "id6",
        "hub_id": "hub_id8",
        "stack_id": "stack_id6",
        "spec": {
          "version": "version4",
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
            }
          },
          "services": {
            "discovery": {
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
                },
                "key1": {
                  "ipv4": [
                    "ipv42",
                    "ipv43"
                  ],
                  "ipv6": [
                    "ipv66",
                    "ipv67",
                    "ipv68"
                  ]
                },
                "key2": {
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
            },
            "loadbalancer": {
              "type": "haproxy",
              "ipv4": false,
              "ipv6": false,
              "details": {
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
                  },
                  "key1": {
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
                  "key2": {
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
              }
            },
            "vpn": {
              "auth": {
                "webhook": "webhook4",
                "cycle_accounts": false,
                "vpn_accounts": false
              },
              "allow_internet": false
            }
          },
          "annotations": {
            "key0": {
              "key1": "val1",
              "key2": "val2"
            }
          }
        },
        "about": {
          "version": "version0",
          "description": "description4",
          "git_commit": {
            "hash": "hash8",
            "message": "message8",
            "time": "2016-03-13T12:52:32.123Z",
            "author": {
              "name": "name0",
              "email": "email6"
            }
          }
        },
        "instructions": {
          "git": {
            "type": "hash",
            "value": "value4"
          },
          "variables": {
            "key0": "variables1",
            "key1": "variables0",
            "key2": "variables9"
          }
        },
        "events": {
          "created": "2016-03-13T12:52:32.123Z",
          "updated": "2016-03-13T12:52:32.123Z",
          "deleted": "2016-03-13T12:52:32.123Z"
        },
        "state": {
          "current": "deleted",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "meta": {
          "containers_count": {
            "state": {
              "key0": 148,
              "key1": 149,
              "key2": 150
            },
            "total": 80,
            "available": 126
          }
        }
      }
    },
    "stacks": {
      "key0": {
        "id": "id2",
        "identifier": "identifier0",
        "name": "name2",
        "hub_id": "hub_id4",
        "creator": {
          "type": "employee",
          "id": "id8"
        },
        "source": {
          "type": "git-repo",
          "details": {
            "url": "url4",
            "branch": "branch6",
            "auth": {
              "type": "type0",
              "credentials": {
                "username": "username4",
                "password": "password0"
              }
            },
            "ref": {
              "type": "type0",
              "value": "value2"
            }
          }
        },
        "state": {
          "current": "deleted",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "variables": {
          "key0": "variables1",
          "key1": "variables0"
        },
        "events": {
          "created": "2016-03-13T12:52:32.123Z",
          "updated": "2016-03-13T12:52:32.123Z",
          "deleted": "2016-03-13T12:52:32.123Z",
          "last_build": "2016-03-13T12:52:32.123Z"
        },
        "meta": {
          "containers_count": {
            "state": {
              "key0": 148,
              "key1": 149,
              "key2": 150
            },
            "total": 80,
            "available": 126
          },
          "builds_count": {
            "state": {
              "key0": 112,
              "key1": 113
            },
            "total": 116,
            "available": 162
          }
        }
      },
      "key1": {
        "id": "id2",
        "identifier": "identifier0",
        "name": "name2",
        "hub_id": "hub_id4",
        "creator": {
          "type": "employee",
          "id": "id8"
        },
        "source": {
          "type": "git-repo",
          "details": {
            "url": "url4",
            "branch": "branch6",
            "auth": {
              "type": "type0",
              "credentials": {
                "username": "username4",
                "password": "password0"
              }
            },
            "ref": {
              "type": "type0",
              "value": "value2"
            }
          }
        },
        "state": {
          "current": "deleted",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "variables": {
          "key0": "variables1",
          "key1": "variables0"
        },
        "events": {
          "created": "2016-03-13T12:52:32.123Z",
          "updated": "2016-03-13T12:52:32.123Z",
          "deleted": "2016-03-13T12:52:32.123Z",
          "last_build": "2016-03-13T12:52:32.123Z"
        },
        "meta": {
          "containers_count": {
            "state": {
              "key0": 148,
              "key1": 149,
              "key2": 150
            },
            "total": 80,
            "available": 126
          },
          "builds_count": {
            "state": {
              "key0": 112,
              "key1": 113
            },
            "total": 116,
            "available": 162
          }
        }
      },
      "key2": {
        "id": "id2",
        "identifier": "identifier0",
        "name": "name2",
        "hub_id": "hub_id4",
        "creator": {
          "type": "employee",
          "id": "id8"
        },
        "source": {
          "type": "git-repo",
          "details": {
            "url": "url4",
            "branch": "branch6",
            "auth": {
              "type": "type0",
              "credentials": {
                "username": "username4",
                "password": "password0"
              }
            },
            "ref": {
              "type": "type0",
              "value": "value2"
            }
          }
        },
        "state": {
          "current": "deleted",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "variables": {
          "key0": "variables1",
          "key1": "variables0"
        },
        "events": {
          "created": "2016-03-13T12:52:32.123Z",
          "updated": "2016-03-13T12:52:32.123Z",
          "deleted": "2016-03-13T12:52:32.123Z",
          "last_build": "2016-03-13T12:52:32.123Z"
        },
        "meta": {
          "containers_count": {
            "state": {
              "key0": 148,
              "key1": 149,
              "key2": 150
            },
            "total": 80,
            "available": 126
          },
          "builds_count": {
            "state": {
              "key0": 112,
              "key1": 113
            },
            "total": 116,
            "available": 162
          }
        }
      }
    },
    "sources": {
      "key0": {
        "id": "id6",
        "identifier": "identifier6",
        "type": "direct",
        "hub_id": "hub_id8",
        "name": "name6",
        "about": {
          "description": "description4"
        },
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
        "builder": {
          "integration_id": "integration_id6"
        },
        "creator": {
          "id": "id8",
          "type": "employee"
        },
        "state": {
          "current": "deleted",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "events": {
          "created": "2016-03-13T12:52:32.123Z",
          "updated": "2016-03-13T12:52:32.123Z",
          "deleted": "2016-03-13T12:52:32.123Z"
        },
        "meta": {
          "images_count": {
            "total": 68.62,
            "state": {
              "new": 186.8,
              "downloading": 225.6,
              "building": 135.62,
              "verifying": 196.82,
              "saving": 30.94,
              "live": 41.96,
              "deleting": 5.94
            }
          }
        }
      }
    }
  }
}
```
