
# Memory Data 1

The memory usage data.

## Structure

`MemoryData1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Usage` | `double?` | Optional | The number in bytes of memory being used by the instance at the time of the snapshot. |
| `MaxUsage` | `double?` | Optional | The highest amoun tof memory usage since the last restart. |
| `FailCount` | `double?` | Optional | The number of times the memory liimit was exceeded for the instance. |
| `Limit` | `double?` | Optional | The maximum number of bytes of memory this instance has acess to. |

## Example (as JSON)

```json
{
  "usage": 66.1,
  "max_usage": 132.38,
  "fail_count": 246.0,
  "limit": 184.32
}
```

