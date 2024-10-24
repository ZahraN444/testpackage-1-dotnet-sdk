
# Scale Threshold Metric Cpu

Describes the CPU threshold at which scaling will occur

## Structure

`ScaleThresholdMetricCpu`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"cpu"` |
| `Details` | [`Details16`](../../doc/models/details-16.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "cpu",
  "details": {
    "utilization": 32
  }
}
```

