
# Instance Telemetry CPU Snapshot

A telemetry snapshot pertaining to CPU usage.

## Structure

`InstanceTelemetryCPUSnapshot`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Usage` | [`Usage`](../../doc/models/usage.md) | Required | Usage statistics. |
| `Throttling` | [`Throttling`](../../doc/models/throttling.md) | Required | Throttling statistics. |

## Example (as JSON)

```json
{
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
}
```

