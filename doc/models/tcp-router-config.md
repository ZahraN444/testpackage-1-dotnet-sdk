
# Tcp Router Config

Additional configuration options for TCP mode routers

## Structure

`TcpRouterConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"tcp"` |
| `Details` | `object` | Required | - |

## Example (as JSON)

```json
{
  "type": "tcp",
  "details": {
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
```

