
# Build Log Events

A collection of timestamps for each event in the build log's lifetime.

## Structure

`BuildLogEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the build log was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the build log was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the build log was deleted. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00"
}
```

