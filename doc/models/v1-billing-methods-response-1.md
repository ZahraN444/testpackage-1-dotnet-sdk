
# V1 Billing Methods Response 1

## Structure

`V1BillingMethodsResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`BillingMethod`](../../doc/models/billing-method.md) | Required | Information about a billing method, usable to pay invoices. |

## Example (as JSON)

```json
{
  "data": {
    "id": "651586fca6078e98982dbd90",
    "name": "name0",
    "primary": false,
    "address": {
      "country": "country0",
      "zip": "zip0"
    },
    "creator": {
      "id": "651586fca6078e98982dbd90",
      "type": "employee"
    },
    "credit_card": {
      "name": "name8",
      "brand": "brand2",
      "expiration": {
        "month": 230,
        "year": 6
      },
      "last_4": "last_40"
    },
    "state": {
      "current": "deleted",
      "changed": "01/30/2021 08:30:00",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "events": {
      "created": "01/30/2021 08:30:00",
      "updated": "01/30/2021 08:30:00",
      "deleted": "01/30/2021 08:30:00"
    }
  }
}
```

