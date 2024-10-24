
# Stack Spec Scoped Variable Raw Source

A stack spec resource.

## Structure

`StackSpecScopedVariableRawSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"raw"` |
| `Details` | [`Details14`](../../doc/models/details-14.md) | Required | - |

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

