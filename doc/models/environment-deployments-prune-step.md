
# Environment Deployments Prune Step

Remove any containers that are part of a deployment that does NOT have a tag associated with it.

## Structure

`EnvironmentDeploymentsPruneStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"environment.deployments.prune"` |
| `Details` | [`Details44`](../../doc/models/details-44.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "environment.deployments.prune",
  "details": {
    "environment": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n"
  },
  "identifier": "identifier4",
  "options": {
    "skip": false
  }
}
```

