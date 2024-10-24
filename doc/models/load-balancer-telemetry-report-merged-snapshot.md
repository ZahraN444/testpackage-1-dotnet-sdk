
# Load Balancer Telemetry Report Merged Snapshot

## Structure

`LoadBalancerTelemetryReportMergedSnapshot`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Time` | `DateTime` | Required | - |
| `Controller` | `string` | Required | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `Metrics` | [`LoadBalancerTelemetryControllerMetrics`](../../doc/models/load-balancer-telemetry-controller-metrics.md) | Required | - |

## Example (as JSON)

```json
{
  "time": "01/30/2021 08:30:00",
  "controller": "controller4",
  "metrics": {
    "disconnects": {
      "no_error": 196,
      "request_invalid": 248,
      "timeout_idle": 34,
      "router_none": 30,
      "router_nomatch": 90,
      "destination_unavailable": 48,
      "unknown_error": 218
    },
    "connections": 144,
    "requests": 72,
    "bytes_transmitted": 68,
    "bytes_received": 22
  }
}
```

