
# Order

An order is a resource that describes a billing order

## Structure

`Order`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HubId` | `string` | Required | - |
| `Creator` | [`UserScope`](../../doc/models/user-scope.md) | Required | A type of creator and a matching identifier. |
| `PromoCodeId` | `string` | Required | - |
| `Term` | [`BillingTerm`](../../doc/models/billing-term.md) | Required | Information about a billing term. |
| `Approved` | `bool` | Required | - |
| `Items` | [`List<OrderItem>`](../../doc/models/order-item.md) | Required | - |
| `TotalPrice` | `double` | Required | - |
| `Events` | [`OrderEvents`](../../doc/models/order-events.md) | Required | A collection of timestamps for each event in the orders lifetime. |
| `State` | [`OrderState`](../../doc/models/order-state.md) | Required | - |

## Example (as JSON)

```json
{
  "hub_id": "hub_id4",
  "creator": {
    "type": "employee",
    "id": "651586fca6078e98982dbd90"
  },
  "promo_code_id": "promo_code_id0",
  "term": {
    "start": "01/30/2021 08:30:00",
    "end": "01/30/2021 08:30:00",
    "renew": "once"
  },
  "approved": false,
  "items": [
    {
      "id": "id8",
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
      "description": "description2",
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
      "net_price": 57.3
    }
  ],
  "total_price": 194.78,
  "events": {
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

