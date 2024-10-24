
# Activity Monitor

Details related to the monitor that raised this activity event.

## Structure

`ActivityMonitor`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Level` | [`LevelEnum`](../../doc/models/level-enum.md) | Required | The severity of the event. |
| `Event` | [`Event1Enum`](../../doc/models/event-1-enum.md) | Required | How the platform has handled this monitor event. |
| `State` | [`State8Enum`](../../doc/models/state-8-enum.md) | Required | The current state of the monitored resource |

## Example (as JSON)

```json
{
  "level": "critical",
  "event": "detection",
  "state": "recovered"
}
```

