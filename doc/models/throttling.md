
# Throttling

Throttling statistics.

## Structure

`Throttling`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Periods` | `int?` | Optional | The amount of periods that have passed since the last restart. |
| `ThrottledPeriods` | `int?` | Optional | How many times the instance has been throttled for using all its alloted CPU during a period. |
| `ThrottledTime` | `int?` | Optional | The amount of time in nanoseconds this instnace has spent with throttled CPU resources. |

## Example (as JSON)

```json
{
  "periods": 16,
  "throttled_periods": 146,
  "throttled_time": 214
}
```

