
# Details 6

## Structure

`Details6`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Existing` | [`ExistingSource`](../../doc/models/existing-source.md) | Optional | In a stack, specifies an image source ID from which Cycle will derive any values not specified in the stack file. This is useful for avoiding direct placement of credentials in a stack file, for example. |
| `Target` | `string` | Required | The image name on the registry. |
| `Url` | `string` | Required | The url of the remote registry. |
| `Username` | `string` | Optional | For authentication, a username. |
| `Token` | `string` | Optional | For authentication, a token. |
| `Password` | `string` | Optional | For authentication, a password. |

## Example (as JSON)

```json
{
  "existing": {
    "source_id": "source_id0"
  },
  "target": "target4",
  "url": "url2",
  "username": "username8",
  "token": "token8",
  "password": "password2"
}
```

