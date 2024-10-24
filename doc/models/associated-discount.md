
# Associated Discount

Information about a billing discount.

## Structure

`AssociatedDiscount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Amount` | [`BillingAmount`](../../doc/models/billing-amount.md) | Required | An object holding information about term and amount that relates to a specific billing component. |
| `Expires` | `DateTime` | Required | A timestamp of when the discount expires. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "amount": {
    "mills": 240,
    "term": "yearly"
  },
  "expires": "01/30/2021 08:30:00"
}
```

