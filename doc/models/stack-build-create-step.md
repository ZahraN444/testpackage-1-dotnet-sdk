
# Stack Build Create Step

Settings for creating a stack build in a pipeline.

## Structure

`StackBuildCreateStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"stack.build.create"` |
| `Details` | [`Details52`](../../doc/models/details-52.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "stack.build.create",
  "details": {
    "stack": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
    "instructions": {
      "git": {
        "type": "hash",
        "value": "value4"
      },
      "variables": {
        "key0": "variables1",
        "key1": "variables0",
        "key2": "variables9"
      }
    },
    "about": {
      "version": "version0",
      "description": "description4"
    }
  },
  "identifier": "identifier4",
  "options": {
    "skip": false
  }
}
```

