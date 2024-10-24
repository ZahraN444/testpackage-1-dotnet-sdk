
# Discount

## Structure

`Discount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Amount` | [`BillingAmount`](../../doc/models/billing-amount.md) | Required | An object holding information about term and amount that relates to a specific billing component. |
| `Expires` | `DateTime` | Required | - |

## Example (as JSON)

```json
{
  "id": "id6",
  "amount": {
    "mills": 240,
    "term": "yearly"
  },
  "expires": "01/30/2021 08:30:00"
}
```

