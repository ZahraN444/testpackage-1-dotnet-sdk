
# Environment Reconfigure Deployments Action

A task to reconfigure deployment mappings on an environment.

## Structure

`EnvironmentReconfigureDeploymentsAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The action to take.<br>**Default**: `"deployments.reconfigure"` |
| `Contents` | [`Contents`](../../doc/models/contents.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "deployments.reconfigure",
  "contents": {
    "tags": {
      "key0": "tags1",
      "key1": "tags2"
    }
  }
}
```

