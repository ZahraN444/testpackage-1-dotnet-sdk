
# Image

An image is a point in time build on a given image source, and what is distributed by Cycle to run containers.

## Structure

`Image`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Name` | `string` | Required | A user defined name for the image. |
| `Size` | `int` | Required | The image size in bytes. |
| `About` | [`About2`](../../doc/models/about-2.md) | Optional | An object that holds information about the image. |
| `Backend` | [`Backend1`](../../doc/models/backend-1.md) | Required | Describes where the image is hosted. |
| `Requires` | [`Requires`](../../doc/models/requires.md) | Required | Any restrictions or requirements needed to run this image as a container. |
| `Build` | [`Build1`](../../doc/models/build-1.md) | Optional | Any additional build details for this image |
| `Builder` | [`Builder2`](../../doc/models/builder-2.md) | Optional | Configuration options regarding the builder used to create/import this Image. |
| `Config` | [`Config7`](../../doc/models/config-7.md) | Required | Configuration settings for the image. |
| `Source` | [`ImageSource2`](../../doc/models/containers/image-source-2.md) | Optional | This is a container for one-of cases. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Optional | The creator scope is embedded in resource objects to describe who created them |
| `Factory` | [`Factory`](../../doc/models/factory.md) | Optional | Information about the Factory service that built/imported the Image into Cycle. |
| `State` | [`ImageState`](../../doc/models/image-state.md) | Required | - |
| `Events` | [`ImageEvents`](../../doc/models/image-events.md) | Required | A collection of timestamps for each event in the image's lifetime. |
| `Meta` | [`ImageMeta`](../../doc/models/image-meta.md) | Optional | A list of meta fields that can be applied to the image. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "hub_id": "651586fca6078e98982dbd90",
  "name": "name6",
  "size": 106,
  "backend": {
    "provider": "provider2",
    "size": 170,
    "file_name": "file_name2",
    "file_id": "file_id2"
  },
  "requires": {
    "nvidia_gpu": false
  },
  "config": {
    "user": "user6",
    "ports": [
      {
        "host": 55.68,
        "container": 138.72,
        "type": "type0"
      }
    ],
    "env": {
      "key0": "env5",
      "key1": "env6",
      "key2": "env7"
    },
    "labels": {
      "key0": "labels6",
      "key1": "labels5"
    },
    "command": [
      "command3",
      "command2"
    ],
    "entrypoint": [
      "entrypoint6"
    ],
    "volumes": [
      {
        "path": "path0",
        "mode": "ro"
      }
    ],
    "workdir": "workdir2",
    "signal_stop": "signal_stop4"
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
  "build": {
    "args": {
      "key0": "args9"
    }
  },
  "builder": {
    "integration_id": "integration_id6"
  },
  "source": {
    "type": "direct",
    "details": {
      "id": "id0",
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
      }
    },
    "override": {
      "target": "target2",
      "targz_url": "targz_url0"
    }
  },
  "creator": {
    "id": "id8",
    "type": "employee"
  }
}
```

