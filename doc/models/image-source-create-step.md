
# Image Source Create Step

Settings for the image source create step for a pipeline.

## Structure

`ImageSourceCreateStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"image.source.create"` |
| `Details` | [`Details32`](../../doc/models/details-32.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "image.source.create",
  "details": {
    "name": "name0",
    "type": "type0",
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
    "about": {
      "description": "description4"
    }
  },
  "identifier": "identifier8",
  "options": {
    "skip": false
  }
}
```

