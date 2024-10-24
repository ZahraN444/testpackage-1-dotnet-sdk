
# V1 Infrastructure Servers Usage Response

## Structure

`V1InfrastructureServersUsageResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`ServerUsageDatum`](../../doc/models/server-usage-datum.md) | Required | Server usage data. |

## Example (as JSON)

```json
{
  "data": {
    "time": "01/30/2021 08:30:00",
    "nodes": 174,
    "memory_gb": 172
  }
}
```

