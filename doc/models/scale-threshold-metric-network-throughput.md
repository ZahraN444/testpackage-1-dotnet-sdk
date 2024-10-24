
# Scale Threshold Metric Network Throughput

Describes the network throughput threshold at which scaling will occur

## Structure

`ScaleThresholdMetricNetworkThroughput`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"network-throughput"` |
| `Details` | [`Details19`](../../doc/models/details-19.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "network-throughput",
  "details": {
    "private": false,
    "bandwidth": "1G, 2M"
  }
}
```

