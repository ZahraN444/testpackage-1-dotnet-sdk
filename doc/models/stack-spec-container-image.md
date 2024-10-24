
# Stack Spec Container Image

## Structure

`StackSpecContainerImage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Origin` | [`ImageOrigin`](../../doc/models/containers/image-origin.md) | Required | The origin of the given image source. |
| `Build` | [`Build`](../../doc/models/build.md) | Optional | - |
| `Builder` | [`Builder`](../../doc/models/builder.md) | Optional | - |

## Example (as JSON)

```json
{
  "name": "name6",
  "origin": {
    "type": "docker-hub",
    "details": {
      "existing": {
        "source_id": "source_id8"
      },
      "target": "target8",
      "username": "username0",
      "token": "token4"
    }
  },
  "build": {
    "args": {
      "key0": "args9"
    }
  },
  "builder": {
    "integration_id": "integration_id6"
  }
}
```

