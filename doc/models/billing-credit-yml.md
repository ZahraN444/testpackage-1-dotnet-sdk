
# Billing Credit Yml

Information about a billing credit.

## Structure

`BillingCreditYml`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Description` | `string` | Required | Some extra information about the billing credit. |
| `AccountId` | `string` | Required | The account the credit was issued to. |
| `Amount` | `int` | Required | The amount of credit. |
| `AmountRemaining` | `int` | Required | The amount of the credit that remains after being applied to invoices. |
| `Expires` | [`Expires`](../../doc/models/expires.md) | Required | Information on when the billing credit expires. |
| `Events` | [`BillingCreditEvents`](../../doc/models/billing-credit-events.md) | Required | A collection of timestamps for each event in the billing order's lifetime. |
| `State` | [`State5`](../../doc/models/state-5.md) | Required | - |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "hub_id": "651586fca6078e98982dbd90",
  "description": "description2",
  "account_id": "account_id4",
  "amount": 10,
  "amount_remaining": 76,
  "expires": {
    "date": "01/30/2021 08:30:00"
  },
  "events": {
    "created": "01/30/2021 08:30:00",
    "updated": "01/30/2021 08:30:00",
    "deleted": "01/30/2021 08:30:00"
  },
  "state": {
    "current": "expired",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  }
}
```

