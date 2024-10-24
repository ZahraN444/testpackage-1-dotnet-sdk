
# V1 Containers Backups Response

## Structure

`V1ContainersBackupsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<ContainerBackup>`](../../doc/models/container-backup.md) | Required | - |
| `Includes` | [`ContainerBackupIncludes`](../../doc/models/container-backup-includes.md) | Optional | All includable resources linkable to the given Zone. |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "651586fca6078e98982dbd90",
      "hub_id": "651586fca6078e98982dbd90",
      "container_id": "container_id6",
      "instance_id": "instance_id0",
      "target": {
        "integration_id": "my-image-source",
        "path": "path6",
        "file_id": "file_id8",
        "size": 106
      },
      "state": {
        "current": "deleting",
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
      }
    }
  ],
  "includes": {
    "integrations": {
      "key0": {
        "id": "id6",
        "name": "name6",
        "vendor": "vendor2",
        "identifier": "identifier6",
        "auth": {
          "region": "region2",
          "namespace": "namespace6",
          "api_key": "api_key6",
          "key_id": "key_id2",
          "secret": "secret8"
        },
        "extra": {
          "key0": "extra8"
        },
        "creator": {
          "id": "id8",
          "type": "employee"
        },
        "hub_id": "hub_id8",
        "state": {
          "current": "live",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "events": {
          "created": "2016-03-13T12:52:32.123Z",
          "updated": "2016-03-13T12:52:32.123Z",
          "deleted": "2016-03-13T12:52:32.123Z"
        },
        "meta": {
          "definition": {
            "vendor": "vendor6",
            "name": "name0",
            "supports_verification": false,
            "supports_multiple": false,
            "features": [
              "features1",
              "features2",
              "features3"
            ],
            "extends": [
              "extends4",
              "extends5",
              "extends6"
            ],
            "extended_configuration": {
              "options": [
                {
                  "title": "title2",
                  "key": "key2",
                  "type": "type8"
                },
                {
                  "title": "title2",
                  "key": "key2",
                  "type": "type8"
                },
                {
                  "title": "title2",
                  "key": "key2",
                  "type": "type8"
                }
              ]
            },
            "fields": {
              "extra": {
                "key0": {
                  "regex": "regex4",
                  "required": false,
                  "description": "description6"
                },
                "key1": {
                  "regex": "regex4",
                  "required": false,
                  "description": "description6"
                }
              },
              "auth": {
                "key0": {
                  "regex": "regex4",
                  "required": false,
                  "description": "description6"
                },
                "key1": {
                  "regex": "regex4",
                  "required": false,
                  "description": "description6"
                }
              }
            },
            "url": "url4",
            "public": false,
            "usable": false,
            "editable": false
          }
        }
      }
    }
  }
}
```

