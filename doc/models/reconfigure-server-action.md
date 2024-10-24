
# Reconfigure Server Action

## Structure

`ReconfigureServerAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The action to take.<br>**Default**: `"features.reconfigure"` |
| `Contents` | [`Contents6`](../../doc/models/contents-6.md) | Required | Supplemental information needed to perform the action. |

## Example (as JSON)

```json
{
  "action": "features.reconfigure",
  "contents": {
    "sftp": false,
    "base_volume_gb": 178
  }
}
```

