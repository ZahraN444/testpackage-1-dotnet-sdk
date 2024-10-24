
# V1 Images Response 1

## Structure

`V1ImagesResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Image`](../../doc/models/image.md) | Required | An image is a point in time build on a given image source, and what is distributed by Cycle to run containers. |

## Example (as JSON)

```json
{
  "data": {
    "id": "651586fca6078e98982dbd90",
    "hub_id": "651586fca6078e98982dbd90",
    "name": "name0",
    "size": 8,
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
}
```

