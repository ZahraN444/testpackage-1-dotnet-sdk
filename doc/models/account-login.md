
# Account Login

A record of an Account login.

## Structure

`AccountLogin`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Account` | [`AccountLoginInfo`](../../doc/models/account-login-info.md) | Required | Details of an Account login. |
| `Time` | `DateTime` | Required | A timestamp of the time the login occurred. |
| `Type` | [`Type1Enum`](../../doc/models/type-1-enum.md) | Required | The type of login mechanism used. |
| `Success` | `bool` | Required | A boolean where true reflects that the login was successful. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "account": {
    "id": "651586fca6078e98982dbd90",
    "ip": "ip4"
  },
  "time": "01/30/2021 08:30:00",
  "type": "password",
  "success": false
}
```

