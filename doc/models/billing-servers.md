
# Billing Servers

An object holding information about servers included in Billing tier

## Structure

`BillingServers`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Included` | `double` | Required | The number of servers included in the tier price |
| `HardCap` | `bool` | Required | A boolean indicating if there is a hard server limit on the tier |
| `Additional` | [`Additional`](../../doc/models/additional.md) | Required | An object describing the additonal cost of servers exceeding the included server count |

## Example (as JSON)

```json
{
  "included": 154.88,
  "hard_cap": false,
  "additional": {
    "mills": 68.92,
    "term": "monthly"
  }
}
```

