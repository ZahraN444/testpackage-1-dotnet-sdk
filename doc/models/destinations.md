
# Destinations

## Structure

`Destinations`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Connections` | [`Connections1`](../../doc/models/connections-1.md) | Required | - |
| `Requests` | [`Requests`](../../doc/models/requests.md) | Required | - |
| `LatencyMs` | `List<int>` | Optional | - |
| `InstanceId` | `string` | Required | - |
| `ContainerId` | `string` | Required | - |

## Example (as JSON)

```json
{
  "connections": {
    "success": 136,
    "unavailable": 28,
    "errors": {
      "key0": 81,
      "key1": 82,
      "key2": 83
    },
    "bytes_transmitted": 44,
    "bytes_received": 2
  },
  "requests": {
    "total": 146,
    "responses": {
      "key0": 151
    },
    "errors": {
      "key0": 177,
      "key1": 178,
      "key2": 179
    }
  },
  "latency_ms": [
    218,
    219
  ],
  "instance_id": "instance_id8",
  "container_id": "container_id8"
}
```

