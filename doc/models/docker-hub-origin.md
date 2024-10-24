
# Docker Hub Origin

An image origin where the image is pulled from DockerHub.

## Structure

`DockerHubOrigin`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"docker-hub"` |
| `Details` | [`Details4`](../../doc/models/details-4.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "docker-hub",
  "details": {
    "existing": {
      "source_id": "source_id8"
    },
    "target": "target8",
    "username": "username0",
    "token": "token4"
  }
}
```

