
# Hub Membership

A membership resource that is scoped to an individual hub.

## Structure

`HubMembership`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `AccountId` | `string` | Optional | An ID for the account associated with the given membership. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Events` | [`MembershipEvents`](../../doc/models/membership-events.md) | Required | A collection of timestamps for each event in the membership's lifetime. |
| `RoleId` | `string` | Optional | A 24 character hex string used to identify a unique resource. |
| `Permissions` | [`HubMembershipPermissions`](../../doc/models/hub-membership-permissions.md) | Required | Information about this member's permissions for a given hub. |
| `Preferences` | [`HubMembershipPreferences`](../../doc/models/hub-membership-preferences.md) | Optional | Preference information set by the user for the membership. |
| `State` | [`MembershipState`](../../doc/models/membership-state.md) | Required | - |
| `Invitation` | [`HubMembershipInvitation`](../../doc/models/hub-membership-invitation.md) | Required | Information about a hub membership invitation. |
| `Cycle` | [`Cycle`](../../doc/models/cycle.md) | Optional | If this member is a Cycle employee, their employee ID will be listed here. Cycle employee accounts do not consume a "membership" for a given hub. |
| `Meta` | [`HubMembershipMeta`](../../doc/models/hub-membership-meta.md) | Optional | A list of meta fields that can be applied to a membership. |

## Example (as JSON)

```json
{
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
  "account_id": "account_id0",
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
```

