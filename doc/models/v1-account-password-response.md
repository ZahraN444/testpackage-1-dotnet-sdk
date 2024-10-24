
# V1 Account Password Response

## Structure

`V1AccountPasswordResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Account`](../../doc/models/account.md) | Required | An object representing information about the currently logged-in user. |

## Example (as JSON)

```json
{
  "data": {
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
}
```

