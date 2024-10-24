
# Details 52

## Structure

`Details52`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Stack` | `string` | Required | An identifier used in pipelines to refer to different kinds of resources across Cycle.<br><br>## Types:<br><br>- `id:<mongo id>`: A raw resource ID<br>- `resource:<a resource identifier>`: A compound identifier pointing to a resource.<br>- `from:<stage/step>`: For referencing a previous pipeline step. |
| `Instructions` | [`StackBuildInstructions`](../../doc/models/stack-build-instructions.md) | Optional | Additional instructions used when generating this stack build. |
| `About` | [`About4`](../../doc/models/about-4.md) | Optional | Information about the stack build. |

## Example (as JSON)

```json
{
  "stack": "- id:6515098637b66c233ed164e7\n- resource:cluster:dev,env:demo,container:api\n- from:/image-create\n",
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
  },
  "about": {
    "version": "version0",
    "description": "description4"
  }
}
```

