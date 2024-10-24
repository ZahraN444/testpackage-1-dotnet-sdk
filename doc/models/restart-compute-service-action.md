
# Restart Compute Service Action

A job that restarts compute service on a given server.

## Structure

`RestartComputeServiceAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The action to take.<br>**Default**: `"compute.restart"` |

## Example (as JSON)

```json
{
  "action": "compute.restart"
}
```

