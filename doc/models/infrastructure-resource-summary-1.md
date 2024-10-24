
# Infrastructure Resource Summary 1

Information about the aggregate resources of the cluster.

## Structure

`InfrastructureResourceSummary1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Ram` | [`Ram3`](../../doc/models/ram-3.md) | Required | Information about RAM Resources. |
| `Cpu` | [`Cpu2`](../../doc/models/cpu-2.md) | Required | Information about CPU resources. |

## Example (as JSON)

```json
{
  "ram": {
    "total_mb": 88,
    "allocated_mb": 176,
    "used_mb": 246,
    "provisioned_mb": 52
  },
  "cpu": {
    "cores": 8,
    "shares": {
      "allocated": 40,
      "total": 52
    },
    "share_ratio": 82
  }
}
```

