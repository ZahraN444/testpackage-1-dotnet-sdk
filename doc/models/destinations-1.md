
# Destinations 1

## Structure

`Destinations1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Requests` | [`Requests1`](../../doc/models/requests-1.md) | Required | - |

## Example (as JSON)

```json
{
  "requests": {
    "host": "abc.cycle.io",
    "method": "GET",
    "path": "/pathname",
    "total": 11,
    "last_hit": "01/30/2021 08:30:00",
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
      "http:404": 10
    },
    "errors": {
      "i/o timeout": 1
    }
  }
}
```

