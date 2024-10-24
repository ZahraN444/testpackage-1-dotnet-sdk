
# Billing Service State

## Structure

`BillingServiceState`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Current` | `string` | Required, Constant | The current state of the billing service.<br>**Default**: `"active"` |
| `Changed` | `DateTime` | Required | - |
| `Error` | [`Error1`](../../doc/models/error-1.md) | Optional | An error, if any, that has occurred for this resource. |

## Example (as JSON)

```json
{
  "current": "active",
  "changed": "01/30/2021 08:30:00",
  "error": {
    "message": "message4",
    "time": "2016-03-13T12:52:32.123Z"
  }
}
```

