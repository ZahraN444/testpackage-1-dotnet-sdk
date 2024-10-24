
# Integration Definition 1

The full Integration definition associated with this Integration.

## Structure

`IntegrationDefinition1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Vendor` | `string` | Required | - |
| `Name` | `string` | Required | - |
| `SupportsVerification` | `bool` | Required | - |
| `SupportsMultiple` | `bool` | Required | - |
| `Features` | `List<string>` | Optional | A list of additional features supported by this Integration. |
| `Extends` | `List<string>` | Optional | A list of functionality that this integration extends. i.e. ["backups"] |
| `ExtendedConfiguration` | [`ExtendedConfiguration`](../../doc/models/extended-configuration.md) | Optional | Additional configuration options that are available when using this Integration. These describe additional functionality that Cycle may utilize. |
| `Fields` | [`Fields`](../../doc/models/fields.md) | Optional | - |
| `Url` | `string` | Required | - |
| `Public` | `bool` | Required | - |
| `Usable` | `bool` | Required | - |
| `Editable` | `bool` | Required | If true, the Integration can be edited. Otherwise, to make a change it will need to be deleted and recreated. |

## Example (as JSON)

```json
{
  "vendor": "vendor0",
  "name": "name4",
  "supports_verification": false,
  "supports_multiple": false,
  "features": [
    "features5",
    "features6"
  ],
  "extends": [
    "extends8",
    "extends9"
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
  "url": "url8",
  "public": false,
  "usable": false,
  "editable": false
}
```

