
# Stack

Stacks are a way to orchestrate multiple containers atomically and automatically.

## Structure

`Stack`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Identifier` | `string` | Required | A human readable slugged identifier for this stack. |
| `Name` | `string` | Required | A user defined name for the stack resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Creator` | [`UserScope`](../../doc/models/user-scope.md) | Required | A type of creator and a matching identifier. |
| `Source` | [`StackSource`](../../doc/models/containers/stack-source.md) | Required | A source for a stack to be created from. |
| `State` | [`StackState`](../../doc/models/stack-state.md) | Required | - |
| `Variables` | `Dictionary<string, string>` | Optional | A map of default variable values used when building this stack. A variable can be added anywhere in a stack using the format `{{var}}` where `var` would be a key in this map. |
| `Events` | [`StackEvents`](../../doc/models/stack-events.md) | Required | A collection of timestamps for each event in the Stacks lifetime. |
| `Meta` | [`StackMeta`](../../doc/models/stack-meta.md) | Optional | A list of meta fields that can be applied to this stack. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "identifier": "identifier4",
  "name": "name6",
  "hub_id": "651586fca6078e98982dbd90",
  "creator": {
    "type": "employee",
    "id": "651586fca6078e98982dbd90"
  },
  "source": {
    "type": "git-repo",
    "details": {
      "url": "url4",
      "branch": "branch6",
      "auth": {
        "type": "type0",
        "credentials": {
          "username": "username4",
          "password": "password0"
        }
      },
      "ref": {
        "type": "type0",
        "value": "value2"
      }
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
    "deleted": "01/30/2021 08:30:00",
    "last_build": "01/30/2021 08:30:00"
  },
  "variables": {
    "key0": "variables3",
    "key1": "variables4",
    "key2": "variables5"
  },
  "meta": {
    "containers_count": {
      "state": {
        "key0": 148,
        "key1": 149,
        "key2": 150
      },
      "total": 80,
      "available": 126
    },
    "builds_count": {
      "state": {
        "key0": 112,
        "key1": 113
      },
      "total": 116,
      "available": 162
    }
  }
}
```

