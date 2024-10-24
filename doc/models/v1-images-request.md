
# V1 Images Request

## Structure

`V1ImagesRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | A name for the Image. |
| `SourceId` | `string` | Required | The ID for the Image source to be used. |
| `Build` | [`Build4`](../../doc/models/build-4.md) | Optional | A build object, holding information important to the Image build. |
| `Override` | [`Override5`](../../doc/models/override-5.md) | Optional | An override object to be used for a single Image create request. |

## Example (as JSON)

```json
{
  "name": "name8",
  "source_id": "source_id2",
  "build": {
    "args": {
      "key0": "args9"
    }
  },
  "override": {
    "target": "target2",
    "targz_url": "targz_url0"
  }
}
```

