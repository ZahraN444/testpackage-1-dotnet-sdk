
# Stack Build Deploy Step

Settings for deploying a stack build in a pipeline.

## Structure

`StackBuildDeployStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"stack.build.deploy"` |
| `Details` | [`Details54`](../../doc/models/details-54.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "stack.build.deploy",
  "details": {
    "build": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
    "environment": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
    "update": {
      "containers": {
        "key0": {
          "reimage": false,
          "reconfigure": false
        }
      },
      "scoped_variables": {
        "add_new": false,
        "replace_existing": false
      }
    },
    "deployment": {
      "version": "version0"
    }
  },
  "identifier": "identifier2",
  "options": {
    "skip": false
  }
}
```

