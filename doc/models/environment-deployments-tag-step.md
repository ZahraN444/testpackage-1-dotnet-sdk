
# Environment Deployments Tag Step

Settings for updating a deployment tag to another deployment version.

## Structure

`EnvironmentDeploymentsTagStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"environment.deployments.tag"` |
| `Details` | [`Details49`](../../doc/models/details-49.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "environment.deployments.tag",
  "details": {
    "environment": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
    "tag": "tag4",
    "deployment": {
      "version": "v1.2.3-dev"
    }
  },
  "identifier": "identifier8",
  "options": {
    "skip": false
  }
}
```

