
# Vpn Reset Task

This will reset the VPN certificates and restart the container. Should be done when the certificates expire, every 1000 days. Then, you will need to redownload the VPN config in order to connect.

## Structure

`VpnResetTask`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The name of the action to perform.<br>**Default**: `"reset"` |

## Example (as JSON)

```json
{
  "action": "reset"
}
```

