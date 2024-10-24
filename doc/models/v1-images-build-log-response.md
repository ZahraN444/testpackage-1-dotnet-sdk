
# V1 Images Build Log Response

## Structure

`V1ImagesBuildLogResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`ImageBuildLog`](../../doc/models/image-build-log.md) | Required | A build log for a given image. |

## Example (as JSON)

```json
{
  "data": {
    "id": "651586fca6078e98982dbd90",
    "hub_id": "651586fca6078e98982dbd90",
    "image_id": "image_id4",
    "log": "log8",
    "events": {
      "created": "01/30/2021 08:30:00",
      "updated": "01/30/2021 08:30:00",
      "deleted": "01/30/2021 08:30:00"
    }
  }
}
```

