
# About 1

Information about the stack build.

## Structure

`About1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Version` | `string` | Required | Information about the version of the stack. |
| `Description` | `string` | Required | Information describing the stack |
| `GitCommit` | [`StackGitCommit`](../../doc/models/stack-git-commit.md) | Optional | Information about the git commit this stack build was created from. |

## Example (as JSON)

```json
{
  "version": "version8",
  "description": "description8",
  "git_commit": {
    "hash": "hash8",
    "message": "message8",
    "time": "2016-03-13T12:52:32.123Z",
    "author": {
      "name": "name0",
      "email": "email6"
    }
  }
}
```

