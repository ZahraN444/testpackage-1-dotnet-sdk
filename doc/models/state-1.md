
# State 1

## Structure

`State1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Current` | `string` | Required, Constant | The current state of the Role.<br>**Default**: `"live"` |
| `Changed` | `DateTime` | Required | - |
| `Error` | [`Error1`](../../doc/models/error-1.md) | Optional | An error, if any, that has occurred for this resource. |

## Example (as JSON)

```json
{
  "current": "live",
  "changed": "01/30/2021 08:30:00",
  "error": {
    "message": "message4",
    "time": "2016-03-13T12:52:32.123Z"
  }
}
```

