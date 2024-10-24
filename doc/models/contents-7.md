
# Contents 7

Additional information needed for the job.

## Structure

`Contents7`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EnvironmentId` | `string` | Required | The ID for the environment this stack build will be deployed to. |
| `Deployment` | [`Contents7Deployment`](../../doc/models/containers/contents-7-deployment.md) | Optional | This is a container for any-of cases. |
| `Update` | [`Contents7Update`](../../doc/models/containers/contents-7-update.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "environment_id": "environment_id2",
  "deployment": {
    "version": "version0"
  },
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
  }
}
```

