
# Load Balancer Telemetry Controller Metrics

## Structure

`LoadBalancerTelemetryControllerMetrics`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Disconnects` | [`LoadBalancerTelemetryControllerDisconnectsMetrics`](../../doc/models/load-balancer-telemetry-controller-disconnects-metrics.md) | Required | - |
| `Connections` | `int` | Required | - |
| `Requests` | `int` | Required | - |
| `BytesTransmitted` | `int` | Required | - |
| `BytesReceived` | `int` | Required | - |

## Example (as JSON)

```json
{
  "disconnects": {
    "no_error": 196,
    "request_invalid": 248,
    "timeout_idle": 34,
    "router_none": 30,
    "router_nomatch": 90,
    "destination_unavailable": 48,
    "unknown_error": 218
  },
  "connections": 254,
  "requests": 218,
  "bytes_transmitted": 178,
  "bytes_received": 132
}
```

