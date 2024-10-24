
# Container Scale

Network configuration for a container.

## Structure

`ContainerScale`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AutoscaleGroup` | `string` | Required | The autoscaling group describes which servers should be deployed |
| `Instances` | [`Instances`](../../doc/models/instances.md) | Required | Describes how many instances should be running |
| `Window` | `string` | Required | Duration in which the auto-scaler will watch for changes |
| `Thresholds` | [`List<ScaleThresholdMetric>`](../../doc/models/containers/scale-threshold-metric.md) | Required | Discriminated union describing the different types of scaling threshold and their respective details |

## Example (as JSON)

```json
{
  "autoscale_group": "autoscale_group0",
  "instances": {
    "delta": 232,
    "max": 128,
    "max_server": 132,
    "min_ttl": "72h45m2s"
  },
  "window": "72h45m2s",
  "thresholds": [
    {
      "type": "ram",
      "details": {
        "used": "used2"
      }
    }
  ]
}
```

