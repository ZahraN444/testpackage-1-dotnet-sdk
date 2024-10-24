
# Billing Service Events

A collection of timestamps for each event in the billing service's lifetime.

## Structure

`BillingServiceEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the billing service was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the billing service was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the billing service was deleted. |
| `LastBilled` | `DateTime` | Required | The timestamp of when the billing service was last billed. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00",
  "last_billed": "01/30/2021 08:30:00"
}
```

