
# Order Item

Describes a billing item

## Structure

`OrderItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Service` | [`ItemPlan`](../../doc/models/item-plan.md) | Required | Information for an item's plan. |
| `Description` | `string` | Required | - |
| `Price` | [`BillingAmount`](../../doc/models/billing-amount.md) | Required | An object holding information about term and amount that relates to a specific billing component. |
| `Discount` | [`Discount`](../../doc/models/discount.md) | Optional | - |
| `NetPrice` | `double` | Required | - |

## Example (as JSON)

```json
{
  "id": "id2",
  "service": {
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
  },
  "description": "description8",
  "price": {
    "mills": 210,
    "term": "monthly"
  },
  "discount": {
    "id": "id0",
    "amount": {
      "mills": 240,
      "term": "yearly"
    },
    "expires": "2016-03-13T12:52:32.123Z"
  },
  "net_price": 93.24
}
```

