
# Latest

## Structure

`Latest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Time` | `DateTime?` | Optional | - |
| `Started` | `DateTime?` | Optional | - |
| `Version` | `string` | Optional | - |
| `DatasetId` | `int?` | Optional | - |
| `Router` | [`LatestRouter`](../../doc/models/containers/latest-router.md) | Optional | This is a container for any-of cases. |
| `Urls` | [`LatestUrls`](../../doc/models/containers/latest-urls.md) | Optional | This is a container for any-of cases. |
| `Metrics` | [`LoadBalancerTelemetryControllerMetrics`](../../doc/models/load-balancer-telemetry-controller-metrics.md) | Optional | - |

## Example (as JSON)

```json
{
  "time": "01/30/2021 08:30:00",
  "started": "01/30/2021 08:30:00",
  "version": "version0",
  "dataset_id": 64,
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
  }
}
```

