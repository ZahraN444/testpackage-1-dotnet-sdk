
# Zone Events

A collection of timestamps for each event in the DNS zone's lifetime.

## Structure

`ZoneEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the DNS zone was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the DNS zone was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the DNS zone was deleted. |
| `LastVerification` | `DateTime` | Required | The timestamp of when the DNS zone was last_verification. |
| `Verified` | `DateTime` | Required | The timestamp of when the DNS zone was verified. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00",
  "last_verification": "01/30/2021 08:30:00",
  "verified": "01/30/2021 08:30:00"
}
```

