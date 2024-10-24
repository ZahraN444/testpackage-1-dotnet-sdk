
# Memory Data 4

Kernel TCP buffer usage.

## Structure

`MemoryData4`

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
  "usage": 120.66,
  "max_usage": 186.94,
  "fail_count": 191.44,
  "limit": 129.76
}
```

