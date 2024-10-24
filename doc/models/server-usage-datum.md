
# Server Usage Datum

Server usage data.

## Structure

`ServerUsageDatum`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Time` | `DateTime` | Required | A timestamp for when the usage data was collected. |
| `Nodes` | `int` | Required | The number of nodes the data is pulled from. |
| `MemoryGb` | `int` | Required | A number in GB representing memory. |

## Example (as JSON)

```json
{
  "time": "01/30/2021 08:30:00",
  "nodes": 134,
  "memory_gb": 132
}
```

