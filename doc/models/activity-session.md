
# Activity Session

Session info about the activity entry.

## Structure

`ActivitySession`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Url` | `string` | Required | URL endpoint assocaited with the activity context - does not include domain. |
| `Ip` | `string` | Required | The IP of the account associated with the session. |
| `Token` | [`Token`](../../doc/models/token.md) | Required | - |
| `ApiKey` | `string` | Required | The API key ID. |

## Example (as JSON)

```json
{
  "url": "url2",
  "ip": "ip2",
  "token": {
    "application_id": "651586fca6078e98982dbd90",
    "application_capabilities_version": 8
  },
  "api_key": "api_key4"
}
```

