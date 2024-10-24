
# Ha Proxy Lb Type

## Structure

`HaProxyLbType`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Ipv4` | `bool` | Required | Allow / disallow traffic to be routed via IPv4. |
| `Ipv6` | `bool` | Required | Allow / disallow traffic to be routed via IPv6. |
| `Type` | `string` | Required, Constant | **Default**: `"haproxy"` |
| `Details` | [`HaProxyLbTypeDetails`](../../doc/models/containers/ha-proxy-lb-type-details.md) | Required | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "ipv4": false,
  "ipv6": false,
  "type": "haproxy",
  "details": {
    "default": {
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
    },
    "ports": {
      "key0": {
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
      },
      "key1": {
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
      },
      "key2": {
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
    }
  }
}
```

