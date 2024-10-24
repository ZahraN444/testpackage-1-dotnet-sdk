
# V1 Billing Methods Request

## Structure

`V1BillingMethodsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | A name for the billing method. |
| `Primary` | `bool` | Required | A boolean where true represents a billing method being primary. |
| `Address` | [`BillingMethodAddress`](../../doc/models/billing-method-address.md) | Required | Address information for a given billing method. |
| `CreditCard` | [`CreditCard1`](../../doc/models/credit-card-1.md) | Required | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "primary": false,
  "address": {
    "country": "country0",
    "zip": "zip0"
  },
  "credit_card": {
    "name": "name8",
    "number": "number6",
    "cvv": "cvv6",
    "expiration": {
      "month": 94.46,
      "year": 69.18
    }
  }
}
```

