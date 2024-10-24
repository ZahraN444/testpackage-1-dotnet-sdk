
# Hub Billing Profile

A billing profile for a given hub.

## Structure

`HubBillingProfile`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Term` | [`BillingTerm`](../../doc/models/billing-term.md) | Required | Information about a billing term. |
| `AllowPrepaid` | `bool?` | Optional | A boolean where true represents this account being approved to use a prepaid card for billing transactions. |
| `PauseInvoices` | `bool` | Required | A boolean where true represents invoices have been paused on this hub for one reason or another. |
| `Disable` | `bool?` | Optional | A boolean where true means this billing is disabled on this hub. |
| `Plans` | [`Plans`](../../doc/models/plans.md) | Required | Information about the plan associated with this hub. |
| `Emails` | `List<string>` | Required | An array of email addresses to whom the billing invoices will be sent to. If left empty, they will be sent to the owner of this hub. |

## Example (as JSON)

```json
{
  "term": {
    "start": "01/30/2021 08:30:00",
    "end": "01/30/2021 08:30:00",
    "renew": "once"
  },
  "pause_invoices": false,
  "plans": {
    "tier_id": "tier_id2",
    "support_id": "support_id6"
  },
  "emails": [
    "emails7"
  ],
  "allow_prepaid": false,
  "disable": false
}
```

