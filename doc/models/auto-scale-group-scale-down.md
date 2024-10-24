
# Auto Scale Group Scale Down

## Structure

`AutoScaleGroupScaleDown`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MinTtl` | `string` | Optional | The minimum TTL for the server once deployed through an autoscale event. |
| `InactivityPeriod` | `string` | Optional | The amount of time between last instance deployed and when the server can begin to get deleted. |
| `Method` | [`MethodEnum?`](../../doc/models/method-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "min_ttl": "72h45m2s",
  "inactivity_period": "72h45m2s",
  "method": "fifo"
}
```

