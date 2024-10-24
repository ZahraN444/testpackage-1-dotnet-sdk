
# Auth 4

Authentication information for the Integration, can be null.

## Structure

`Auth4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Region` | `string` | Optional | The region associated with the Integration. |
| `Namespace` | `string` | Optional | The namespace associated with the Integration. |
| `ApiKey` | `string` | Optional | API key for accessing the Integration. |
| `KeyId` | `string` | Optional | Key ID for accessing the Integration. |
| `Secret` | `string` | Optional | Secret for accessing the Integration. |
| `SubscriptionId` | `string` | Optional | Subscription ID for the Integration. |
| `ClientId` | `string` | Optional | Client ID for the Integration. |
| `Base64Config` | `string` | Optional | Base64 encoded configuration for the Integration. |

## Example (as JSON)

```json
{
  "region": "region8",
  "namespace": "namespace0",
  "api_key": "api_key0",
  "key_id": "key_id8",
  "secret": "secret8"
}
```

