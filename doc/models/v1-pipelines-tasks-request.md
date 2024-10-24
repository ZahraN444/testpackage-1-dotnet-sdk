
# V1 Pipelines Tasks Request

## Structure

`V1PipelinesTasksRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The requested action to perform.<br>**Default**: `"trigger"` |
| `Contents` | [`Contents14`](../../doc/models/contents-14.md) | Optional | - |

## Example (as JSON)

```json
{
  "action": "trigger",
  "contents": {
    "variables": {
      "key0": "variables7"
    }
  }
}
```

