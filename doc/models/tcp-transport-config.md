
# Tcp Transport Config

Additional configuration options for the TCP transport mode.

## Structure

`TcpTransportConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"tcp"` |
| `Details` | [`Details1`](../../doc/models/details-1.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "tcp",
  "details": {
    "connections": {
      "key0": {
        "key1": "val1",
        "key2": "val2"
      },
      "key1": {
        "key1": "val1",
        "key2": "val2"
      },
      "key2": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  }
}
```

