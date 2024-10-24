
# Environment Summary Stats

Statistics about the containers and instances associated with this environment.

## Structure

`EnvironmentSummaryStats`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Containers` | [`ResourceCountSummary`](../../doc/models/resource-count-summary.md) | Required | A summary of resources by state |
| `Instances` | [`ResourceCountSummary`](../../doc/models/resource-count-summary.md) | Required | A summary of resources by state |

## Example (as JSON)

```json
{
  "containers": {
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
  "instances": {
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

