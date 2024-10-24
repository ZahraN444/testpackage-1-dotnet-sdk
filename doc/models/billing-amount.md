
# Billing Amount

An object holding information about term and amount that relates to a specific billing component.

## Structure

`BillingAmount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Mills` | `int` | Required | 1/10th of a cent. |
| `Term` | [`TermEnum`](../../doc/models/term-enum.md) | Required | The length of the term. |

## Example (as JSON)

```json
{
  "mills": 80,
  "term": "monthly"
}
```

