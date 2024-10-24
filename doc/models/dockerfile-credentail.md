
# Dockerfile Credentail

Credentials object used for authentication of indirect resources such as private parent images.

## Structure

`DockerfileCredentail`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `string` | Optional | The url the resource is located at. |
| `Username` | `string` | Optional | A username for authentication. |
| `Token` | `string` | Optional | A token for authentication. |

## Example (as JSON)

```json
{
  "url": "url4",
  "username": "username0",
  "token": "token6"
}
```

