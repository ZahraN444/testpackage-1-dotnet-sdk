
# Image Import Step

Settings for the image import step for a pipeline.

## Structure

`ImageImportStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"image.import"` |
| `Details` | [`Details34`](../../doc/models/details-34.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "image.import",
  "details": {
    "image": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n"
  },
  "identifier": "identifier6",
  "options": {
    "skip": false
  }
}
```

