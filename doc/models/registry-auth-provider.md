
# Registry Auth Provider

Credentials for authentication to a provider-native image registry, such as AWS ECR.

## Structure

`RegistryAuthProvider`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"provider"` |
| `Details` | [`Details8`](../../doc/models/details-8.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "provider",
  "details": {
    "flavor": "ecr",
    "credentials": {
      "region": "region2",
      "namespace": "namespace6",
      "api_key": "api_key6",
      "secret": "secret8",
      "subscription_id": "subscription_id6"
    }
  }
}
```

