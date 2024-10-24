
# V1 Billing Methods Request 1

## Structure

`V1BillingMethodsRequest1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | A name for the billing method. |
| `Primary` | `bool?` | Optional | A boolean where true represents a billing method being primary. |
| `Address` | [`BillingMethodAddress`](../../doc/models/billing-method-address.md) | Optional | Address information for a given billing method. |
| `CreditCard` | [`CreditCard`](../../doc/models/credit-card.md) | Optional | Information about a credit card. |

## Example (as JSON)

```json
{
  "name": "name4",
  "primary": false,
  "address": {
    "country": "country0",
    "zip": "zip0"
  },
  "credit_card": {
    "name": "name8",
    "brand": "brand2",
    "expiration": {
      "month": 230,
      "year": 6
    },
    "last_4": "last_40"
  }
}
```

