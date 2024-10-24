
# Restart 1

Configurations for container restart events.

## Structure

`Restart1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Condition` | [`Condition1Enum`](../../doc/models/condition-1-enum.md) | Required | Policy for what should happen in the event of a container dying. |
| `Delay` | `string` | Required | How long the platform will wait before trying to restart the container. |
| `MaxAttempts` | `int` | Required | The amount of times the platform will attempt the restart policies. |

## Example (as JSON)

```json
{
  "condition": "always",
  "delay": "72h45m2s",
  "max_attempts": 58
}
```

