
# Load Balancer Latest Telemetry Instance

Detailed telemetry for a load balancer instance at a point in time.

## Structure

`LoadBalancerLatestTelemetryInstance`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `EnvironmentId` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `ContainerId` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `InstanceId` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `ServerId` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Cluster` | `string` | Required | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `Time` | `DateTime` | Required | - |
| `Controller` | `string` | Required | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `Latest` | [`LoadBalancerLatestTelemetryInstanceLatest`](../../doc/models/containers/load-balancer-latest-telemetry-instance-latest.md) | Optional | This is a container for any-of cases. |
| `Snapshots` | [`List<LoadBalancerTelemetrySnapshot>`](../../doc/models/load-balancer-telemetry-snapshot.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "hub_id": "651586fca6078e98982dbd90",
  "environment_id": "651586fca6078e98982dbd90",
  "container_id": "651586fca6078e98982dbd90",
  "instance_id": "651586fca6078e98982dbd90",
  "server_id": "651586fca6078e98982dbd90",
  "cluster": "cluster0",
  "time": "01/30/2021 08:30:00",
  "controller": "controller4",
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
```

