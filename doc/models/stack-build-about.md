
# Stack Build About

Information about the stack build.

## Structure

`StackBuildAbout`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Version` | `string` | Required | A user defined version of the build. |
| `Description` | `string` | Required | A user defined description for the build. |
| `GitCommit` | [`StackGitCommit`](../../doc/models/stack-git-commit.md) | Optional | Information about the git commit this stack build was created from. |

## Example (as JSON)

```json
{
  "version": "version8",
  "description": "description2",
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

