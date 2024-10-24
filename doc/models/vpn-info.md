
# VPN Info

A summary of a VPN service for a given environment.

## Structure

`VPNInfo`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `string` | Required | A url associated with the VPN service. |
| `Service` | [`VPNInfoService`](../../doc/models/containers/vpn-info-service.md) | Required | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "url": "url8",
  "service": {
    "enable": false,
    "container_id": "container_id0",
    "auto_update": false,
    "config": {
      "allow_internet": false,
      "auth": {
        "webhook": "webhook4",
        "cycle_accounts": false,
        "vpn_accounts": false
      }
    }
  }
}
```

