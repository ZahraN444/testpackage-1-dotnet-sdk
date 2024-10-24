
# Config 6

The config object for the VPN service, in this case without the required fields normally found in a VPN config object.

## Structure

`Config6`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AllowInternet` | `bool?` | Optional | If true, routes all traffic through the VPN, even non-Cycle traffic. |
| `Auth` | [`Auth`](../../doc/models/auth.md) | Optional | Auth configuration for the VPN. |

## Example (as JSON)

```json
{
  "allow_internet": false,
  "auth": {
    "webhook": "webhook4",
    "cycle_accounts": false,
    "vpn_accounts": false
  }
}
```

