
# Reconfigure SDN Network

## Structure

`ReconfigureSDNNetwork`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The Job to do.<br>**Default**: `"reconfigure"` |
| `Contents` | [`Contents13`](../../doc/models/contents-13.md) | Required | Additional information needed for the Job. |

## Example (as JSON)

```json
{
  "action": "reconfigure",
  "contents": {
    "environment_ids": [
      "environment_ids9",
      "environment_ids0"
    ]
  }
}
```

