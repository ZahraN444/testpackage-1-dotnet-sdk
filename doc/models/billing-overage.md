
# Billing Overage

Information about billing overage.

## Structure

`BillingOverage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Term` | [`BillingTerm`](../../doc/models/billing-term.md) | Required | Information about a billing term. |
| `Ram` | [`Ram`](../../doc/models/ram.md) | Required | Used for gen 1 pricing. |

## Example (as JSON)

```json
{
  "term": {
    "start": "01/30/2021 08:30:00",
    "end": "01/30/2021 08:30:00",
    "renew": "once"
  },
  "ram": {
    "gb_hours": 198,
    "cost": 40
  }
}
```

