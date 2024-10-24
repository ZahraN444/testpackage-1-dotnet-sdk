
# Credit

## Structure

`Credit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Amount` | [`BillingAmount`](../../doc/models/billing-amount.md) | Optional | An object holding information about term and amount that relates to a specific billing component. |
| `Expires` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "expires": "01/30/2021 08:30:00",
  "amount": {
    "mills": 240,
    "term": "yearly"
  }
}
```

