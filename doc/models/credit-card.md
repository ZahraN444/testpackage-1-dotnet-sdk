
# Credit Card

Information about a credit card.

## Structure

`CreditCard`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | A name associated with the credit cards usage. |
| `Brand` | `string` | Required | The brand of card - ex VISA. |
| `Expiration` | [`BillingMethodExpiration`](../../doc/models/billing-method-expiration.md) | Required | Expiration information for a billing method |
| `Last4` | `string` | Required | The last 4 digits of the card. |

## Example (as JSON)

```json
{
  "name": "name0",
  "brand": "brand4",
  "expiration": {
    "month": 230,
    "year": 6
  },
  "last_4": "last_42"
}
```

