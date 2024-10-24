
# Stack Events

A collection of timestamps for each event in the Stacks lifetime.

## Structure

`StackEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the stack was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the stack was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the stack was deleted. |
| `LastBuild` | `DateTime` | Required | The timestamp for the last build of the stack. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00",
  "last_build": "01/30/2021 08:30:00"
}
```

