
# Memory Data 3

Kernal memory usage.

## Structure

`MemoryData3`

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
  "usage": 41.76,
  "max_usage": 108.04,
  "fail_count": 14.34,
  "limit": 208.66
}
```

