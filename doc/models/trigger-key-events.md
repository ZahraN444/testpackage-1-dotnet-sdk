
# Trigger Key Events

A collection of timestamps for each event in the trigger key's lifetime.

## Structure

`TriggerKeyEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the trigger key was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the trigger key was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the trigger key was deleted. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00"
}
```

