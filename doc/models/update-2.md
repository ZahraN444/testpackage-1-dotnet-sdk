
# Update 2

## Structure

`Update2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Containers` | [`Dictionary<string, StackDeployContainersObject>`](../../doc/models/stack-deploy-containers-object.md) | Optional | A map of the container names to update within the environment. |
| `ScopedVariables` | [`ScopedVariables`](../../doc/models/scoped-variables.md) | Optional | An object that describes configuration options for scoped variables on stack build. |

## Example (as JSON)

```json
{
  "containers": {
    "key0": {
      "reimage": false,
      "reconfigure": false
    },
    "key1": {
      "reimage": false,
      "reconfigure": false
    },
    "key2": {
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

