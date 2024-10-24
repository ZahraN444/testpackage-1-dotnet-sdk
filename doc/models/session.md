
# Session

## Structure

`Session`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `string` | Optional | URL endpoint assocaited with the activity context - does not include domain. |
| `Ip` | `string` | Optional | The IP of the account associated with the session. |
| `Token` | [`Token`](../../doc/models/token.md) | Optional | - |
| `ApiKey` | `string` | Optional | The API key ID. |

## Example (as JSON)

```json
{
  "url": "url2",
  "ip": "ip2",
  "token": {
    "application_id": "application_id2",
    "application_capabilities_version": 8
  },
  "api_key": "api_key4"
}
```

