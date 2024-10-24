
# Container Stop Step

Settings for stopping a container in a pipeline

## Structure

`ContainerStopStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"container.stop"` |
| `Details` | [`Details38`](../../doc/models/details-38.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "container.stop",
  "details": {
    "container": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n"
  },
  "identifier": "identifier8",
  "options": {
    "skip": false
  }
}
```

