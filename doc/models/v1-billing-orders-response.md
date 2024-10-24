
# V1 Billing Orders Response

## Structure

`V1BillingOrdersResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Order>`](../../doc/models/order.md) | Required | - |
| `Includes` | [`BillingOrderIncludes`](../../doc/models/billing-order-includes.md) | Optional | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "hub_id": "hub_id2",
      "creator": {
        "type": "employee",
        "id": "651586fca6078e98982dbd90"
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
      "total_price": 219.96,
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
  ],
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

