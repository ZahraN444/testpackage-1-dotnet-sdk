
# V1 Billing Plans Tiers Response

## Structure

`V1BillingPlansTiersResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<TierPlan>`](../../doc/models/tier-plan.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "id0",
      "name": "name0",
      "code": "code8",
      "generation": 82,
      "usable": false,
      "price": {
        "mills": 210,
        "term": "monthly"
      },
      "servers": {
        "included": 130.2,
        "hard_cap": false,
        "additional": {
          "mills": 68.92,
          "term": "monthly"
        }
      },
      "members": {
        "included": 101.26,
        "hard_cap": false,
        "additional": {
          "mills": 68.92,
          "term": "monthly"
        }
      },
      "max_nodes": 34,
      "max_members": 86,
      "advanced_features": {
        "gpu": false,
        "ial": false,
        "deployments": false,
        "autoscale": false
      },
      "max_daily_api_requests": 136,
      "ram": {
        "included_gb": 142.98,
        "additional_gb": {
          "mills": 25.1,
          "term": "monthly"
        },
        "hard_cap": false
      },
      "image_storage": {
        "included_gb": 228.24,
        "additional_gb": {
          "mills": 25.1,
          "term": "monthly"
        },
        "hard_cap": false
      },
      "builds": {
        "parallel": 112.22,
        "cpu_cores": 221.36,
        "ram_gb": 21.0,
        "max_daily_builds": 78
      },
      "hidden": false,
      "description": "description0"
    }
  ]
}
```

