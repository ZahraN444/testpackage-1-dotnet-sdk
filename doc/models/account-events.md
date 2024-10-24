
# Account Events

A collection of timestamps for each event in the Account's lifetime.

## Structure

`AccountEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the image was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the image was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the image was deleted. |
| `LastLogin` | `DateTime` | Required | The timestamp of when the Account was last accessed. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00",
  "last_login": "01/30/2021 08:30:00"
}
```

