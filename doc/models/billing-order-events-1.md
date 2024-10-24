
# Billing Order Events 1

A collection of timestamps for each event in the billing order's lifetime.

## Structure

`BillingOrderEvents1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the billing order was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the billing order was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the billing order was deleted. |
| `Billed` | `DateTime` | Required | The timestamp of when the billing order billed. |
| `Paid` | `DateTime` | Required | The timestamp of when the billing order paid. |
| `PaymentAttempt` | `DateTime?` | Optional | The timestamp of when the billing order payment was attempted. |
| `Credited` | `DateTime` | Required | The timestamp of when the billing order credited. |
| `Voided` | `DateTime` | Required | The timestamp of when the billing order voided. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00",
  "billed": "01/30/2021 08:30:00",
  "paid": "01/30/2021 08:30:00",
  "payment_attempt": "01/30/2021 08:30:00",
  "credited": "01/30/2021 08:30:00",
  "voided": "01/30/2021 08:30:00"
}
```

