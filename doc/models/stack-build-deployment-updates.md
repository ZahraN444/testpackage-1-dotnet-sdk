
# Stack Build Deployment Updates

Optional update object used to specify specific params to update from the stack build.

## Structure

`StackBuildDeploymentUpdates`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Containers` | [`Dictionary<string, StackDeployContainersObject>`](../../doc/models/stack-deploy-containers-object.md) | Required | A map of the container names to update within the environment. |
| `ScopedVariables` | [`ScopedVariables`](../../doc/models/scoped-variables.md) | Required | An object that describes configuration options for scoped variables on stack build. |

## Example (as JSON)

```json
{
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
```

