
# Stack Container Config Resources

## Structure

`StackContainerConfigResources`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cpu` | [`Cpu`](../../doc/models/cpu.md) | Required | - |
| `Ram` | [`Ram1`](../../doc/models/ram-1.md) | Required | - |

## Example (as JSON)

```json
{
  "cpu": {
    "shares": {
      "limit": 214,
      "reserve": 14
    },
    "cpus": "cpus2"
  },
  "ram": {
    "limit": "limit4",
    "reserve": "reserve0",
    "swappiness": 93.52
  }
}
```

