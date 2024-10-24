
# Server Stats Cpu Usage Telemetry

## Structure

`ServerStatsCpuUsageTelemetry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `User` | `double?` | Optional | - |
| `Nice` | `double?` | Optional | - |
| `MSystem` | `double?` | Optional | - |
| `Idle` | `double?` | Optional | - |
| `Iowait` | `double?` | Optional | - |
| `Irq` | `double?` | Optional | - |
| `SoftIrq` | `double?` | Optional | - |
| `Steal` | `double?` | Optional | - |
| `Guest` | `double?` | Optional | - |
| `GuestNice` | `double?` | Optional | - |

## Example (as JSON)

```json
{
  "user": 205.62,
  "nice": 116.3,
  "system": 243.5,
  "idle": 103.18,
  "iowait": 225.32
}
```

