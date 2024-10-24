
# Backend 1

Describes where the image is hosted.

## Structure

`Backend1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Provider` | `string` | Required | The provider where this image is hosted. |
| `Size` | `int` | Required | The size of the image in bytes. |
| `FileName` | `string` | Required | A file name for the image, used by the platform. |
| `FileId` | `string` | Required | A file id for the image, used by the platform. |

## Example (as JSON)

```json
{
  "provider": "provider0",
  "size": 208,
  "file_name": "file_name0",
  "file_id": "file_id4"
}
```

