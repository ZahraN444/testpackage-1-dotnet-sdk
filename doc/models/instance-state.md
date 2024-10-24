
# Instance State

Information about the state of an instance.

## Structure

`InstanceState`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Current` | [`Current20Enum`](../../doc/models/current-20-enum.md) | Required | The current state of the instance. |
| `Health` | [`Health`](../../doc/models/health.md) | Optional | information about the health of the instance. |
| `Changed` | `DateTime` | Required | - |
| `Error` | [`Error1`](../../doc/models/error-1.md) | Optional | An error, if any, that has occurred for this resource. |

## Example (as JSON)

```json
{
  "current": "stopped",
  "changed": "01/30/2021 08:30:00",
  "health": {
    "healthy": false,
    "updated": "2016-03-13T12:52:32.123Z"
  },
  "error": {
    "message": "message4",
    "time": "2016-03-13T12:52:32.123Z"
  }
}
```

