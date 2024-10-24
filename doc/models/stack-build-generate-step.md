
# Stack Build Generate Step

Settings for the stack build generate step for a pipeline.

## Structure

`StackBuildGenerateStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"stack.build.generate"` |
| `Details` | [`Details53`](../../doc/models/details-53.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "stack.build.generate",
  "details": {
    "build": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n"
  },
  "identifier": "identifier4",
  "options": {
    "skip": false
  }
}
```

