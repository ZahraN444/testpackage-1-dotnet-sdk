
# Reimage Container

## Structure

`ReimageContainer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The action to take.<br>**Default**: `"reimage"` |
| `Contents` | [`Contents2`](../../doc/models/contents-2.md) | Required | Additional information needed to complete the job. |

## Example (as JSON)

```json
{
  "action": "reimage",
  "contents": {
    "image_id": "image_id0",
    "allow_incompatible": false,
    "overwrite_runtime_config": false
  }
}
```

