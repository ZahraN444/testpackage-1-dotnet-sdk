
# Docker Registry Origin

An image origin where the image is pulled from a private Docker registry.

## Structure

`DockerRegistryOrigin`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"docker-registry"` |
| `Details` | [`Details6`](../../doc/models/details-6.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "docker-registry",
  "details": {
    "existing": {
      "source_id": "source_id0"
    },
    "target": "target8",
    "url": "url4",
    "username": "username0",
    "token": "token4",
    "password": "password4"
  }
}
```

