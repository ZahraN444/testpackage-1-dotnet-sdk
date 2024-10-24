
# Image Prune Step

Settings for the images prune step for a pipeline.

## Structure

`ImagePruneStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"images.prune"` |
| `Details` | [`Details35`](../../doc/models/details-35.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "images.prune",
  "details": {
    "source_ids": [
      "source_ids3",
      "source_ids4"
    ]
  },
  "identifier": "identifier4",
  "options": {
    "skip": false
  }
}
```

