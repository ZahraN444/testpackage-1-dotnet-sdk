
# Image Source

An image source is a set of resources that direct the platform on where it can find the resources needed to build an image resource.

## Structure

`ImageSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Identifier` | `string` | Required | A human readable slugged identifier for this image source. |
| `Type` | [`ImageSourceTypeEnum`](../../doc/models/image-source-type-enum.md) | Required | The type of images in this source. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Name` | `string` | Required | A name for the image source resource. |
| `About` | [`ImageSourceAbout`](../../doc/models/image-source-about.md) | Optional | Information about the image source resource. |
| `Origin` | [`ImageOrigin`](../../doc/models/containers/image-origin.md) | Required | The origin of the given image source. |
| `Builder` | [`Builder1`](../../doc/models/builder-1.md) | Optional | Configuration options regarding the builder used to create/import Images using this Image Source. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `State` | [`ImageSourceState`](../../doc/models/image-source-state.md) | Required | - |
| `Events` | [`ImageSourceEvents`](../../doc/models/image-source-events.md) | Required | A collection of timestamps for each event in the image source's lifetime. |
| `Meta` | [`ImageSourceMeta`](../../doc/models/image-source-meta.md) | Optional | A list of meta fields that can be applied to this environment. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "identifier": "identifier6",
  "type": "direct",
  "hub_id": "651586fca6078e98982dbd90",
  "name": "name6",
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
```

