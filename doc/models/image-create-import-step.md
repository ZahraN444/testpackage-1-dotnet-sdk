
# Image Create Import Step

A pipeline step for creating and importing an image in one go.

## Structure

`ImageCreateImportStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"image.create-import"` |
| `Details` | [`Details33`](../../doc/models/details-33.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "image.create-import",
  "details": {
    "source": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
    "name": "name0",
    "build": {
      "args": {
        "key0": "args9"
      }
    },
    "override": {
      "target": "target2",
      "targz_url": "targz_url0"
    }
  },
  "identifier": "identifier4",
  "options": {
    "skip": false
  }
}
```

