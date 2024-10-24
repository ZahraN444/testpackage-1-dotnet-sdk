
# VPN User

A VPN user for a given VPN.

## Structure

`VPNUser`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Username` | `string` | Required | The username for the login. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `LastLogin` | `DateTime` | Required | A timestamp of the last time the user logged into the VPN. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `EnvironmentId` | `string` | Required | An identifier for the environment the VPN service is associated with. |
| `Events` | [`VPNUserEvents`](../../doc/models/vpn-user-events.md) | Required | A collection of timestamps for each event in the VPN user's lifetime. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "username": "username2",
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "last_login": "01/30/2021 08:30:00",
  "hub_id": "651586fca6078e98982dbd90",
  "environment_id": "environment_id6",
  "events": {
    "created": "01/30/2021 08:30:00",
    "updated": "01/30/2021 08:30:00",
    "deleted": "01/30/2021 08:30:00"
  }
}
```

