
# Details 10

## Structure

`Details10`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Existing` | [`ExistingSource`](../../doc/models/existing-source.md) | Optional | In a stack, specifies an image source ID from which Cycle will derive any values not specified in the stack file. This is useful for avoiding direct placement of credentials in a stack file, for example. |
| `Target` | `string` | Required | The image name on the registry. |
| `Url` | `string` | Required | The url of the remote registry. |
| `Auth` | [`Details10Auth`](../../doc/models/containers/details-10-auth.md) | Required | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "target": "target8",
  "url": "url8",
  "auth": {
    "type": "user",
    "details": {
      "username": "username0",
      "token": "token4"
    }
  },
  "existing": {
    "source_id": "source_id0"
  }
}
```

