
# Image 2

## Structure

`Image2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | - |
| `Origin` | [`ImageOrigin`](../../doc/models/containers/image-origin.md) | Optional | The origin of the given image source. |
| `Build` | [`Build`](../../doc/models/build.md) | Optional | - |
| `Builder` | [`Builder`](../../doc/models/builder.md) | Optional | - |

## Example (as JSON)

```json
{
  "name": "name0",
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

