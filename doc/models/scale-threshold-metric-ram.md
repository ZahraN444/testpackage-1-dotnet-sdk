
# Scale Threshold Metric Ram

Describes the RAM threshold at which scaling will occur

## Structure

`ScaleThresholdMetricRam`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"ram"` |
| `Details` | [`Details15`](../../doc/models/details-15.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "ram",
  "details": {
    "used": "1G, 2M"
  }
}
```

