
# Billing Method

Information about a billing method, usable to pay invoices.

## Structure

`BillingMethod`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Name` | `string` | Required | A name for the billing method. |
| `Primary` | `bool` | Required | A boolean where true represents this billing method is set to primary for a given hub. |
| `Address` | [`BillingMethodAddress`](../../doc/models/billing-method-address.md) | Required | Address information for a given billing method. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `CreditCard` | [`CreditCard`](../../doc/models/credit-card.md) | Required | Information about a credit card. |
| `State` | [`State2`](../../doc/models/state-2.md) | Required | - |
| `Events` | [`CreditCardEvents`](../../doc/models/credit-card-events.md) | Required | A collection of timestamps for each event in the credit card's lifetime. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "name": "name0",
  "primary": false,
  "address": {
    "country": "country0",
    "zip": "zip0"
  },
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "credit_card": {
    "name": "name8",
    "brand": "brand2",
    "expiration": {
      "month": 230,
      "year": 6
    },
    "last_4": "last_40"
  },
  "state": {
    "current": "deleted",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "events": {
    "created": "01/30/2021 08:30:00",
    "updated": "01/30/2021 08:30:00",
    "deleted": "01/30/2021 08:30:00"
  }
}
```

