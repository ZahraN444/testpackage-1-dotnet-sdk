
# Stack Build Instructions

Additional instructions used when generating this stack build.

## Structure

`StackBuildInstructions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Git` | [`Git`](../../doc/models/git.md) | Optional | Git information specifics. |
| `Variables` | `Dictionary<string, string>` | Optional | Custom variables applied to the stack during build. Any place in the stack where a `{{variable}}` is used is replaced with the value of the variable supplied in this map. |

## Example (as JSON)

```json
{
  "git": {
    "type": "hash",
    "value": "value4"
  },
  "variables": {
    "key0": "variables9",
    "key1": "variables0"
  }
}
```

