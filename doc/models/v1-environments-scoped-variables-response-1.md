
# V1 Environments Scoped Variables Response 1

## Structure

`V1EnvironmentsScopedVariablesResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`ScopedVariable`](../../doc/models/scoped-variable.md) | Required | Scoped variables are a way for users to dynamically allocate runtime specific environment variables across any number of containers in an environment. |

## Example (as JSON)

```json
{
  "data": {
    "id": "651586fca6078e98982dbd90",
    "creator": {
      "id": "651586fca6078e98982dbd90",
      "type": "employee"
    },
    "hub_id": "651586fca6078e98982dbd90",
    "environment_id": "environment_id8",
    "identifier": "identifier8",
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
    },
    "state": {
      "current": "deleted",
      "changed": "01/30/2021 08:30:00",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "events": {
      "created": "01/30/2021 08:30:00",
      "updated": "01/30/2021 08:30:00",
      "deleted": "01/30/2021 08:30:00"
    }
  }
}
```

