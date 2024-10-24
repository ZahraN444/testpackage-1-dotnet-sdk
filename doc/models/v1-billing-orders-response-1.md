
# V1 Billing Orders Response 1

## Structure

`V1BillingOrdersResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`BillingOrder`](../../doc/models/billing-order.md) | Required | Information about an order. |
| `Includes` | [`BillingOrderIncludes`](../../doc/models/billing-order-includes.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": {
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
    "total_price": 236,
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
  },
  "includes": {
    "promo_codes": {
      "key0": {
        "code": "code0",
        "credit": {
          "key0": {
            "amount": {
              "mills": 240,
              "term": "yearly"
            },
            "expires": "2016-03-13T12:52:32.123Z"
          }
        },
        "state": {
          "current": "live",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        }
      },
      "key1": {
        "code": "code0",
        "credit": {
          "key0": {
            "amount": {
              "mills": 240,
              "term": "yearly"
            },
            "expires": "2016-03-13T12:52:32.123Z"
          }
        },
        "state": {
          "current": "live",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        }
      }
    }
  }
}
```

