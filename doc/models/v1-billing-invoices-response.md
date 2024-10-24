
# V1 Billing Invoices Response

## Structure

`V1BillingInvoicesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<BillingInvoice>`](../../doc/models/billing-invoice.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "651586fca6078e98982dbd90",
      "hub_id": "651586fca6078e98982dbd90",
      "approved": false,
      "charges": 106,
      "due": "01/30/2021 08:30:00",
      "overdue": "01/30/2021 08:30:00",
      "failed_payment_attempts": 152,
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
  ]
}
```

