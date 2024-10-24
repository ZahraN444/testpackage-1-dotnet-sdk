
# V1 Stacks Request 1

## Structure

`V1StacksRequest1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | A name for the Stack. |
| `Variables` | `Dictionary<string, string>` | Optional | A map of default variable values used when building this Stack. A variable can be added anywhere in a Stack using the format `{{var}}` where `var` would be a key in this map. |
| `Source` | [`StackSource`](../../doc/models/containers/stack-source.md) | Optional | A source for a stack to be created from. |

## Example (as JSON)

```json
{
  "name": "name4",
  "variables": {
    "key0": "variables1",
    "key1": "variables2"
  },
  "source": {
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
}
```

