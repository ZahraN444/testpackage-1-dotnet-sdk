
# Hub Update Response

## Structure

`HubUpdateResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Hub`](../../doc/models/hub.md) | Required | A hub resource. |

## Example (as JSON)

```json
{
  "data": {
    "id": "651586fca6078e98982dbd90",
    "identifier": "identifier8",
    "name": "name0",
    "creator": {
      "id": "651586fca6078e98982dbd90",
      "type": "employee"
    },
    "events": {
      "created": "01/30/2021 08:30:00",
      "updated": "01/30/2021 08:30:00",
      "deleted": "01/30/2021 08:30:00",
      "converted": "01/30/2021 08:30:00",
      "first_order": "01/30/2021 08:30:00",
      "first_provider": "01/30/2021 08:30:00",
      "first_server": "01/30/2021 08:30:00",
      "first_environment": "01/30/2021 08:30:00",
      "first_image": "01/30/2021 08:30:00",
      "first_container": "01/30/2021 08:30:00"
    },
    "state": {
      "current": "live",
      "changed": "01/30/2021 08:30:00",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "webhooks": {
      "server_deployed": "server_deployed2",
      "server_deleted": "server_deleted0"
    },
    "billing": {
      "term": {
        "start": "01/30/2021 08:30:00",
        "end": "01/30/2021 08:30:00",
        "renew": "once"
      },
      "pause_invoices": false,
      "plans": {
        "tier_id": "tier_id2",
        "support_id": "support_id6"
      },
      "emails": [
        "emails7"
      ],
      "allow_prepaid": false,
      "disable": false
    },
    "meta": {
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
  }
}
```

