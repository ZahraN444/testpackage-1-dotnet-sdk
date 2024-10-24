
# Load Balancer Telemetry Url Request Handler

## Structure

`LoadBalancerTelemetryUrlRequestHandler`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Hits` | `int` | Required | The number of hits to a specific URL handler. |
| `TimingMs` | `int` | Required | The cumulative ms of response time across all hits. |

## Example (as JSON)

```json
{
  "hits": 72,
  "timing_ms": 112
}
```

