
# Requests 1

## Structure

`Requests1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Host` | `string` | Required | The host name of the URL request. |
| `Method` | `string` | Required | The HTTP method of the URL request. |
| `Path` | `string` | Required | The path portion of the inbound URL request. |
| `Total` | `int` | Required | The number of requests to a this URL. |
| `LastHit` | `DateTime` | Required | The date of the most recent hit to the URL. |
| `Handlers` | [`Handlers`](../../doc/models/handlers.md) | Required | An object describing the relative breakdown of proxy, cache, forward, and redirect URL responses. |
| `Responses` | `Dictionary<string, int>` | Optional | An object where the key is the response type and the value is the number of hits with that response. |
| `Errors` | `Dictionary<string, int>` | Optional | An object where the key is the error type and the value is the number of hits with that error. |

## Example (as JSON)

```json
{
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
```

