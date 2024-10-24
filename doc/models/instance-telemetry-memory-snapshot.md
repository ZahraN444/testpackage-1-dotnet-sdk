
# Instance Telemetry Memory Snapshot

A snapshot of memory usage statistics.

## Structure

`InstanceTelemetryMemorySnapshot`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cache` | `double?` | Optional | The number of bytes of page cache memory being used by this instance. |
| `Usage` | [`MemoryData1`](../../doc/models/memory-data-1.md) | Optional | The memory usage data. |
| `SwapUsage` | [`MemoryData2`](../../doc/models/memory-data-2.md) | Optional | Memory swap usage data. |
| `KernelUsage` | [`MemoryData3`](../../doc/models/memory-data-3.md) | Optional | Kernal memory usage. |
| `KernelTcpUsage` | [`MemoryData4`](../../doc/models/memory-data-4.md) | Optional | Kernel TCP buffer usage. |

## Example (as JSON)

```json
{
  "cache": 49.22,
  "usage": {
    "usage": 26.36,
    "max_usage": 92.64,
    "fail_count": 29.74,
    "limit": 31.94
  },
  "swap_usage": {
    "usage": 13.36,
    "max_usage": 79.64,
    "fail_count": 42.74,
    "limit": 237.06
  },
  "kernel_usage": {
    "usage": 162.76,
    "max_usage": 229.04,
    "fail_count": 149.34,
    "limit": 87.66
  },
  "kernel_tcp_usage": {
    "usage": 101.16,
    "max_usage": 167.44,
    "fail_count": 210.94,
    "limit": 149.26
  }
}
```

