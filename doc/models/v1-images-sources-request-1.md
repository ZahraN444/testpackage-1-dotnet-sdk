
# V1 Images Sources Request 1

## Structure

`V1ImagesSourcesRequest1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | A name for the image source. |
| `Origin` | [`ImageOrigin`](../../doc/models/containers/image-origin.md) | Optional | The origin of the given image source. |
| `Builder` | [`Builder4`](../../doc/models/builder-4.md) | Optional | - |
| `About` | [`About7`](../../doc/models/about-7.md) | Optional | User defined information about the image source. |

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
  "builder": {
    "integration_id": "integration_id6"
  },
  "about": {
    "description": "description4"
  }
}
```

