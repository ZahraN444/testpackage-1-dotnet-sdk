
# V1 Containers Backups Tasks Request

## Structure

`V1ContainersBackupsTasksRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The action to take.<br>**Default**: `"restore"` |
| `Contents` | [`Contents11`](../../doc/models/contents-11.md) | Required | Additional information the platform needs to create this Job. |

## Example (as JSON)

```json
{
  "action": "restore",
  "contents": {
    "instance_id": "instance_id4"
  }
}
```

