
# Senders

A record with an ID mapped to a public account for the account that sent this memberships initial invite.

## Structure

`Senders`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Accounts` | [`Dictionary<string, PublicAccount>`](../../doc/models/public-account.md) | Optional | A record with an ID mapped to a public account. |

## Example (as JSON)

```json
{
  "accounts": {
    "key0": {
      "name": {
        "first": "first6",
        "last": "last0"
      },
      "email": {
        "address": "address2",
        "verified": false,
        "added": "2016-03-13T12:52:32.123Z"
      },
      "id": "id0",
      "events": {
        "last_login": "2016-03-13T12:52:32.123Z"
      }
    },
    "key1": {
      "name": {
        "first": "first6",
        "last": "last0"
      },
      "email": {
        "address": "address2",
        "verified": false,
        "added": "2016-03-13T12:52:32.123Z"
      },
      "id": "id0",
      "events": {
        "last_login": "2016-03-13T12:52:32.123Z"
      }
    },
    "key2": {
      "name": {
        "first": "first6",
        "last": "last0"
      },
      "email": {
        "address": "address2",
        "verified": false,
        "added": "2016-03-13T12:52:32.123Z"
      },
      "id": "id0",
      "events": {
        "last_login": "2016-03-13T12:52:32.123Z"
      }
    }
  }
}
```

