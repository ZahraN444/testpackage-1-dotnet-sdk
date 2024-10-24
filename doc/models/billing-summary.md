
# Billing Summary

A billing summary.

## Structure

`BillingSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServiceId` | `string` | Required | The ID of the billing service, the summary pertains to. |
| `Title` | `string` | Required | The billing summary title. |
| `Type` | [`Type5Enum`](../../doc/models/type-5-enum.md) | Required | The plan type. |
| `Term` | [`BillingTerm`](../../doc/models/billing-term.md) | Required | Information about a billing term. |
| `Price` | `string` | Required | 1/10th of a cent. |
| `Discount` | `string` | Required | - |

## Example (as JSON)

```json
{
  "service_id": "service_id0",
  "title": "title4",
  "type": "tier",
  "term": {
    "start": "01/30/2021 08:30:00",
    "end": "01/30/2021 08:30:00",
    "renew": "once"
  },
  "price": "price2",
  "discount": "discount0"
}
```

