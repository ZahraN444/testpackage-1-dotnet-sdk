
# V1 Hubs Current Integrations Response

## Structure

`V1HubsCurrentIntegrationsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Integration`](../../doc/models/integration.md) | Required | - |

## Example (as JSON)

```json
{
  "data": {
    "id": "651586fca6078e98982dbd90",
    "vendor": "vendor6",
    "identifier": "identifier8",
    "creator": {
      "id": "651586fca6078e98982dbd90",
      "type": "employee"
    },
    "hub_id": "651586fca6078e98982dbd90",
    "state": {
      "current": "live",
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
    "name": "name0",
    "auth": {
      "region": "region2",
      "namespace": "namespace6",
      "api_key": "api_key6",
      "key_id": "key_id2",
      "secret": "secret8"
    },
    "extra": {
      "key0": "extra4",
      "key1": "extra3",
      "key2": "extra2"
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
```

