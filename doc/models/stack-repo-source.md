
# Stack Repo Source

A repo source type for a stack.

## Structure

`StackRepoSource`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"git-repo"` |
| `Details` | [`Details20`](../../doc/models/details-20.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "git-repo",
  "details": {
    "url": "url4",
    "branch": "branch6",
    "auth": {
      "type": "type0",
      "credentials": {
        "username": "username4",
        "password": "password0"
      }
    },
    "ref": {
      "type": "type0",
      "value": "value2"
    }
  }
}
```

