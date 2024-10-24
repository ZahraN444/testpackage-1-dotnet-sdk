
# Load Balancer Telemetry Controller Disconnects Metrics

## Structure

`LoadBalancerTelemetryControllerDisconnectsMetrics`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `NoError` | `int` | Required | - |
| `RequestInvalid` | `int` | Required | - |
| `TimeoutIdle` | `int` | Required | - |
| `RouterNone` | `int` | Required | - |
| `RouterNomatch` | `int` | Required | - |
| `DestinationUnavailable` | `int` | Required | - |
| `UnknownError` | `int` | Required | - |

## Example (as JSON)

```json
{
  "no_error": 164,
  "request_invalid": 112,
  "timeout_idle": 138,
  "router_none": 134,
  "router_nomatch": 194,
  "destination_unavailable": 56,
  "unknown_error": 66
}
```

