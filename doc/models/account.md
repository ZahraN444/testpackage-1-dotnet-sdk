
# Account

An object representing information about the currently logged-in user.

## Structure

`Account`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Name` | [`Name`](../../doc/models/name.md) | Required | The first and last name associated with the Account. |
| `Email` | [`Email`](../../doc/models/email.md) | Required | Information about the email address associated with the Account. |
| `TwoFactorAuth` | [`TwoFactorAuth`](../../doc/models/two-factor-auth.md) | Optional | Two factor auth verification information. |
| `AllowSupportLogin` | `bool?` | Optional | Indicates whether or not Cycle employees have authorization to log in to this Account in a support capacity. |
| `State` | [`AccountState`](../../doc/models/account-state.md) | Required | - |
| `Events` | [`AccountEvents`](../../doc/models/account-events.md) | Required | A collection of timestamps for each event in the Account's lifetime. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "name": {
    "first": "first6",
    "last": "last0"
  },
  "email": {
    "address": "address2",
    "verified": false,
    "added": "01/30/2021 08:30:00"
  },
  "state": {
    "current": "suspending",
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
    "last_login": "01/30/2021 08:30:00"
  },
  "two_factor_auth": {
    "verified": false
  },
  "allow_support_login": false
}
```

