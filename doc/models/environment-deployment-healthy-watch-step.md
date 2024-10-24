
# Environment Deployment Healthy Watch Step

Waits for a deployment to be considered 'healthy' before allowing the pipeline to continue.
A deployement is considered 'healthy' when all instances of all containers that have had a state change in the last 15 minutes
that have health checks defined, become healthy.

## Structure

`EnvironmentDeploymentHealthyWatchStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"environment.deployment.healthy.watch"` |
| `Details` | [`Details51`](../../doc/models/details-51.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "environment.deployment.healthy.watch",
  "details": {
    "environment": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
    "tag": "tag4",
    "version": "version6",
    "max_wait": "String9"
  },
  "identifier": "identifier8",
  "options": {
    "skip": false
  }
}
```

