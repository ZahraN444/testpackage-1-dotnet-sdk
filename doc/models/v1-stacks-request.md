
# V1 Stacks Request

## Structure

`V1StacksRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | A name for the Stack. |
| `Identifier` | `string` | Optional | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `Variables` | `Dictionary<string, string>` | Optional | A map of default variable values used when building this Stack. A variable can be added anywhere in a Stack using the format `{{var}}` where `var` would be a key in this map. |
| `Source` | [`StackSource`](../../doc/models/containers/stack-source.md) | Required | A source for a stack to be created from. |

## Example (as JSON)

```json
{
  "name": "name4",
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
  },
  "identifier": "identifier8",
  "variables": {
    "key0": "variables3",
    "key1": "variables2"
  }
}
```

