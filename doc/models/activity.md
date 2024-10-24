
# Activity

A resource representing information about activity taking place on a given hub.

## Structure

`Activity`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `User` | [`User`](../../doc/models/user.md) | Required | Userscope |
| `Verbosity` | `int` | Required | A number representing the detail level (verbosity) of this activity.<br><br>## Levels<br><br>- 0: activity that other users would find useful<br>- 1: activity that can be useful in tracking down how a user did something<br>- 2: full activity, can be useful in debugging problems |
| `Context` | [`ActivityContext`](../../doc/models/activity-context.md) | Required | ID context for resources associated with an activity. |
| `Session` | [`ActivitySession2`](../../doc/models/containers/activity-session-2.md) | Required | This is a container for any-of cases. |
| `Changes` | [`List<ActivityChange>`](../../doc/models/activity-change.md) | Required | An array of changes. |
| `Annotations` | `object` | Required | A record of additional annotations for the activity. |
| `Error` | [`Error3`](../../doc/models/error-3.md) | Required | An object describing a given activity error. |
| `Component` | [`Component`](../../doc/models/component.md) | Required | An object holding information about a component. |
| `Tags` | `List<string>` | Optional | An array of tags that denote things such as a type of security event, or can be user-provided. |
| `Status` | [`Status1Enum`](../../doc/models/status-1-enum.md) | Required | A status for the given activity. |
| `Security` | [`ActivitySecurity`](../../doc/models/activity-security.md) | Optional | Security information pertaining to this activity. |
| `Monitor` | [`ActivityMonitor`](../../doc/models/activity-monitor.md) | Optional | Details related to the monitor that raised this activity event. |
| `Event` | [`Event2Enum`](../../doc/models/event-2-enum.md) | Required | The activity event. |
| `Time` | `DateTime` | Required | A timestamp for when the activity took place. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "hub_id": "651586fca6078e98982dbd90",
  "user": {
    "type": "platform",
    "id": "id0"
  },
  "verbosity": 28,
  "context": {
    "environment_id": "environment_id0",
    "container_id": "container_id8",
    "instance_id": "instance_id8",
    "server_id": "server_id8",
    "stack_id": "stack_id2"
  },
  "session": {
    "url": "url2",
    "ip": "ip2",
    "token": {
      "application_id": "651586fca6078e98982dbd90",
      "application_capabilities_version": 8
    },
    "api_key": "api_key4"
  },
  "changes": [
    {
      "component": "component6",
      "before": {
        "id": "id0",
        "number": 192,
        "string": "string4"
      },
      "after": {
        "id": "id2",
        "number": 216,
        "string": "string6"
      }
    }
  ],
  "annotations": {
    "key0": {
      "key1": "val1",
      "key2": "val2"
    },
    "key1": {
      "key1": "val1",
      "key2": "val2"
    },
    "key2": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "error": {
    "message": "message4"
  },
  "component": {
    "id": "651586fca6078e98982dbd90",
    "type": "type2"
  },
  "status": "error",
  "event": "infrastructure.server.sharedfs.reconfigure",
  "time": "01/30/2021 08:30:00",
  "tags": [
    "tags1",
    "tags2",
    "tags3"
  ],
  "security": {
    "risk": "medium",
    "surface": "network",
    "event": "notice",
    "attack": "access-elevation"
  },
  "monitor": {
    "level": "info",
    "event": "reaction",
    "state": "none"
  }
}
```

