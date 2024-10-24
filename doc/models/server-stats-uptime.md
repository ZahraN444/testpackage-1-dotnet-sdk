
# Server Stats Uptime

Statistics describing the uptime of a given server.

## Structure

`ServerStatsUptime`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Seconds` | `double?` | Optional | The amount in seconds the server has been up (resets on restart). |
| `CpuIdle` | `double?` | Optional | CPU idle time. |

## Example (as JSON)

```json
{
  "seconds": 118.24,
  "cpu_idle": 48.1
}
```

