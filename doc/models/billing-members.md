
# Billing Members

An object holding information about members included in Billing tier

## Structure

`BillingMembers`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Included` | `double` | Required | The number of members included in the tier price |
| `HardCap` | `bool` | Required | A boolean indicating if there is a hard member limit on the tier |
| `Additional` | [`Additional1`](../../doc/models/additional-1.md) | Required | An object describing the additonal cost of members exceeding the included member count |

## Example (as JSON)

```json
{
  "included": 195.18,
  "hard_cap": false,
  "additional": {
    "mills": 68.92,
    "term": "monthly"
  }
}
```

