
# Container Events

A collection of timestamps for each event in the container's lifetime.

## Structure

`ContainerEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the container was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the container was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the container was deleted. |
| `Started` | `DateTime` | Required | The timestamp of when the container was started. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00",
  "started": "01/30/2021 08:30:00"
}
```

