
# Server Stats Ram

Statistics about the RAM on a given server.

## Structure

`ServerStatsRam`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Available` | `int` | Required | The available RAM on the server. |
| `Free` | `int` | Required | The free RAM on the server. |
| `Total` | `int` | Required | The total RAM on the server. |

## Example (as JSON)

```json
{
  "available": 150,
  "free": 246,
  "total": 104
}
```

