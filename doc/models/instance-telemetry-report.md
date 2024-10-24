
# Instance Telemetry Report

An Instance telemetry report.

## Structure

`InstanceTelemetryReport`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Request` | [`InstanceTelemetryReportRequest`](../../doc/models/instance-telemetry-report-request.md) | Required | A summary of report requests and when they occured. |
| `Snapshots` | [`List<InstanceTelemetryResourceSnapshot>`](../../doc/models/instance-telemetry-resource-snapshot.md) | Required | An array of telemetry snapshots. |

## Example (as JSON)

```json
{
  "request": {
    "instance_id": "instance_id6",
    "start": "01/30/2021 08:30:00",
    "end": "01/30/2021 08:30:00"
  },
  "snapshots": [
    {
      "time": "01/30/2021 08:30:00",
      "cpu": {
        "usage": {
          "total": 28,
          "per_core": [
            149
          ],
          "kernel": 198,
          "user": 104.98
        },
        "throttling": {
          "periods": 16,
          "throttled_periods": 178,
          "throttled_time": 246
        }
      },
      "memory": {
        "cache": 173.36,
        "usage": {
          "usage": 26.36,
          "max_usage": 92.64,
          "fail_count": 29.74,
          "limit": 31.94
        },
        "swap_usage": {
          "usage": 13.36,
          "max_usage": 79.64,
          "fail_count": 42.74,
          "limit": 237.06
        },
        "kernel_usage": {
          "usage": 162.76,
          "max_usage": 229.04,
          "fail_count": 149.34,
          "limit": 87.66
        },
        "kernel_tcp_usage": {
          "usage": 101.16,
          "max_usage": 167.44,
          "fail_count": 210.94,
          "limit": 149.26
        }
      },
      "processes": {
        "current": 78.92,
        "limit": 189.5
      },
      "network": {
        "interfaces": [
          {
            "name": "name4",
            "rx_bytes": 48,
            "tx_bytes": 186
          }
        ]
      },
      "hub_id": "String5",
      "container_id": "String9",
      "instance_id": "String3",
      "environment_id": "String1",
      "server_id": "String3"
    }
  ]
}
```

