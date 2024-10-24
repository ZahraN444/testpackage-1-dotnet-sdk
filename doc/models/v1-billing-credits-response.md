
# V1 Billing Credits Response

## Structure

`V1BillingCreditsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<BillingCreditYml>`](../../doc/models/billing-credit-yml.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "651586fca6078e98982dbd90",
      "hub_id": "651586fca6078e98982dbd90",
      "description": "description0",
      "account_id": "account_id2",
      "amount": 236,
      "amount_remaining": 46,
      "expires": {
        "date": "01/30/2021 08:30:00"
      },
      "events": {
        "created": "01/30/2021 08:30:00",
        "updated": "01/30/2021 08:30:00",
        "deleted": "01/30/2021 08:30:00"
      },
      "state": {
        "current": "expired",
        "changed": "01/30/2021 08:30:00",
        "error": {
          "message": "message4",
          "time": "2016-03-13T12:52:32.123Z"
        }
      }
    }
  ]
}
```

