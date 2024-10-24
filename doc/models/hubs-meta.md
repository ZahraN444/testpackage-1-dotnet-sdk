
# Hubs Meta

A list of meta fields that can be applied to a hub.

## Structure

`HubsMeta`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Membership` | [`HubMembership`](../../doc/models/hub-membership.md) | Optional | A membership resource that is scoped to an individual hub. |

## Example (as JSON)

```json
{
  "membership": {
    "id": "id4",
    "account_id": "account_id6",
    "hub_id": "hub_id6",
    "events": {
      "created": "2016-03-13T12:52:32.123Z",
      "updated": "2016-03-13T12:52:32.123Z",
      "deleted": "2016-03-13T12:52:32.123Z",
      "joined": "2016-03-13T12:52:32.123Z"
    },
    "role_id": "role_id0",
    "permissions": {
      "all_environments": false,
      "environments": [
        {
          "id": "id2",
          "manage": false
        }
      ]
    },
    "preferences": {
      "portal": {
        "notifications": {
          "jobs": {
            "apikey_alerts": false
          }
        }
      },
      "email": {
        "notificaitons": {
          "server": {
            "new": false,
            "offline": false
          }
        }
      }
    },
    "state": {
      "current": "declined",
      "changed": "2016-03-13T12:52:32.123Z",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "invitation": {
      "sender": {
        "id": "id8",
        "type": "type2"
      },
      "recipient": "recipient2",
      "events": {
        "created": "2016-03-13T12:52:32.123Z",
        "updated": "2016-03-13T12:52:32.123Z",
        "deleted": "2016-03-13T12:52:32.123Z",
        "accepted": "2016-03-13T12:52:32.123Z",
        "declined": "2016-03-13T12:52:32.123Z",
        "revoked": "2016-03-13T12:52:32.123Z"
      }
    },
    "cycle": {
      "employee_id": "employee_id0"
    },
    "meta": {
      "capabilities": {
        "all": false,
        "specific": [
          "pipelines-view"
        ]
      }
    }
  }
}
```

