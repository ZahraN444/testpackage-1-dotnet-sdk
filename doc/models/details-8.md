
# Details 8

## Structure

`Details8`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Flavor` | `string` | Required, Constant | **Default**: `"ecr"` |
| `Credentials` | [`RegistryAuthProviderCredentials`](../../doc/models/registry-auth-provider-credentials.md) | Required | - |

## Example (as JSON)

```json
{
  "flavor": "ecr",
  "credentials": {
    "region": "region2",
    "namespace": "namespace6",
    "api_key": "api_key6",
    "secret": "secret8",
    "subscription_id": "subscription_id6"
  }
}
```

