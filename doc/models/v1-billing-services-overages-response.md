
# V1 Billing Services Overages Response

## Structure

`V1BillingServicesOveragesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<BillingOverage>`](../../doc/models/billing-overage.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "term": {
        "start": "01/30/2021 08:30:00",
        "end": "01/30/2021 08:30:00",
        "renew": "once"
      },
      "ram": {
        "gb_hours": 198,
        "cost": 40
      }
    }
  ]
}
```

