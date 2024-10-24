
# V1 Infrastructure Servers Telemetry Response

## Structure

`V1InfrastructureServersTelemetryResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<ServerStatsTelemetry>`](../../doc/models/server-stats-telemetry.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
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
  ]
}
```

