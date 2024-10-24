
# Storage Pool

User data storage across all devices.

## Structure

`StoragePool`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DataPercent` | `double` | Required | The percentage of storage used by user data. |
| `MetaPercent` | `double` | Required | The percentage of storage used by the file allocation stables, etc. |
| `Total` | `double` | Required | The total amount of storage available. |

## Example (as JSON)

```json
{
  "data_percent": 16.88,
  "meta_percent": 20.9,
  "total": 93.94
}
```

