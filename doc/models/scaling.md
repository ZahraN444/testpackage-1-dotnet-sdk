
# Scaling

## Structure

`Scaling`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AutoscaleGroup` | `string` | Optional | The autoscaling group describes which servers should be deployed |
| `Instances` | [`Instances`](../../doc/models/instances.md) | Optional | Describes how many instances should be running |
| `Window` | `string` | Optional | Duration in which the auto-scaler will watch for changes |
| `Thresholds` | [`List<StackContainerScaleThreshold>`](../../doc/models/containers/stack-container-scale-threshold.md) | Optional | Discriminated union describing the different types of scaling threshold and their respective details |

## Example (as JSON)

```json
{
  "window": "72h45m2s",
  "autoscale_group": "autoscale_group2",
  "instances": {
    "delta": 232,
    "max": 128,
    "max_server": 132,
    "min_ttl": "min_ttl4"
  },
  "thresholds": [
    {
      "type": "ram",
      "details": {
        "used": "used2"
      }
    },
    {
      "type": "ram",
      "details": {
        "used": "used2"
      }
    },
    {
      "type": "ram",
      "details": {
        "used": "used2"
      }
    }
  ]
}
```

