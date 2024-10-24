
# State 7

## Structure

`State7`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `New` | `double` | Required | Number of images in this source with state new |
| `Downloading` | `double` | Required | Number of images in this source with state downloading |
| `Building` | `double` | Required | Number of images in this source with state building |
| `Verifying` | `double` | Required | Number of images in this source with state verifying |
| `Saving` | `double` | Required | Number of images in this source with state saving |
| `Live` | `double` | Required | Number of images in this source with state live |
| `Deleting` | `double` | Required | Number of images in this source with state deleting |

## Example (as JSON)

```json
{
  "new": 48.5,
  "downloading": 107.9,
  "building": 17.92,
  "verifying": 79.12,
  "saving": 107.36,
  "live": 180.26,
  "deleting": 144.24
}
```

