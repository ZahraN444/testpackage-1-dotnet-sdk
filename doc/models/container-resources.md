
# Container Resources

Configuration settings for the resource allocations and limits of a given container.

## Structure

`ContainerResources`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cpu` | [`Cpu1`](../../doc/models/cpu-1.md) | Required | Configurations settings related to CPU usage. |
| `Ram` | [`Ram2`](../../doc/models/ram-2.md) | Required | Configuration settings for limits and reserves of RAM resources for the given container. |

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
    "limit": "1G, 2M",
    "reserve": "reserve0"
  }
}
```

