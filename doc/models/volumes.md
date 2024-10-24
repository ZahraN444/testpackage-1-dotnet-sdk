
# Volumes

## Structure

`Volumes`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The name of the volume. |
| `Size` | `int` | Required | The size in megabytes of the volume. |
| `DataPercent` | `int` | Required | The percent of the volumes size being used by data. |
| `MetaPercent` | `int` | Required | The percent of the volumes size being used by meta data. |
| `Pool` | `string` | Required | The name of the volume pool this volume is associated with. |

## Example (as JSON)

```json
{
  "name": "name6",
  "size": 158,
  "data_percent": 176,
  "meta_percent": 226,
  "pool": "pool0"
}
```

