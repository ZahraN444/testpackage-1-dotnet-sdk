
# Scoped Variable

Scoped variables are a way for users to dynamically allocate runtime specific environment variables across any number of containers in an environment.

## Structure

`ScopedVariable`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `EnvironmentId` | `string` | Required | An identifier used to reference the environment this resource is scoped to. |
| `Identifier` | `string` | Required | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `Scope` | [`ScopedVariableScope`](../../doc/models/scoped-variable-scope.md) | Required | Information about the assignment of the scoped variable and how it is invoked. |
| `Access` | [`ScopedVariableAccess`](../../doc/models/scoped-variable-access.md) | Required | The way the scoped variable is accessed. |
| `Source` | [`ScopedVariableSource`](../../doc/models/containers/scoped-variable-source.md) | Required | This is a container for one-of cases. |
| `State` | [`ScopedVariableState`](../../doc/models/scoped-variable-state.md) | Required | - |
| `Events` | [`ScopedVariableEvents`](../../doc/models/scoped-variable-events.md) | Required | A collection of timestamps for each event in the Scoped Variable's lifetime. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "hub_id": "651586fca6078e98982dbd90",
  "environment_id": "environment_id6",
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
```

