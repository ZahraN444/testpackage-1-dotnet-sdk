
# Restart Compute Spawner

A job that restarts compute service on a given server.

## Structure

`RestartComputeSpawner`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The action to take.<br>**Default**: `"compute.spawner.restart"` |

## Example (as JSON)

```json
{
  "action": "compute.spawner.restart"
}
```

