
# HA Proxy Config

## Structure

`HAProxyConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Frontend` | [`Frontend`](../../doc/models/frontend.md) | Required | Settings that describe how incoming traffic to the load balancer is handled. |
| `Backend` | [`Backend`](../../doc/models/backend.md) | Required | Settings related to how the load balancer routes connections to container instances. |

## Example (as JSON)

```json
{
  "frontend": {
    "mode": "tcp",
    "max_connections": 190,
    "timeouts": {
      "client_secs": 228,
      "client_fin_ms": 250,
      "http_keep_alive_ms": 122,
      "http_request_ms": 102
    }
  },
  "backend": {
    "balance": "roundrobin",
    "timeouts": {
      "server_secs": 200,
      "server_fin_ms": 126,
      "connect_ms": 174,
      "queue_ms": 16,
      "tunnel_secs": 16
    }
  }
}
```

