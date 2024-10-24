
# Load Balancer Telemetry Url Metrics

## Structure

`LoadBalancerTelemetryUrlMetrics`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Destinations` | [`Dictionary<string, Destinations1>`](../../doc/models/destinations-1.md) | Required | - |

## Example (as JSON)

```json
{
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
```

