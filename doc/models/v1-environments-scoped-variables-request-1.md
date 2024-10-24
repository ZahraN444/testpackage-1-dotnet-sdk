
# V1 Environments Scoped Variables Request 1

## Structure

`V1EnvironmentsScopedVariablesRequest1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier, similar to a key in an Environment variable.  Its used when envoking the Scoped Variable. |
| `Scope` | [`ScopedVariableScope`](../../doc/models/scoped-variable-scope.md) | Optional | Information about the assignment of the scoped variable and how it is invoked. |
| `Access` | [`ScopedVariableAccess`](../../doc/models/scoped-variable-access.md) | Optional | The way the scoped variable is accessed. |
| `Source` | [`V1EnvironmentsScopedVariablesRequest1Source`](../../doc/models/containers/v1-environments-scoped-variables-request-1-source.md) | Optional | This is a container for one-of cases. |

## Example (as JSON)

```json
{
  "identifier": "identifier2",
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
    "type": "type2",
    "details": {
      "value": "value2",
      "blob": false,
      "secret": {
        "iv": "iv6",
        "hint": "hint4"
      }
    }
  }
}
```

