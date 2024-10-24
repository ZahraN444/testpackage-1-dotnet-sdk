
# Image Build Log

A build log for a given image.

## Structure

`ImageBuildLog`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `ImageId` | `string` | Required | The ID of the image the build log pertains to. |
| `Log` | `string` | Required | The log itself. |
| `Events` | [`BuildLogEvents`](../../doc/models/build-log-events.md) | Required | A collection of timestamps for each event in the build log's lifetime. |

## Example (as JSON)

```json
{
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
```

