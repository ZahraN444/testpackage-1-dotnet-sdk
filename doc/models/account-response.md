
# Account Response

## Structure

`AccountResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Account`](../../doc/models/account.md) | Optional | An object representing information about the currently logged-in user. |

## Example (as JSON)

```json
{
  "data": {
    "id": "id0",
    "name": {
      "first": "first6",
      "last": "last0"
    },
    "email": {
      "address": "address2",
      "verified": false,
      "added": "2016-03-13T12:52:32.123Z"
    },
    "two_factor_auth": {
      "verified": false
    },
    "allow_support_login": false,
    "state": {
      "current": "suspending",
      "changed": "2016-03-13T12:52:32.123Z",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "events": {
      "created": "2016-03-13T12:52:32.123Z",
      "updated": "2016-03-13T12:52:32.123Z",
      "deleted": "2016-03-13T12:52:32.123Z",
      "last_login": "2016-03-13T12:52:32.123Z"
    }
  }
}
```

