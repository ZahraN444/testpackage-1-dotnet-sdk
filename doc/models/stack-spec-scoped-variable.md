
# Stack Spec Scoped Variable

## Structure

`StackSpecScopedVariable`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Required | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `Scope` | [`Scope`](../../doc/models/scope.md) | Required | - |
| `Access` | [`Access`](../../doc/models/access.md) | Required | - |
| `Source` | [`StackSpecScopedVariableSource`](../../doc/models/containers/stack-spec-scoped-variable-source.md) | Required | This is a container for one-of cases. |

## Example (as JSON)

```json
{
  "identifier": "identifier4",
  "scope": {
    "containers": {
      "global": false,
      "ids": [
        "ids3",
        "ids4",
        "ids5"
      ],
      "identifiers": [
        "identifiers8",
        "identifiers9"
      ]
    }
  },
  "access": {
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
  },
  "source": {
    "type": "url",
    "details": {
      "url": "url4",
      "headers": {
        "key0": {
          "key1": "val1",
          "key2": "val2"
        }
      },
      "auth_token_url": "auth_token_url4"
    }
  }
}
```

