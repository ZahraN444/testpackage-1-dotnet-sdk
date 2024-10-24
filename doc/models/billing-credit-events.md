
# Billing Credit Events

A collection of timestamps for each event in the billing order's lifetime.

## Structure

`BillingCreditEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the billing order was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the billing order was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the billing order was deleted. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00"
}
```

