
# Auto Scale Group Scale

## Structure

`AutoScaleGroupScale`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Down` | [`AutoScaleGroupScaleDown`](../../doc/models/auto-scale-group-scale-down.md) | Optional | - |
| `Up` | [`AutoScaleGroupScaleUp`](../../doc/models/auto-scale-group-scale-up.md) | Optional | - |

## Example (as JSON)

```json
{
  "down": {
    "min_ttl": "min_ttl2",
    "inactivity_period": "inactivity_period2",
    "method": "fifo"
  },
  "up": {
    "maximum": 194
  }
}
```

