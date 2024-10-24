
# V1 Stacks Builds Request

## Structure

`V1StacksBuildsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `About` | [`StackBuildAbout`](../../doc/models/stack-build-about.md) | Optional | Information about the stack build. |
| `Instructions` | [`StackBuildInstructions`](../../doc/models/stack-build-instructions.md) | Optional | Additional instructions used when generating this stack build. |

## Example (as JSON)

```json
{
  "about": {
    "version": "version0",
    "description": "description4",
    "git_commit": {
      "hash": "hash8",
      "message": "message8",
      "time": "2016-03-13T12:52:32.123Z",
      "author": {
        "name": "name0",
        "email": "email6"
      }
    }
  },
  "instructions": {
    "git": {
      "type": "hash",
      "value": "value4"
    },
    "variables": {
      "key0": "variables1",
      "key1": "variables0",
      "key2": "variables9"
    }
  }
}
```

