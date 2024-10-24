
# Hub

A hub resource.

## Structure

`Hub`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Identifier` | `string` | Required | A human readable slugged identifier for this hub. |
| `Name` | `string` | Required | A name for the hub. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `Events` | [`HubEvents`](../../doc/models/hub-events.md) | Required | A collection of timestamps for each event in the hub's lifetime. |
| `State` | [`HubState`](../../doc/models/hub-state.md) | Required | - |
| `Webhooks` | [`HubWebhooks`](../../doc/models/hub-webhooks.md) | Required | Hub related webhooks. When supplied, the given webhook will be called with a payload any time one of these events occurs. |
| `Billing` | [`HubBilling`](../../doc/models/containers/hub-billing.md) | Required | This is a container for any-of cases. |
| `Meta` | [`HubsMeta`](../../doc/models/hubs-meta.md) | Optional | A list of meta fields that can be applied to a hub. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "identifier": "identifier0",
  "name": "name2",
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
```

