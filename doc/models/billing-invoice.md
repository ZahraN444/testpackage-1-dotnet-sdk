
# Billing Invoice

Information about a billing invoice.

## Structure

`BillingInvoice`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Approved` | `bool` | Required | A boolean where true represents the invoice is approved for collection. |
| `Services` | [`List<BillingSummary>`](../../doc/models/billing-summary.md) | Optional | - |
| `Payments` | [`List<BillingPayment>`](../../doc/models/billing-payment.md) | Optional | - |
| `Credits` | [`List<BillingInvoiceCredit>`](../../doc/models/billing-invoice-credit.md) | Optional | - |
| `LateFees` | [`List<LateFee>`](../../doc/models/late-fee.md) | Optional | - |
| `Charges` | `int` | Required | The amount in charges generated through the licesnse agreement + overages for the billing period covered by the invoice. |
| `Due` | `DateTime?` | Optional | A timestamp of when the invoice is due to be paid. |
| `Overdue` | `DateTime?` | Optional | A timestamp of when the invoice is overdue. |
| `FailedPaymentAttempts` | `int` | Required | The number of failed payment attempts for the invoice. |
| `Events` | [`BillingOrderEvents1`](../../doc/models/billing-order-events-1.md) | Required | A collection of timestamps for each event in the billing order's lifetime. |
| `State` | [`InvoiceState`](../../doc/models/invoice-state.md) | Required | - |
| `Meta` | [`InvoiceMeta`](../../doc/models/invoice-meta.md) | Optional | A list of meta fields that can be applied to a invoice. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "hub_id": "651586fca6078e98982dbd90",
  "approved": false,
  "charges": 168,
  "due": "01/30/2021 08:30:00",
  "overdue": "01/30/2021 08:30:00",
  "failed_payment_attempts": 214,
  "events": {
    "created": "01/30/2021 08:30:00",
    "updated": "01/30/2021 08:30:00",
    "deleted": "01/30/2021 08:30:00",
    "billed": "01/30/2021 08:30:00",
    "paid": "01/30/2021 08:30:00",
    "payment_attempt": "01/30/2021 08:30:00",
    "credited": "01/30/2021 08:30:00",
    "voided": "01/30/2021 08:30:00"
  },
  "state": {
    "current": "refunded",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "services": [
    {
      "service_id": "service_id0",
      "title": "title6",
      "type": "tier",
      "term": {
        "start": "2016-03-13T12:52:32.123Z",
        "end": "2016-03-13T12:52:32.123Z",
        "renew": "once"
      },
      "price": "price2",
      "discount": "discount0"
    }
  ],
  "payments": [
    {
      "id": "id2",
      "time": "2016-03-13T12:52:32.123Z",
      "description": "description2",
      "amount": 202,
      "amount_refunded": 200,
      "refunds": [
        {
          "id": "id8",
          "time": "2016-03-13T12:52:32.123Z",
          "description": "description8",
          "amount": 210,
          "gateway": "gateway8"
        }
      ],
      "method_id": "method_id6",
      "result": {
        "success": false,
        "error": "error0"
      },
      "gateway": "gateway2"
    },
    {
      "id": "id2",
      "time": "2016-03-13T12:52:32.123Z",
      "description": "description2",
      "amount": 202,
      "amount_refunded": 200,
      "refunds": [
        {
          "id": "id8",
          "time": "2016-03-13T12:52:32.123Z",
          "description": "description8",
          "amount": 210,
          "gateway": "gateway8"
        }
      ],
      "method_id": "method_id6",
      "result": {
        "success": false,
        "error": "error0"
      },
      "gateway": "gateway2"
    },
    {
      "id": "id2",
      "time": "2016-03-13T12:52:32.123Z",
      "description": "description2",
      "amount": 202,
      "amount_refunded": 200,
      "refunds": [
        {
          "id": "id8",
          "time": "2016-03-13T12:52:32.123Z",
          "description": "description8",
          "amount": 210,
          "gateway": "gateway8"
        }
      ],
      "method_id": "method_id6",
      "result": {
        "success": false,
        "error": "error0"
      },
      "gateway": "gateway2"
    }
  ],
  "credits": [
    {
      "id": "id0",
      "associated_credit": {
        "id": "id4",
        "amount": 112
      },
      "time": "2016-03-13T12:52:32.123Z",
      "description": "description0",
      "amount": 174
    }
  ],
  "late_fees": [
    {
      "id": "id4",
      "time": "2016-03-13T12:52:32.123Z",
      "description": "description4",
      "amount": 178
    }
  ]
}
```

