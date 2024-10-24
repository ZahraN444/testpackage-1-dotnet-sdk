
# HTTP Source Credentials

## Structure

`HTTPSourceCredentials`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"http"` |
| `Credentials` | [`Credentials`](../../doc/models/credentials.md) | Required | Authentication credentails for the Dockerfile image source type when authenticating over HTTP. |

## Example (as JSON)

```json
{
  "type": "http",
  "credentials": {
    "username": "username4",
    "password": "password0"
  }
}
```

