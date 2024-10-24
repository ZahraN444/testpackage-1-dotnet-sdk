
# Stack Prune Step

Settings for pruning a stack in a pipeline.

## Structure

`StackPruneStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"stack.prune"` |
| `Details` | [`Details55`](../../doc/models/details-55.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "stack.prune",
  "details": {
    "stack": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
    "criteria": {
      "expire": "expire4"
    }
  },
  "identifier": "identifier4",
  "options": {
    "skip": false
  }
}
```

