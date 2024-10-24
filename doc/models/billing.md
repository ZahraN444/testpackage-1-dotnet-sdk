
# Billing

## Structure

`Billing`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Term` | [`BillingTerm`](../../doc/models/billing-term.md) | Optional | Information about a billing term. |
| `AllowPrepaid` | `bool?` | Optional | A boolean where true represents this account being approved to use a prepaid card for billing transactions. |
| `PauseInvoices` | `bool?` | Optional | A boolean where true represents invoices have been paused on this hub for one reason or another. |
| `Disable` | `bool?` | Optional | A boolean where true means this billing is disabled on this hub. |
| `Plans` | [`Plans`](../../doc/models/plans.md) | Optional | Information about the plan associated with this hub. |
| `Emails` | `List<string>` | Optional | An array of email addresses to whom the billing invoices will be sent to. If left empty, they will be sent to the owner of this hub. |

## Example (as JSON)

```json
{
  "term": {
    "start": "2016-03-13T12:52:32.123Z",
    "end": "2016-03-13T12:52:32.123Z",
    "renew": "once"
  },
  "allow_prepaid": false,
  "pause_invoices": false,
  "disable": false,
  "plans": {
    "tier_id": "tier_id2",
    "support_id": "support_id6"
  }
}
```

