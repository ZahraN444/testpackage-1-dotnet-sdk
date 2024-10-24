
# DNS Record State

## Structure

`DNSRecordState`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Current` | [`Current17Enum`](../../doc/models/current-17-enum.md) | Required | The current state of the record. |
| `Changed` | `DateTime` | Required | - |
| `Error` | [`Error1`](../../doc/models/error-1.md) | Optional | An error, if any, that has occurred for this resource. |

## Example (as JSON)

```json
{
  "current": "pending",
  "changed": "01/30/2021 08:30:00",
  "error": {
    "message": "message4",
    "time": "2016-03-13T12:52:32.123Z"
  }
}
```
