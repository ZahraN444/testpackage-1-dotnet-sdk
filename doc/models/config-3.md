
# Config 3

The config object for the VPN service.

## Structure

`Config3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AllowInternet` | `bool` | Required | If true, routes all traffic through the VPN, even non-Cycle traffic. |
| `Auth` | [`Auth`](../../doc/models/auth.md) | Required | Auth configuration for the VPN. |

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

