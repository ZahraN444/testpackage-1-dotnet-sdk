
# Stack Meta

A list of meta fields that can be applied to this stack.

## Structure

`StackMeta`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ContainersCount` | [`ResourceCountSummary`](../../doc/models/resource-count-summary.md) | Optional | A summary of resources by state |
| `BuildsCount` | [`ResourceCountSummary`](../../doc/models/resource-count-summary.md) | Optional | A summary of resources by state |

## Example (as JSON)

```json
{
  "containers_count": {
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
  },
  "builds_count": {
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
}
```

