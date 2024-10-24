
# Public Account

Publicly available information about an account

## Structure

`PublicAccount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | [`AccountName`](../../doc/models/account-name.md) | Required | The first and last name of an account owner |
| `Email` | [`AccountEmail`](../../doc/models/account-email.md) | Required | Email information for an account |
| `Id` | `string` | Required | Id information for an account |
| `Events` | [`Events`](../../doc/models/events.md) | Optional | - |

## Example (as JSON)

```json
{
  "name": {
    "first": "first6",
    "last": "last0"
  },
  "email": {
    "address": "address2",
    "verified": false,
    "added": "01/30/2021 08:30:00"
  },
  "id": "id8",
  "events": {
    "last_login": "2016-03-13T12:52:32.123Z"
  }
}
```

