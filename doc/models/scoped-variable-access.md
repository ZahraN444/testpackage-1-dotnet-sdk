
# Scoped Variable Access

The way the scoped variable is accessed.

## Structure

`ScopedVariableAccess`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EnvVariable` | [`EnvVariable1`](../../doc/models/env-variable-1.md) | Optional | When set to true, this scoped variable is set as an environment variable inside the container. |
| `InternalApi` | [`InternalApi`](../../doc/models/internal-api.md) | Optional | If set, this scoped variable will be available over the internal API. Contains settings for accessing this variable over the internal API. |
| `File` | [`File1`](../../doc/models/file-1.md) | Optional | File is an object that describes a path to mount the file to inside the container. |

## Example (as JSON)

```json
{
  "env_variable": {
    "key": "key8"
  },
  "internal_api": {
    "duration": "String5"
  },
  "file": {
    "decode": false,
    "path": "path4"
  }
}
```

