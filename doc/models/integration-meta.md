
# Integration Meta

Additional fields that can be requested for an Integration on fetch.

## Structure

`IntegrationMeta`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Definition` | [`IntegrationDefinition1`](../../doc/models/integration-definition-1.md) | Optional | The full Integration definition associated with this Integration. |

## Example (as JSON)

```json
{
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
```

