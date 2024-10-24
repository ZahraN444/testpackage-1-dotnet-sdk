
# Load Balancer Telemetry Url Request Handler 3

Object containing hit count and timing data for forward responses.

## Structure

`LoadBalancerTelemetryUrlRequestHandler3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Hits` | `int` | Required | The number of hits to a specific URL handler. |
| `TimingMs` | `int` | Required | The cumulative ms of response time across all hits. |

## Example (as JSON)

```json
{
  "hits": 86,
  "timing_ms": 14
}
```

