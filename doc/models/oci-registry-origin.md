
# Oci Registry Origin

An image origin that pulls images fro an OCI-compatible registry. Also used for provider-native registries, such as AWS ECR.

## Structure

`OciRegistryOrigin`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"oci-registry"` |
| `Details` | [`Details10`](../../doc/models/details-10.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "oci-registry",
  "details": {
    "target": "target8",
    "url": "url4",
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
}
```

