
# V1 Hubs Current Usage Response

## Structure

`V1HubsCurrentUsageResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<HubUsageDatum>`](../../doc/models/hub-usage-datum.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "time": "time0",
      "servers": 17.32,
      "members": 211.82,
      "environments": 111.92,
      "containers": 9.68
    }
  ]
}
```

