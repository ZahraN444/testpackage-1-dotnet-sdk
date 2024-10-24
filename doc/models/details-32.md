
# Details 32

## Structure

`Details32`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Type` | `string` | Required | - |
| `About` | [`ImageSourceAbout`](../../doc/models/image-source-about.md) | Optional | Information about the image source resource. |
| `Origin` | [`ImageOrigin`](../../doc/models/containers/image-origin.md) | Required | The origin of the given image source. |

## Example (as JSON)

```json
{
  "name": "name2",
  "type": "type8",
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
  "about": {
    "description": "description4"
  }
}
```

