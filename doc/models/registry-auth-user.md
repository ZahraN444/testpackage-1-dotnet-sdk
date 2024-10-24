
# Registry Auth User

User/token based credentials for authentication to a third-party image source.

## Structure

`RegistryAuthUser`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"user"` |
| `Details` | [`Details7`](../../doc/models/details-7.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "user",
  "details": {
    "username": "username0",
    "token": "token4"
  }
}
```

