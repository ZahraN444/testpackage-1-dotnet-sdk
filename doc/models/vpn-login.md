
# VPN Login

A VPN login event record.

## Structure

`VPNLogin`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Username` | `string` | Required | The username used when logging in. |
| `EnvironmentId` | `string` | Required | The ID of the environment the VPN service is in. |
| `Ip` | `string` | Required | The IP address of the machine the user has logged in from. |
| `Time` | `DateTime` | Required | The timestamp for when the login occured. |
| `Success` | `bool` | Required | A boolean where true means the login attempt was successful. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "username": "username2",
  "environment_id": "environment_id6",
  "ip": "ip2",
  "time": "01/30/2021 08:30:00",
  "success": false
}
```

