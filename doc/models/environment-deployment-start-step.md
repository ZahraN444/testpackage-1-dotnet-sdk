
# Environment Deployment Start Step

Start all containers with a specific deployment version/tag within an environment.

## Structure

`EnvironmentDeploymentStartStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"environment.deployment.start"` |
| `Details` | [`Details47`](../../doc/models/details-47.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "environment.deployment.start",
  "details": {
    "environment": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
    "tag": "tag4",
    "version": "version6"
  },
  "identifier": "identifier6",
  "options": {
    "skip": false
  }
}
```

