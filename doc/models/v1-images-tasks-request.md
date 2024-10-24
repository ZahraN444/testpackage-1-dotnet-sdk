
# V1 Images Tasks Request

## Structure

`V1ImagesTasksRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The action is the Job type to create.<br>**Default**: `"prune"` |
| `Contents` | [`Contents12`](../../doc/models/contents-12.md) | Required | Additional contents needed by the platform to create the Job. |

## Example (as JSON)

```json
{
  "action": "prune",
  "contents": {
    "source_ids": [
      "source_ids1",
      "source_ids0",
      "source_ids9"
    ]
  }
}
```

