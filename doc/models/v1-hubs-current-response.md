
# V1 Hubs Current Response

## Structure

`V1HubsCurrentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Hub`](../../doc/models/hub.md) | Optional | A hub resource. |

## Example (as JSON)

```json
{
  "data": {
    "id": "id0",
    "identifier": "identifier8",
    "name": "name0",
    "creator": {
      "id": "id8",
      "type": "employee"
    },
    "events": {
      "created": "2016-03-13T12:52:32.123Z",
      "updated": "2016-03-13T12:52:32.123Z",
      "deleted": "2016-03-13T12:52:32.123Z",
      "converted": "2016-03-13T12:52:32.123Z",
      "first_order": "2016-03-13T12:52:32.123Z",
      "first_provider": "2016-03-13T12:52:32.123Z",
      "first_server": "2016-03-13T12:52:32.123Z",
      "first_environment": "2016-03-13T12:52:32.123Z"
    },
    "state": {
      "current": "live",
      "changed": "2016-03-13T12:52:32.123Z",
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
        "start": "2016-03-13T12:52:32.123Z",
        "end": "2016-03-13T12:52:32.123Z",
        "renew": "once"
      },
      "allow_prepaid": false,
      "pause_invoices": false,
      "disable": false,
      "plans": {
        "tier_id": "tier_id2",
        "support_id": "support_id6"
      },
      "emails": [
        "emails7"
      ]
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

