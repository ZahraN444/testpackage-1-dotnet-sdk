
# Container Reimage Step

Settings for reimaging a container in a pipeline

## Structure

`ContainerReimageStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"container.reimage"` |
| `Details` | [`Details41`](../../doc/models/details-41.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "container.reimage",
  "details": {
    "container": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
    "image": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
    "options": {
      "allow_incompatible": false
    }
  },
  "identifier": "identifier8",
  "options": {
    "skip": false
  }
}
```

