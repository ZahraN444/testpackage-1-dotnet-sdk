
# Load Balancer Telemetry Snapshot

## Structure

`LoadBalancerTelemetrySnapshot`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Time` | `DateTime` | Required | - |
| `Started` | `DateTime` | Required | - |
| `Version` | `string` | Optional | - |
| `DatasetId` | `int` | Required | - |
| `Router` | [`LoadBalancerTelemetrySnapshotRouter`](../../doc/models/containers/load-balancer-telemetry-snapshot-router.md) | Optional | This is a container for any-of cases. |
| `Urls` | [`LoadBalancerTelemetrySnapshotUrls`](../../doc/models/containers/load-balancer-telemetry-snapshot-urls.md) | Optional | This is a container for any-of cases. |
| `Metrics` | [`LoadBalancerTelemetryControllerMetrics`](../../doc/models/load-balancer-telemetry-controller-metrics.md) | Required | - |

## Example (as JSON)

```json
{
  "time": "01/30/2021 08:30:00",
  "started": "01/30/2021 08:30:00",
  "dataset_id": 140,
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
  },
  "version": "version8",
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
  }
}
```

