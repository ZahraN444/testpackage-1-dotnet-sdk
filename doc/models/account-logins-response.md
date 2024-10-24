
# Account Logins Response

## Structure

`AccountLoginsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<AccountLoginsResponseData>`](../../doc/models/containers/account-logins-response-data.md) | Required | This is List of a container for one-of cases. |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "id2",
      "account": {
        "id": "id0",
        "ip": "ip4"
      },
      "time": "2016-03-13T12:52:32.123Z",
      "type": "password",
      "success": false,
      "employee": {
        "id": "id8",
        "ip": "ip2"
      }
    },
    {
      "id": "id2",
      "account": {
        "id": "id0",
        "ip": "ip4"
      },
      "time": "2016-03-13T12:52:32.123Z",
      "type": "password",
      "success": false,
      "employee": {
        "id": "id8",
        "ip": "ip2"
      }
    },
    {
      "id": "id2",
      "account": {
        "id": "id0",
        "ip": "ip4"
      },
      "time": "2016-03-13T12:52:32.123Z",
      "type": "password",
      "success": false,
      "employee": {
        "id": "id8",
        "ip": "ip2"
      }
    }
  ]
}
```

