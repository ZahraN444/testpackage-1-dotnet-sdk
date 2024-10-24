
# Item Plan

Information for an item's plan.

## Structure

`ItemPlan`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Support` | [`Support`](../../doc/models/support.md) | Optional | Information about the support component of the billing item. |
| `Tier` | [`Tier`](../../doc/models/tier.md) | Optional | Information about the tier component of the billing item. |

## Example (as JSON)

```json
{
  "support": {
    "id": "id0",
    "name": "name0",
    "price": 138
  },
  "tier": {
    "id": "id2",
    "name": "name2",
    "price": {
      "mills": 210,
      "term": "monthly"
    }
  }
}
```

