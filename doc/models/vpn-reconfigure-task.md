
# Vpn Reconfigure Task

## Structure

`VpnReconfigureTask`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The action to take.<br>**Default**: `"reconfigure"` |
| `Contents` | [`Contents1`](../../doc/models/contents-1.md) | Required | Additional information the platform needs to create this job. |

## Example (as JSON)

```json
{
  "action": "reconfigure",
  "contents": {
    "enable": false,
    "high_availability": false,
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

