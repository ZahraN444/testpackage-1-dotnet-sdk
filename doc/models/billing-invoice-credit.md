
# Billing Invoice Credit

A billing credit for a specific invoice.

## Structure

`BillingInvoiceCredit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `AssociatedCredit` | [`AssociatedCredit`](../../doc/models/associated-credit.md) | Required | Credit associated with an invoice. |
| `Time` | `DateTime` | Required | A timestamp for when the invoice credit was created. |
| `Description` | `string` | Required | A description of the invoice credit. |
| `Amount` | `int` | Required | The amount of credit for the invoice. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "associated_credit": {
    "id": "651586fca6078e98982dbd90",
    "amount": 112
  },
  "time": "01/30/2021 08:30:00",
  "description": "description4",
  "amount": 60
}
```

