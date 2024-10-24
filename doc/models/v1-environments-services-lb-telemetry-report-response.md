
# V1 Environments Services Lb Telemetry Report Response

## Structure

`V1EnvironmentsServicesLbTelemetryReportResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`LoadBalancerTelemetryReport`](../../doc/models/load-balancer-telemetry-report.md) | Required | Aggregated load balancer telemetry across all instances for a given range. |

## Example (as JSON)

```json
{
  "data": {
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
}
```

