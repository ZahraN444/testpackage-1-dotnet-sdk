
# Details 14

## Structure

`Details14`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `string` | Required | The value of the variable. |
| `Blob` | `bool` | Required | A boolean where true represents the text the user is entering will be multi line. |
| `Secret` | [`Secret`](../../doc/models/secret.md) | Required | - |

## Example (as JSON)

```json
{
  "value": "value8",
  "blob": false,
  "secret": {
    "iv": "iv6",
    "hint": "hint4"
  }
}
```

