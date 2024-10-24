
# Details 23

## Structure

`Details23`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MValue` | `string` | Required | The value of the variable. |
| `Blob` | `bool` | Required | A boolean where true represents the text the user is entering will be multi line. |
| `Secret` | [`Secret1`](../../doc/models/secret-1.md) | Optional | - |

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

