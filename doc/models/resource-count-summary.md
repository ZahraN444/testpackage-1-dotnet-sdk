
# Resource Count Summary

A summary of resources by state

## Structure

`ResourceCountSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `State` | `Dictionary<string, int>` | Required | A count of this resource, grouped by state. |
| `Total` | `int` | Required | The total number of this resource |
| `Available` | `int` | Required | The total number of this resource available, less any deleted ones. |

## Example (as JSON)

```json
{
  "state": {
    "new": 0,
    "starting": 0,
    "running": 5,
    "stopping": 0,
    "deleting": 0,
    "deleted": 0
  },
  "total": 5,
  "available": 5
}
```

