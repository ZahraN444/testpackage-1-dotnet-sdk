
# Load Balancer Telemetry Url Request Handler 1

Object containing hit count and timing data for proxy responses.

## Structure

`LoadBalancerTelemetryUrlRequestHandler1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Hits` | `int` | Required | The number of hits to a specific URL handler. |
| `TimingMs` | `int` | Required | The cumulative ms of response time across all hits. |

## Example (as JSON)

```json
{
  "hits": 208,
  "timing_ms": 232
}
```

