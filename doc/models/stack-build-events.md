
# Stack Build Events

A collection of timestamps for each event in the stack build's lifetime.

## Structure

`StackBuildEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the stack build was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the stack build was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the stack build was deleted. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00"
}
```

