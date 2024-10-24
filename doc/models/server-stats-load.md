
# Server Stats Load

Statistics about the current load on the server.

## Structure

`ServerStatsLoad`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Avg1m` | `double` | Required | The 1 minute load average. |
| `Avg5m` | `double` | Required | The 5 minute load average. |
| `Avg15m` | `double` | Required | the 15 minute load average. |

## Example (as JSON)

```json
{
  "avg1m": 111.88,
  "avg5m": 80.36,
  "avg15m": 44.8
}
```

