
# Server Stats Cpu

Statistics about the CPU resources on a server.

## Structure

`ServerStatsCpu`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cores` | `int?` | Optional | The number of CPU's or vCPU's for a given server. |
| `Processors` | [`List<Processor>`](../../doc/models/processor.md) | Optional | An array of processor information objects. |
| `Usage` | [`ServerStatsCpuUsage`](../../doc/models/server-stats-cpu-usage.md) | Optional | - |

## Example (as JSON)

```json
{
  "cores": 10,
  "processors": [
    {
      "model": "model2",
      "speed": 12.92
    }
  ],
  "usage": {
    "user": 2,
    "nice": 30,
    "system": 206,
    "idle": 254,
    "iowait": 180
  }
}
```

