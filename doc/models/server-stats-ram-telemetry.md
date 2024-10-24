
# Server Stats Ram Telemetry

Statistics about the RAM on a given server.

## Structure

`ServerStatsRamTelemetry`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Available` | `double` | Required | The available RAM on the server. |
| `Free` | `double` | Required | The free RAM on the server. |
| `Total` | `double` | Required | The total RAM on the server. |

## Example (as JSON)

```json
{
  "available": 36.68,
  "free": 33.84,
  "total": 72.06
}
```

