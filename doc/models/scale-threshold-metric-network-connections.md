
# Scale Threshold Metric Network Connections

Describes the network connections threshold at which scaling will occur

## Structure

`ScaleThresholdMetricNetworkConnections`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"network-connections"` |
| `Details` | [`Details17`](../../doc/models/details-17.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "network-connections",
  "details": {
    "connections_total": 170
  }
}
```

