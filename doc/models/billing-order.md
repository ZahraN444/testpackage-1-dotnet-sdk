
# Billing Order

Information about an order.

## Structure

`BillingOrder`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `PromoCodeId` | `string` | Required | An ID associated with a promo code used with the order. |
| `Term` | [`BillingTerm`](../../doc/models/billing-term.md) | Required | Information about a billing term. |
| `Approved` | `bool` | Required | A boolean where true represents the order is approved to be paid by the user. |
| `Items` | [`List<ItemPlan>`](../../doc/models/item-plan.md) | Required | - |
| `TotalPrice` | `int` | Required | 1/10th of a cent. |
| `Events` | [`BillingOrderEvents`](../../doc/models/billing-order-events.md) | Required | A collection of timestamps for each event in the billing order's lifetime. |
| `State` | [`State3`](../../doc/models/state-3.md) | Required | - |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "hub_id": "651586fca6078e98982dbd90",
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "promo_code_id": "promo_code_id8",
  "term": {
    "start": "01/30/2021 08:30:00",
    "end": "01/30/2021 08:30:00",
    "renew": "once"
  },
  "approved": false,
  "items": [
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
  ],
  "total_price": 32,
  "events": {
    "created": "01/30/2021 08:30:00",
    "updated": "01/30/2021 08:30:00",
    "deleted": "01/30/2021 08:30:00",
    "expires": "01/30/2021 08:30:00"
  },
  "state": {
    "current": "deleting",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  }
}
```

