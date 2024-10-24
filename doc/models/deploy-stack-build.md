
# Deploy Stack Build

## Structure

`DeployStackBuild`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The action the job takes.<br>**Default**: `"deploy"` |
| `Contents` | [`Contents7`](../../doc/models/contents-7.md) | Required | Additional information needed for the job. |

## Example (as JSON)

```json
{
  "action": "deploy",
  "contents": {
    "environment_id": "environment_id4",
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
}
```

