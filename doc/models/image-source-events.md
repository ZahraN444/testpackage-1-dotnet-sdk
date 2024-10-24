
# Image Source Events

A collection of timestamps for each event in the image source's lifetime.

## Structure

`ImageSourceEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the image source was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the image source was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the image source was deleted. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00"
}
```

