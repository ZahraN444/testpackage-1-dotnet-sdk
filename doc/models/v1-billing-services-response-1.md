
# V1 Billing Services Response 1

## Structure

`V1BillingServicesResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`BillingService`](../../doc/models/billing-service.md) | Required | Information about billing service. |

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
    "title": "title6",
    "order": {
      "hub_id": "hub_id8",
      "creator": {
        "type": "employee",
        "id": "651586fca6078e98982dbd90"
      },
      "promo_code_id": "promo_code_id4",
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
      "total_price": 92.02,
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
    },
    "item": {
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
    "discount": {
      "id": "651586fca6078e98982dbd90",
      "amount": {
        "mills": 240,
        "term": "yearly"
      },
      "expires": "01/30/2021 08:30:00"
    },
    "price": {
      "mills": 210,
      "term": "monthly"
    },
    "term": {
      "start": "01/30/2021 08:30:00",
      "end": "01/30/2021 08:30:00",
      "renew": "once"
    },
    "events": {
      "created": "01/30/2021 08:30:00",
      "updated": "01/30/2021 08:30:00",
      "deleted": "01/30/2021 08:30:00",
      "last_billed": "01/30/2021 08:30:00"
    },
    "state": {
      "current": "active",
      "changed": "01/30/2021 08:30:00",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    }
  }
}
```

