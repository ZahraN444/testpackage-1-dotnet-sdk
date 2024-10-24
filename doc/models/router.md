
# Router

## Structure

`Router`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Destinations` | [`Dictionary<string, Destinations>`](../../doc/models/destinations.md) | Optional | - |

## Example (as JSON)

```json
{
  "destinations": {
    "key0": {
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
        98,
        99,
        100
      ],
      "instance_id": "instance_id2",
      "container_id": "container_id8"
    }
  }
}
```

