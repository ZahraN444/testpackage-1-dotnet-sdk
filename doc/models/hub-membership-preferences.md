
# Hub Membership Preferences

Preference information set by the user for the membership.

## Structure

`HubMembershipPreferences`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Portal` | [`Portal`](../../doc/models/portal.md) | Required | - |
| `Email` | [`Email1`](../../doc/models/email-1.md) | Required | - |

## Example (as JSON)

```json
{
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
}
```

