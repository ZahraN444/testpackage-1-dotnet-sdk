
# V1 Hubs Current Members Response 2

## Structure

`V1HubsCurrentMembersResponse2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`HubMembership`](../../doc/models/hub-membership.md) | Required | A membership resource that is scoped to an individual hub. |

## Example (as JSON)

```json
{
  "data": {
    "id": "651586fca6078e98982dbd90",
    "hub_id": "651586fca6078e98982dbd90",
    "events": {
      "created": "01/30/2021 08:30:00",
      "updated": "01/30/2021 08:30:00",
      "deleted": "01/30/2021 08:30:00",
      "joined": "01/30/2021 08:30:00"
    },
    "role_id": "651586fca6078e98982dbd90",
    "permissions": {
      "all_environments": false,
      "environments": [
        {
          "id": "651586fca6078e98982dbd90",
          "manage": false
        }
      ]
    },
    "state": {
      "current": "declined",
      "changed": "01/30/2021 08:30:00",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "invitation": {
      "sender": {
        "id": "651586fca6078e98982dbd90",
        "type": "type2"
      },
      "recipient": "recipient2",
      "events": {
        "created": "01/30/2021 08:30:00",
        "updated": "01/30/2021 08:30:00",
        "deleted": "01/30/2021 08:30:00",
        "accepted": "01/30/2021 08:30:00",
        "declined": "01/30/2021 08:30:00",
        "revoked": "01/30/2021 08:30:00"
      }
    },
    "account_id": "account_id2",
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

