
# Volume Groups

Volume group

## Structure

`VolumeGroups`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | A name for the volume group. |
| `Size` | `int` | Required | A number representing the aggregate group volume size in megabytes. |
| `Volumes` | [`Dictionary<string, Volumes>`](../../doc/models/volumes.md) | Required | The actual volumes. |

## Example (as JSON)

```json
{
  "name": "name6",
  "size": 232,
  "volumes": {
    "key0": {
      "name": "name6",
      "size": 224,
      "data_percent": 206,
      "meta_percent": 96,
      "pool": "pool0"
    }
  }
}
```

