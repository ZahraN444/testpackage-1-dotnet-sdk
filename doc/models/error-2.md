
# Error 2

## Structure

`Error2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Message` | `string` | Required | - |
| `MessageInternal` | `string` | Optional | - |
| `Stack` | [`List<Stack2>`](../../doc/models/stack-2.md) | Optional | - |

## Example (as JSON)

```json
{
  "message": "message8",
  "message_internal": "message_internal6",
  "stack": [
    {
      "file": "file4",
      "function": "function0",
      "line": 212
    },
    {
      "file": "file4",
      "function": "function0",
      "line": 212
    },
    {
      "file": "file4",
      "function": "function0",
      "line": 212
    }
  ]
}
```

