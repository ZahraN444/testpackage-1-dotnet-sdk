
# Announcement Events

A collection of timestamps for each event in the announcement's lifetime.

## Structure

`AnnouncementEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the announcement was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the announcement was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the announcement was deleted. |
| `Resolved` | `DateTime` | Required | The timestamp of when the announcement was resolved. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00",
  "resolved": "01/30/2021 08:30:00"
}
```

