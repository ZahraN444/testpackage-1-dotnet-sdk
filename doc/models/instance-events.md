
# Instance Events

A collection of timestamps for each event in the instnaces lifetime.

## Structure

`InstanceEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the instance was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the instance was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the instance was deleted. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00"
}
```

