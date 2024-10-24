
# V1 Environments Scoped Variables Request

## Structure

`V1EnvironmentsScopedVariablesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Required | An identifier for this Scoped Variable. |
| `Scope` | [`ScopedVariableScope`](../../doc/models/scoped-variable-scope.md) | Required | Information about the assignment of the scoped variable and how it is invoked. |
| `Access` | [`ScopedVariableAccess`](../../doc/models/scoped-variable-access.md) | Optional | The way the scoped variable is accessed. |
| `Source` | [`V1EnvironmentsScopedVariablesRequestSource`](../../doc/models/containers/v1-environments-scoped-variables-request-source.md) | Required | This is a container for one-of cases. |

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
  "source": {
    "type": "raw",
    "details": {
      "value": "value2",
      "blob": false,
      "secret": {
        "iv": "iv6",
        "hint": "hint4"
      }
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
  }
}
```

