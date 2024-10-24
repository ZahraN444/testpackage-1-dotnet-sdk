
# Resources

## Structure

`Resources`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cpu` | [`Cpu`](../../doc/models/cpu.md) | Optional | - |
| `Ram` | [`Ram1`](../../doc/models/ram-1.md) | Optional | - |

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

