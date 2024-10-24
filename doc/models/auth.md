
# Auth

Auth configuration for the VPN.

## Structure

`Auth`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Webhook` | `string` | Required | A webhook endpoint to hit. Will be passed the login credentials provided to the user, and should return a 200 status if the login is permitted. |
| `CycleAccounts` | `bool` | Required | If true, allows any Cycle account with access to the environment to log in to the VPN using their Cycle email and password. |
| `VpnAccounts` | `bool?` | Optional | If true, allows the custom VPN accounts to log in to the VPN. |

## Example (as JSON)

```json
{
  "webhook": "webhook4",
  "cycle_accounts": false,
  "vpn_accounts": false
}
```

