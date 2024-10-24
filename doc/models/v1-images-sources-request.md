
# V1 Images Sources Request

## Structure

`V1ImagesSourcesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | A name for the Image Source. |
| `Identifier` | `string` | Optional | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `Builder` | [`Builder`](../../doc/models/builder.md) | Optional | - |
| `Type` | [`ImageSourceTypeEnum`](../../doc/models/image-source-type-enum.md) | Required | The type of images in this source. |
| `Origin` | [`ImageOrigin`](../../doc/models/containers/image-origin.md) | Required | The origin of the given image source. |
| `About` | [`About6`](../../doc/models/about-6.md) | Optional | User defined information about the Image Source. |

## Example (as JSON)

```json
{
  "type": "direct",
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
  "name": "name4",
  "identifier": "identifier8",
  "builder": {
    "integration_id": "integration_id6"
  },
  "about": {
    "description": "description4"
  }
}
```

