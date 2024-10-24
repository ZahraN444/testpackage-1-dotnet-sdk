
# Docker File Origin

An image origin where the image is built from a Dockerfile located in a git repository.

## Structure

`DockerFileOrigin`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"docker-file"` |
| `Details` | [`Details5`](../../doc/models/details-5.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "docker-file",
  "details": {
    "existing": {
      "source_id": "source_id8"
    },
    "repo": {
      "url": "url8",
      "branch": "branch0",
      "auth": {
        "type": "type0",
        "credentials": {
          "username": "username4",
          "password": "password0"
        }
      },
      "ref": {
        "type": "type0",
        "value": "value2"
      }
    },
    "targz_url": "targz_url0",
    "context_dir": "context_dir6",
    "build_file": "build_file0"
  }
}
```

