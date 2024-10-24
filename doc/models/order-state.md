
# Order State

## Structure

`OrderState`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Current` | [`Current4Enum`](../../doc/models/current-4-enum.md) | Required | The current state of the zone. |
| `Changed` | `DateTime` | Required | - |
| `Error` | [`Error1`](../../doc/models/error-1.md) | Optional | An error, if any, that has occurred for this resource. |

## Example (as JSON)

```json
{
  "current": "new",
  "changed": "01/30/2021 08:30:00",
  "error": {
    "message": "message4",
    "time": "2016-03-13T12:52:32.123Z"
  }
}
```

