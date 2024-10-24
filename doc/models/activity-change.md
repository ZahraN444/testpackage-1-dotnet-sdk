
# Activity Change

An object with information of details for before and after a resource changed.

## Structure

`ActivityChange`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Component` | `string` | Required | A description of the resource that was changed. |
| `Before` | [`ActivityDetail`](../../doc/models/activity-detail.md) | Optional | Details about a given event that is part of an activity. |
| `After` | [`ActivityDetail`](../../doc/models/activity-detail.md) | Optional | Details about a given event that is part of an activity. |

## Example (as JSON)

```json
{
  "component": "component2",
  "before": {
    "id": "id0",
    "number": 192,
    "string": "string4"
  },
  "after": {
    "id": "id2",
    "number": 216,
    "string": "string6"
  }
}
```

