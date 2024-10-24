
# Auto Scale Group Events

A collection of timestamps for each event in the auto-scale group's lifetime.

## Structure

`AutoScaleGroupEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the auto-scale group was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the auto-scale group was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the auto-scale group was deleted. |
| `LastSync` | `DateTime` | Required | The timestamp of when the auto-scale group was last synced. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00",
  "last_sync": "01/30/2021 08:30:00"
}
```

