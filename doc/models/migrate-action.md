
# Migrate Action

## Structure

`MigrateAction`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The name of the action to perform.<br>**Default**: `"migrate"` |
| `Contents` | [`Contents4`](../../doc/models/contents-4.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "migrate",
  "contents": {
    "destination_server_id": "destination_server_id8",
    "stateful": {
      "copy_volumes": false
    }
  }
}
```

