
# Billing Term

Information about a billing term.

## Structure

`BillingTerm`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Start` | `DateTime` | Required | A timestamp describing the start of a billing term. |
| `End` | `DateTime` | Required | A timestamp describing the end of a billing term. |
| `Renew` | [`RenewEnum?`](../../doc/models/renew-enum.md) | Required | The term renewal period. |

## Example (as JSON)

```json
{
  "start": "01/30/2021 08:30:00",
  "end": "01/30/2021 08:30:00",
  "renew": "yearly"
}
```

