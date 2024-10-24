
# Tier

Information about the tier component of the billing item.

## Structure

`Tier`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Name` | `string` | Required | The support contract name. |
| `Price` | [`BillingAmount`](../../doc/models/billing-amount.md) | Required | An object holding information about term and amount that relates to a specific billing component. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "name": "name4",
  "price": {
    "mills": 210,
    "term": "monthly"
  }
}
```

