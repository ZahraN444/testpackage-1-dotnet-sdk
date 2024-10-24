
# Load Balancer Telemetry Report

Aggregated load balancer telemetry across all instances for a given range.

## Structure

`LoadBalancerTelemetryReport`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | - |
| `Range` | [`Range`](../../doc/models/range.md) | Required | A start and end date-time pair indicating a range of time |
| `Snapshots` | [`List<LoadBalancerTelemetryReportMergedSnapshot>`](../../doc/models/load-balancer-telemetry-report-merged-snapshot.md) | Required | - |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "range": {
    "start": "01/30/2021 08:30:00",
    "end": "01/30/2021 08:30:00"
  },
  "snapshots": [
    {
      "time": "01/30/2021 08:30:00",
      "controller": "controller2",
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
  ]
}
```

