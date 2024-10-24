
# Data 3

Contains useful and relevant data/statistics for a container that would otherwise be several separate API calls.

## Structure

`Data3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `State` | [`ContainerState`](../../doc/models/container-state.md) | Required | - |
| `Stats` | [`Data3Stats`](../../doc/models/containers/data-3-stats.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "state": {
    "current": "deleting",
    "changed": "01/30/2021 08:30:00",
    "desired": "stopping",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "stats": {
    "state": {
      "key0": 140
    },
    "total": 28,
    "available": 74
  }
}
```

