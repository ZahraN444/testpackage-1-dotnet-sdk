
# Raw Scoped Variable Source

The `raw` type of scoped variable `value`, referred to as a source.  This means that the value is static, not the result of a call to an external or internal URL.

## Structure

`RawScopedVariableSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | The type of source value, can be either `raw` or `url`.<br>**Default**: `"raw"` |
| `Details` | [`Details23`](../../doc/models/details-23.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "raw",
  "details": {
    "value": "value2",
    "blob": false,
    "secret": {
      "iv": "iv6",
      "hint": "hint4"
    }
  }
}
```

