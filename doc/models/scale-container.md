
# Scale Container

## Structure

`ScaleContainer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The action to take.<br>**Default**: `"scale"` |
| `Contents` | [`Contents3`](../../doc/models/contents-3.md) | Required | Additional information needed to complete the job. |

## Example (as JSON)

```json
{
  "action": "scale",
  "contents": {
    "instances": 82
  }
}
```

