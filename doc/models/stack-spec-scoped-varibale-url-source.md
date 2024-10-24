
# Stack Spec Scoped Varibale Url Source

The `URL` type of scoped variable `value`, referred to as a source. This means the value of this variable is the result of calling the given URL. It is dynamic, in that Cycle will refetch the contents on every start.

## Structure

`StackSpecScopedVaribaleUrlSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | The type of source value, can be either `raw` or `url`.<br>**Default**: `"url"` |
| `Details` | [`Details13`](../../doc/models/details-13.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "url",
  "details": {
    "url": "url4",
    "headers": {
      "key0": {
        "key1": "val1",
        "key2": "val2"
      }
    },
    "auth_token_url": "auth_token_url4"
  }
}
```

