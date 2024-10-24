
# Stack Git Commit

Information about the git commit this stack build was created from.

## Structure

`StackGitCommit`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Hash` | `string` | Required | The commit hash for the given stack build. |
| `Message` | `string` | Required | The commit message for the given stack build hash. |
| `Time` | `DateTime` | Required | The time the commit was made. |
| `Author` | [`Author`](../../doc/models/author.md) | Required | Inforamtion about the author of the commit. |

## Example (as JSON)

```json
{
  "hash": "hash2",
  "message": "message6",
  "time": "01/30/2021 08:30:00",
  "author": {
    "name": "name0",
    "email": "email6"
  }
}
```

