
# Billing Payment

A billing payment.

## Structure

`BillingPayment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Time` | `DateTime` | Required | A timestamp for the payment. |
| `Description` | `string` | Required | Some information about the payment. |
| `Amount` | `int` | Required | 1/10th of a cent. |
| `AmountRefunded` | `int` | Required | 1/10th of a cent. |
| `Refunds` | [`List<BillingRefund>`](../../doc/models/billing-refund.md) | Required | - |
| `MethodId` | `string` | Required | The ID associated with the billing method used. |
| `Result` | [`PaymentResult`](../../doc/models/payment-result.md) | Required | A billing payment result. |
| `Gateway` | `string` | Required, Constant | The type of payment gateway used.<br>**Default**: `"stripe"` |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "time": "01/30/2021 08:30:00",
  "description": "description0",
  "amount": 92,
  "amount_refunded": 90,
  "refunds": [
    {
      "id": "651586fca6078e98982dbd90",
      "time": "01/30/2021 08:30:00",
      "description": "description8",
      "amount": 210,
      "gateway": "stripe"
    }
  ],
  "method_id": "method_id4",
  "result": {
    "success": false,
    "error": "error0"
  },
  "gateway": "stripe"
}
```

