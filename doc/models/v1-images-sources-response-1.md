
# V1 Images Sources Response 1

## Structure

`V1ImagesSourcesResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`ImageSource`](../../doc/models/image-source.md) | Required | An image source is a set of resources that direct the platform on where it can find the resources needed to build an image resource. |

## Example (as JSON)

```json
{
  "data": {
    "id": "651586fca6078e98982dbd90",
    "identifier": "identifier8",
    "type": "bucket",
    "hub_id": "651586fca6078e98982dbd90",
    "name": "name0",
    "origin": {
      "type": "docker-hub",
      "details": {
        "existing": {
          "source_id": "source_id8"
        },
        "target": "target8",
        "username": "username0",
        "token": "token4"
      }
    },
    "creator": {
      "id": "651586fca6078e98982dbd90",
      "type": "employee"
    },
    "state": {
      "current": "deleted",
      "changed": "01/30/2021 08:30:00",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "events": {
      "created": "01/30/2021 08:30:00",
      "updated": "01/30/2021 08:30:00",
      "deleted": "01/30/2021 08:30:00"
    },
    "about": {
      "description": "description4"
    },
    "builder": {
      "integration_id": "integration_id6"
    },
    "meta": {
      "images_count": {
        "total": 68.62,
        "state": {
          "new": 186.8,
          "downloading": 225.6,
          "building": 135.62,
          "verifying": 196.82,
          "saving": 30.94,
          "live": 41.96,
          "deleting": 5.94
        }
      }
    }
  }
}
```

