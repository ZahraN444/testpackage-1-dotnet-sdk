
# Vpn

## Structure

`Vpn`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enable` | `bool?` | Optional | Whether or not the VPN service is enabled. |
| `ContainerId` | `string` | Optional | The ID of the VPN service container |
| `AutoUpdate` | `bool?` | Optional | A boolean representing if this service container is set to autoupdate or not |
| `Config` | [`Config3`](../../doc/models/config-3.md) | Optional | The config object for the VPN service. |

## Example (as JSON)

```json
{
  "enable": false,
  "container_id": "container_id2",
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
```

