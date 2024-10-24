
# V1 Environments Services Vpn Response

## Structure

`V1EnvironmentsServicesVpnResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`VPNInfo`](../../doc/models/vpn-info.md) | Required | A summary of a VPN service for a given environment. |

## Example (as JSON)

```json
{
  "data": {
    "url": "url4",
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
}
```

