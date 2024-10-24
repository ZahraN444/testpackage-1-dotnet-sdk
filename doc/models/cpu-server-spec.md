
# CPU Server Spec

Information about the CPU for a given server.

## Structure

`CPUServerSpec`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Count` | `int` | Required | The number of CPUs. |
| `Cores` | `int?` | Optional | The number of cores. |
| `Threads` | `int?` | Optional | The number of threads. |
| `Type` | `string` | Required | The type of the CPU. |
| `Shared` | `bool?` | Optional | A boolean where true represents the CPU is shared. |
| `Extra` | `Dictionary<string, string>` | Optional | Extra information about the CPU if there is any. |

## Example (as JSON)

```json
{
  "count": 132,
  "cores": 14,
  "threads": 202,
  "type": "type2",
  "shared": false,
  "extra": {
    "key0": "extra0",
    "key1": "extra9",
    "key2": "extra8"
  }
}
```

