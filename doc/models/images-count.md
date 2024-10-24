
# Images Count

## Structure

`ImagesCount`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Total` | `double` | Required | Number of image sources |
| `State` | [`State7`](../../doc/models/state-7.md) | Required | - |

## Example (as JSON)

```json
{
  "total": 31.48,
  "state": {
    "new": 186.8,
    "downloading": 225.6,
    "building": 135.62,
    "verifying": 196.82,
    "saving": 30.94,
    "live": 41.96,
    "deleting": 5.94
  }
}
```

