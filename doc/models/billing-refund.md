
# Billing Refund

A billing refund.

## Structure

`BillingRefund`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Time` | `DateTime` | Required | A timestamp for the payment. |
| `Description` | `string` | Required | Some information about the payment refund. |
| `Amount` | `int` | Required | 1/10th of a cent. |
| `Gateway` | `string` | Required, Constant | The type of payment gateway used.<br>**Default**: `"stripe"` |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "time": "01/30/2021 08:30:00",
  "description": "description0",
  "amount": 206,
  "gateway": "stripe"
}
```

