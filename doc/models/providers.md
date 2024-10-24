
# Providers

## Structure

`Providers`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Count` | `double` | Required | - |
| `Locations` | `Dictionary<string, int>` | Optional | - |
| `Models` | `Dictionary<string, int>` | Optional | - |
| `Resources` | [`InfrastructureResourceSummary`](../../doc/models/infrastructure-resource-summary.md) | Optional | A summary of resource utilization/availability. |

## Example (as JSON)

```json
{
  "count": 164.02,
  "locations": {
    "key0": 186,
    "key1": 185
  },
  "models": {
    "key0": 46,
    "key1": 47
  },
  "resources": {
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
}
```

