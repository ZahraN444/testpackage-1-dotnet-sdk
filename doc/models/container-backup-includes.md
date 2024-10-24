
# Container Backup Includes

All includable resources linkable to the given Zone.

## Structure

`ContainerBackupIncludes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Integrations` | [`Dictionary<string, Integration>`](../../doc/models/integration.md) | Optional | A resource thats associated with an integration. |

## Example (as JSON)

```json
{
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
```

