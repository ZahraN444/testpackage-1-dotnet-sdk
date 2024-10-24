
# Remote Access

## Structure

`RemoteAccess`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enable` | `bool` | Required | - |
| `Ips` | `List<string>` | Optional | - |
| `WebHook` | `string` | Optional | - |
| `Password` | [`Password`](../../doc/models/password.md) | Required | - |

## Example (as JSON)

```json
{
  "enable": false,
  "ips": [
    "ips2"
  ],
  "web_hook": "web_hook8",
  "password": {
    "algorithm": "sha512",
    "data": "data4"
  }
}
```

