
# Server Stats Telemetry

Statistics about a given servers telemetery data.

## Structure

`ServerStatsTelemetry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Time` | `DateTime` | Required | The timestamp for when the telemetery data was collected. |
| `CpuUsage` | [`ServerStatsCpuUsageTelemetry`](../../doc/models/server-stats-cpu-usage-telemetry.md) | Optional | - |
| `Load` | [`ServerStatsLoad`](../../doc/models/server-stats-load.md) | Required | Statistics about the current load on the server. |
| `Ram` | [`ServerStatsRamTelemetry`](../../doc/models/server-stats-ram-telemetry.md) | Required | Statistics about the RAM on a given server. |
| `StorageBase` | [`StorageBase`](../../doc/models/storage-base.md) | Required | Telemetry data for the base volume of a given server. |
| `StoragePool` | [`StoragePool`](../../doc/models/storage-pool.md) | Required | User data storage across all devices. |

## Example (as JSON)

```json
{
  "time": "01/30/2021 08:30:00",
  "load": {
    "avg1m": 164.12,
    "avg5m": 123.4,
    "avg15m": 158.96
  },
  "ram": {
    "available": 14.52,
    "free": 56.0,
    "total": 49.9
  },
  "storage_base": {
    "used": 22,
    "free": 54,
    "total": 40
  },
  "storage_pool": {
    "data_percent": 37.5,
    "meta_percent": 41.52,
    "total": 114.56
  },
  "cpu_usage": {
    "user": 207.9,
    "nice": 118.58,
    "system": 245.78,
    "idle": 105.46,
    "iowait": 227.6
  }
}
```

