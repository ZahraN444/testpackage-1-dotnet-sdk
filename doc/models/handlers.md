
# Handlers

An object describing the relative breakdown of proxy, cache, forward, and redirect URL responses.

## Structure

`Handlers`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Proxy` | [`LoadBalancerTelemetryUrlRequestHandler1`](../../doc/models/load-balancer-telemetry-url-request-handler-1.md) | Required | Object containing hit count and timing data for proxy responses. |
| `Cache` | [`LoadBalancerTelemetryUrlRequestHandler2`](../../doc/models/load-balancer-telemetry-url-request-handler-2.md) | Required | Object containing hit count and timing data for cache responses. |
| `Forward` | [`LoadBalancerTelemetryUrlRequestHandler3`](../../doc/models/load-balancer-telemetry-url-request-handler-3.md) | Required | Object containing hit count and timing data for forward responses. |
| `Redirect` | [`LoadBalancerTelemetryUrlRequestHandler4`](../../doc/models/load-balancer-telemetry-url-request-handler-4.md) | Required | Object containing hit count and timing data for redirect responses. |

## Example (as JSON)

```json
{
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
}
```

